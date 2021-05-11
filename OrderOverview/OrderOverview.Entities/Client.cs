using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace OrderOverview.Entities

{
    public class Client:MyEntityBase
    {

        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string Name { get; set; }

        [DisplayName("Status"), StringLength(30)]
        public string Status { get; set; }

        public virtual List<Branch> Branches { get; set; }
    }
}
