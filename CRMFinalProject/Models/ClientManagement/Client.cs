using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.ClientManagement
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Documents { get; set; }
        public string Branding { get; set; }
        public string ClientContacts { get; set; }
    }

}
