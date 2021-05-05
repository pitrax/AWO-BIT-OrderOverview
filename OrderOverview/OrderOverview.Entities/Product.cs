
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderOverview.Entities
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("Produktcode"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),Required(ErrorMessage ="{0} ist erforderlich")]
        public int ProductCode { get; set; }

        [DisplayName("Name"),Required(ErrorMessage = "{0} ist erforderlich")]
        public string Name { get; set; }

        public string Status { get; set; }

        public int ProductCategoriesId { get; set; }

        public virtual ProductCategory ProductCategories { get; set; }
    }
}
