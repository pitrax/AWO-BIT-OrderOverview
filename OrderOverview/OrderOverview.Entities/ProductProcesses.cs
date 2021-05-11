using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class ProductProcesses:MyEntityBase
    {
    
        [DisplayName("Belegnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int ReceiptNr { get; set; }

        [DisplayName("Produktnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int ProductNr { get; set; }

        [DisplayName("Produktname"), Required(ErrorMessage = "{0} muss eingegeben werden"), StringLength(50)]
        public string ProductName { get; set; }

        [DisplayName("Menge"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int Quantity { get; set; }

        [DisplayName("Preis"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public double Price { get; set; }

        [DisplayName("Invertarnummer"), Required(ErrorMessage = "{0} muss eingegeben werden")]
        public int InventoryNumber  { get; set; }

        [DisplayName("Seriennummer")]
        public double SerialNumber { get; set; }

        [StringLength(30)]
        public string IMEI { get; set; }

        [DisplayName("Lehfrist")]
        public DateTime LoanPeriod { get; set; }

        [DisplayName("Beschreibung"), StringLength(200)]
        public string Description { get; set; }


        [DisplayName("Status"), StringLength(30)]
        public string Status { get; set; }



        public int GeneralProcessesId { get; set; }


       
        public virtual GeneralProcesses GeneralProcesses { get; set; }
    }
}
