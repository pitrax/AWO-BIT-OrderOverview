using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace OrderOverview.Entities
{
    public class Order:MyEntityBase
    {
        [DisplayName("Bestellungsnummer"), Required(ErrorMessage = "{0} muss eingegeben werden"), StringLength(30)]
        public string OrderNr { get; set; }

        [DisplayName("Menge"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int Quantity { get; set; }

        [DisplayName("Preis"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public double Price { get; set; }

        [DisplayName("Produktnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int ProductNr { get; set; }

        [DisplayName("Produktname"), Required(ErrorMessage = "{0} muss eingegeben werden"), StringLength(30)]
        public string ProductName { get; set; }

        [DisplayName("Beschreibung"), StringLength(200)]
        public string Description { get; set; }

        public int DealerId { get; set; }

        public int AssignmentId { get; set; }

        public int ConfirmedOfferId { get; set; }

        public virtual Dealer Dealers { get; set; }

        public virtual Assignment Assignments { get; set; }

        public virtual Offer ConfirmedOffer { get; set; }

    }
}
