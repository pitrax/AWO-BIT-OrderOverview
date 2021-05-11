
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Assignment:MyEntityBase
    {
        [DisplayName("Auftragsnummer"), StringLength(50) ,Required(ErrorMessage = "{0} muss eingegeben werden")]
        public string AssignmentNr { get; set; }

        [DisplayName("Maximalerpreis"), Required(ErrorMessage ="{0} muss eingegeben werden")]
        public double MaximumPreis { get; set; }

        [DisplayName("Mit Bieterspiegel")]
        public bool WithOffer { get; set; }

        [DisplayName("Maximalerpreis")]
        public int Quantity { get; set; }

        [DisplayName("Beschreibung"), StringLength(50)]
        public string Description { get; set; }

        [DisplayName("Ticketnummer"), StringLength(20)]
        public string TicketNr { get; set; }

        [DisplayName("Status"),StringLength(50)]
        public string Status { get; set; }

        public int EmployeesId { get; set; }

        public int ProductCategoryID { get; set; }

      
        public virtual Employee Employees { get; set; }
       
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual List<Offer> Offers { get; set; }

        public virtual List<Order> Orders { get; set; }



    }
}
