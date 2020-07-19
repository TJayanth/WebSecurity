using HackerWebSite.Data;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace HackerWebSite
{

    public class TableChangeBroadcastService : ITableChangeBroadcastService
    {
        private const string TableName = "HackedLogin";
        private const string ConnectionString = "Data Source=JAYANTH-PC\\SQLSERVER; Initial Catalog=HackedDB;User ID=saadmin;Password=India@123";

        private SqlTableDependency<LoginDTO> _notifier;
        private IConfiguration _configuration;

        public event HackedLoginChangeDelegate OnHackedLoginChanged;

        public TableChangeBroadcastService(IConfiguration configuration)
        {
            _configuration = configuration;

            // SqlTableDependency will trigger an event 
            // for any record change on monitored table  
            _notifier = new SqlTableDependency<LoginDTO>(
                 ConnectionString,
                 TableName);
            _notifier.OnChanged += this.TableDependency_Changed;
            _notifier.Start();
        }

        // This method will notify the Blazor component about the stock price change stock
        private void TableDependency_Changed(object sender, RecordChangedEventArgs<LoginDTO> e)
        {
            this.OnHackedLoginChanged(this, new HackedLoginChangeEventArgs(e.Entity, e.EntityOldValues));
        }

        // This method is used to populate the HTML view 
        // when it is rendered for the first time
        public IList<LoginDTO> GetCurrentValues()
        {
            var result = new List<LoginDTO>();

            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM " + TableName;
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                result.Add(new LoginDTO
                                {   
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Password = reader.GetString(reader.GetOrdinal("Password")),
                                });
                            }
                        }
                    }
                }
            }

            return result;
        }

        public void Dispose()
        {
            _notifier.Stop();
            _notifier.Dispose();
        }
    }
}
