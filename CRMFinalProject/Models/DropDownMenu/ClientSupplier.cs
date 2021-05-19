using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.DropDownMenu
{
    public class ClientSupplier
    {

        public int ClientSupplierID { get; set; }
        public string ClientSupplierName { get; set; }

        public static implicit operator ClientSupplier(int v)
        {
            throw new NotImplementedException();
        }
    }
}
