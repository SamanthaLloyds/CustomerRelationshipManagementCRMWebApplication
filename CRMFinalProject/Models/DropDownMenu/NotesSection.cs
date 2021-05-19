using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CooperativeFuneralFundInc.Models.DropDownMenu
{
    public class NotesSection
    {
        public int NotesSectionId { get; set; }

        //public int RequestOriginId { get; set; }
        public RequestOrigin RequestOriginDescription { get; set; }

        public string Note { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Archived { get; set; }
    }
}
