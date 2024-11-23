using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    class ProductController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                using (IDbConnection db = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM products";
                    return db.Query<Product>(query);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
