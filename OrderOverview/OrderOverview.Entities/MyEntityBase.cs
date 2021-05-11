using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrderOverview.Entities
{

    public class MyEntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("Erstellungsdatum")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Geändert am")]
        public DateTime ModifiedOn { get; set; }

        [DisplayName("Geänderter Benutzername"), StringLength(30),Required(ErrorMessage = "{0} ist erforderlich")]
        public string ModifiedUserName { get; set; }
    }
}
