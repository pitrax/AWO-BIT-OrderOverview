using OrderOverview.DataAccessLayer;
using OrderOverview.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOverview.BusinessLayer
{
  
    public class ProductCategoryManager
    {
        DatabaseContext db = new DatabaseContext();

        public ProductCategory Insert(ProductCategory category)
        {
            category.CreatedOn = DateTime.Now;
            category.ModifiedOn = DateTime.Now;
            category.ModifiedUserName = "system";
            category.Status = "Aktiv";
            db.ProductCategories.Add(category);
            db.SaveChanges();
            return category;
        }

        public List<ProductCategory> GetProductCategory()
        {

            List<ProductCategory> productCategory = db.ProductCategories.ToList();
            return productCategory;
        }
    }
}
