using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace OrderOverview.Entities

{
    public class Client:EntityBase
    {

        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string Name { get; set; }

        public string Status { get; set; }
    }
}
