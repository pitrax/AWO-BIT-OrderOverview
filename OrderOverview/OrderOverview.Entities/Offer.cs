
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Offer: EntityBase
    {
        [DisplayName("Produktnummer"),Required(ErrorMessage ="{0} muss eingegeben werden")]
        public int ProductNr { get; set; }

        [DisplayName("Produktname"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public string ProductName { get; set; }

        [DisplayName("Preis"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public double Price { get; set; }

        [DisplayName("Beschreibung")]
        public string Description { get; set; }

        public string Link { get; set; }

        [DisplayName("Nachweis von Angebot")]
        public string ProofPhoto { get; set; }

        [DisplayName("Beschtätigun von Bieterspiegel")]
        public bool OfferConfirmation { get; set; }

        public string Status { get; set; }

        public int DealersID{ get; set; }

        public int AssignmentsId { get; set; }

        public Dealer Dealers { get; set; }

      

        public virtual Assignment Assignments { get; set; }
    }
}
