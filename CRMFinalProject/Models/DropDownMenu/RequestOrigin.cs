using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.DropDownMenu
{
    public class RequestOrigin
    {
        public string RequestOriginId { get; set; }
        public string RequestOriginDescription { get; set; }

        public static implicit operator RequestOrigin(int v)
        {
            throw new NotImplementedException();
        }
    }
}
