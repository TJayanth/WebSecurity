using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecuredApplication.Models
{
    public class TransferMoneyDTO
    {
        public string TransactionId { get; set; }
        public string FromAccount { get; set; }
        public string ToAccountName { get; set; }
        public string ToAccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string Amount { get; set; }

        public bool IsTransfered { get; set; }

    }
}
