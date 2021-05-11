using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderOverview.Entities
{
    public class Employee:MyEntityBase
    {

        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(40)]
        public string Name { get; set; }

        [DisplayName("Adress"), StringLength(60)]
        public string Adress { get; set; }

        [DisplayName("Telefon"),StringLength(30)]
        public string Phone { get; set; }

        [DisplayName("E-mail"),StringLength(40)]
        public string Email { get; set; }

        public int BranchesId { get; set; }

       
        [DisplayName("Status"), StringLength(30)]
        public string Status { get; set; }

        public virtual Branch Branches { get; set; }

        public virtual List<Assignment> Assignments { get; set; }
    }
}
