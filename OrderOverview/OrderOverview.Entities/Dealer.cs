using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderOverview.Entities
{
    public class Dealer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string Name { get; set; }

        [DisplayName("Adress"),StringLength(80)]
        public string Adress { get; set; }

        [DisplayName("E-mail"), StringLength(40)]
        public string Email { get; set; }

        [DisplayName("Phone"), StringLength(20)]
        public string Phone { get; set; }

        public string Status { get; set; }

    }
}
