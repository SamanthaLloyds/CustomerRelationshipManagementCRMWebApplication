using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using CooperativeFuneralFundInc.Models.DropDownMenu;

namespace CooperativeFuneralFundInc.Models.TasksManagement
{
    public class TaskManagement
    {

        public int TaskManagementId { get; set; }
     //   public int Status { get; set; }
        public string Status { get; set; }

        //public int Owner { get; set; }
        public string Owner { get; set; }
        public string RelatedTo { get; set; }
        public string RelatedToName { get; set; }

      //  public int RequestType { get; set; }
        public string RequestType { get; set; }

        public string Priority { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}