using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderOverview.Entities
{
    public class ProductCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Status"), StringLength(50)]
        public string Status { get; set; }

        public List<Product> Products { get; set; }


    }
}
