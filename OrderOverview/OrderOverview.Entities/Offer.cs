
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Offer: MyEntityBase
    {
        [DisplayName("Bieterspiegelnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public string OfferNr { get; set; }

        [DisplayName("Produktnummer"),Required(ErrorMessage ="{0} muss eingegeben werden")]
        public int ProductNr { get; set; }

        [DisplayName("Produktname"), Required(ErrorMessage = "{0} muss eingegeben werden"), StringLength(50)]
        public string ProductName { get; set; }

        [DisplayName("Preis"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public double Price { get; set; }

        [DisplayName("Beschreibung"), StringLength(200)]
        public string Description { get; set; }

        public string Link { get; set; }

        [DisplayName("Nachweis von Angebot"), StringLength(150)]
        public string ProofPhoto { get; set; }

        [DisplayName("Beschtätigun von Bieterspiegel")]
        public bool OfferConfirmation { get; set; }

        [DisplayName("Status"), StringLength(50)]
        public string Status { get; set; }

        public int DealersId { get; set; }
        public int OrdersId { get; set; }

        public int AssignmentsId { get; set; }

        public virtual Dealer Dealers { get; set; }

        public virtual Assignment  Assignments { get; set; }

        public virtual List<Order> Orders { get; set; }



    }
}
