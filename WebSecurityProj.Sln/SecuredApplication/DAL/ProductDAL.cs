using SecuredApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SecuredApplication.DAL
{
    public class ProductDAL
    {
        string connectionString = "Data Source=JAYANTH-PC\\SQLSERVER; Initial Catalog=ProductMaster;User ID=sa;Password=India@123";

        public TrackDeliveryVM GetAllDeliveries(TrackDeliveryVM trackDeliveryVM)
        {
            trackDeliveryVM.DeliveriesList = new List<DeliveriesDTO>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string commandText = "SELECT * FROM Deliveries WHERE WayBillNo =@WayBillNo";
                    SqlCommand cmd = new SqlCommand(commandText, con);
                    cmd.Parameters.Add("@WayBillNo", SqlDbType.Int);
                    cmd.Parameters["@WayBillNo"].Value = trackDeliveryVM.WayBillNo;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        DeliveriesDTO deliveryDTO = new DeliveriesDTO();
                        deliveryDTO.DeliveryId = Convert.ToString(rdr["DeliveryId"]);
                        deliveryDTO.WayBillNo = Convert.ToInt32(rdr["WayBillNo"]);
                        deliveryDTO.FromAddress = Convert.ToString(rdr["FromAddress"]);
                        deliveryDTO.ReceiverName = Convert.ToString(rdr["ReceiverName"]);
                        deliveryDTO.ToAddress = Convert.ToString(rdr["ToAddress"]);
                        deliveryDTO.PanCardNo = Convert.ToString(rdr["PanCardNo"]);
                        deliveryDTO.Phone = Convert.ToString(rdr["Phone"]);
                        deliveryDTO.IsDelivered = Convert.ToBoolean(rdr["IsDelivered"]);
                        deliveryDTO.IsActive = Convert.ToBoolean(rdr["IsActive"].ToString());

                        trackDeliveryVM.DeliveriesList.Add(deliveryDTO);
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                trackDeliveryVM.IsError = true;
            }

            return trackDeliveryVM;
        }

        public List<ProductsDTO> GetAllProducts()
        {
            List<ProductsDTO> lstProducts = new List<ProductsDTO>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Products order by createddate desc"), con);

                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ProductsDTO productsDTO = new ProductsDTO();
                    productsDTO.ProductId = Convert.ToString(rdr["ProductId"]);
                    productsDTO.ProductName = Convert.ToString(rdr["ProductName"]);
                    productsDTO.ManufacturerName = Convert.ToString(rdr["ManufacturerName"]);
                    productsDTO.Description = Convert.ToString(rdr["Description"]);
                    productsDTO.Price = Convert.ToString(rdr["Price"]);
                    productsDTO.IsAvailable = Convert.ToBoolean(rdr["IsAvailable"]);
                    productsDTO.IsActive = Convert.ToBoolean(rdr["IsActive"]);
                    productsDTO.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    lstProducts.Add(productsDTO);
                }
                con.Close();
            }
            return lstProducts;
        }

        public List<ProductsDTO> SaveProduct(ProductsDTO productsDTO)
        {
            List<ProductsDTO> lstProducts = new List<ProductsDTO>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO [Products] ([ProductId] ,[ProductName] ,[ManufacturerName] ,[Price] ,[IsAvailable] ,[IsActive] ,[Description] ,[CreatedDate]) VALUES ( '{0}' ,'{1}' ,'{2}' ,{3} ,{4} ,{5} ,'{6}' ,'{7}' )", Guid.NewGuid().ToString(), productsDTO.ProductName, productsDTO.ManufacturerName, productsDTO.Price, productsDTO.IsAvailable == true ? 1 : 0, productsDTO.IsActive == true ? 1 : 0, productsDTO.Description, DateTime.Now), con);

                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }

                con.Close();
            }
            return lstProducts;
        }

        public List<ProductsDTO> DeleteProduct(string productId)
        {
            List<ProductsDTO> lstProducts = new List<ProductsDTO>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(string.Format("Delete Products where productId = '{0}'", productId), con);

                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }

                con.Close();
            }
            return lstProducts;
        }
    }
}
