
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Assignment : EntityBase
    {
        [DisplayName("Auftragsnummer"), StringLength(50)]
        public string AssignmentNr { get; set; }

        [DisplayName("Maximalerpreis"), Required(ErrorMessage ="{0} muss eingegeben werden")]
        public double MaximumPreis { get; set; }

        [DisplayName("Mit Bieterspiegel")]
        public bool WithOffer { get; set; }

        [DisplayName("Maximalerpreis")]
        public int Quantity { get; set; }

        [DisplayName("Beschreibung")]
        public string Description { get; set; }

        [DisplayName("Ticketnummer")]
        public string TicketNr { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }


        public int EmployeesID { get; set; }

        public int ProductCategoriesID { get; set; }

        public virtual Employee Employees { get; set; }
        public virtual ProductCategory ProductCategories { get; set; }
    }
}
