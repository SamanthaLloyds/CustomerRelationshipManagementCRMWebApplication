using System;
using System.ComponentModel.DataAnnotations;
using CooperativeFuneralFundInc.Models.DropDownMenu;


namespace CooperativeFuneralFundInc.Models.SupplyRequest
{
    public class SupplyRequest
    {

        public int SupplyRequestId { get; set; }

      //  public int Status { get; set; }
        public string Status { get; set; }

        public string StatusComments { get; set; }

        [Required(ErrorMessage = "Item selection is required, please verify")]

       // public int OrderItemsID { get; set; }
        public string OrderItems { get; set; }


        [Required(ErrorMessage = "Request origin is required, please verify")]
     //   public int RequestOriginId { get; set; }
        public string SupplyRequestOrigin { get; set; }

        
       // public int RequestType { get; set; }
        public string RequestType { get; set; }


        [Required(ErrorMessage = "Client is required, please verify")]
       // public int ClientSupplierID { get; set; }
        public string Client { get; set; }

       // public int Owner { get; set; }
        public string Owner { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateTime { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }




    }
}