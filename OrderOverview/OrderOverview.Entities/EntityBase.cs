using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrderOverview.Entities
{


    public class EntityBase
    {    
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("Erstellungsdatum")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Geändert am")]
        public DateTime ModifiedOn { get; set; }

        [DisplayName("Geänderter Benutzername"),StringLength(40)]
        public string ModifiedUserName { get; set; }
    }
}
