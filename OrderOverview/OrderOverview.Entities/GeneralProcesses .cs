using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class GeneralProcesses:EntityBase
    {

        [DisplayName("Belegnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int ReceiptNr { get; set; }


        [DisplayName("Produktnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int ProductNr { get; set; }

        [DisplayName("Produktname"), Required(ErrorMessage = "{0} muss eingegeben werden"), StringLength(60)]
        public string ProductName { get; set; }

        [DisplayName("Menge"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int Quantity { get; set; }

        [DisplayName("Preis"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public double Price { get; set; }


        [DisplayName("Beschreibung"),StringLength(200)]
        public string Description { get; set; }

        

        public int ProcessCode { get; set; }

        public string Status { get; set; }

        public int OrderId { get; set; }

        public int UserId { get; set; }

        public virtual Order Orders { get; set; }

        public virtual User  Users { get; set; }

    }
}
