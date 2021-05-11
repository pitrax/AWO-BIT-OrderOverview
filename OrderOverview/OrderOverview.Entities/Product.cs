
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderOverview.Entities
{
    public class Product:MyEntityBase
    {
       

        [DisplayName("Produktcode")]
        public int ProductCode { get; set; }

        [DisplayName("Name"),Required(ErrorMessage = "{0} ist erforderlich"),StringLength(60)]
        public string Name { get; set; }

        [DisplayName("Status"), StringLength(30)]
        public string Status { get; set; }

        public int ProductCategoriesId { get; set; }

        public virtual ProductCategory ProductCategories { get; set; }
    }
}
