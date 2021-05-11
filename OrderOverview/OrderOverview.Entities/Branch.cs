using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Branch:MyEntityBase
    {
      
        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(40)]
        public string Name { get; set; }

        [DisplayName("Kostenstelle"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(20)]
        public string CostCenter { get; set; }

        [DisplayName("Adress"),StringLength(60)]
        public string Adress { get; set; }

        [DisplayName("Status"), StringLength(30)]
        public string Status { get; set; }

        public int ClientsId { get; set; }

        public virtual Client Clients { get; set; }

        public virtual List<Employee> Employee { get; set; }

    }
}
