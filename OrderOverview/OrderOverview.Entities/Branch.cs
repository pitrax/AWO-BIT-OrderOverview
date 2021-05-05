using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Branch:EntityBase
    {
      
        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string Name { get; set; }

        [DisplayName("Kostenstelle"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string CostCenter { get; set; }

        [DisplayName("Adress"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string Adress { get; set; }

        public string Status { get; set; }

        public int ClientsId { get; set; }

        public virtual Client Clients { get; set; }
    }
}
