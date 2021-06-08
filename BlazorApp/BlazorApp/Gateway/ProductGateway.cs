using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Gateway
{
    public class ProductGateway
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public bool Add(Product product)
        {
            _db.Products.Add(product);
            int rowAffected = _db.SaveChanges();
            if(rowAffected>0)
            {
                return true;

            }
            return false;
        }

       public List<Product>GetAll()
        {
            return _db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _db.Products.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Product product)
        {
            _db.Products.Update(product);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                return true;

            }
            return false;
        }
        public bool Delete(int id)
        {
            var product = _db.Products.FirstOrDefault(c => c.Id == id);
            if(product!=null)
            {
                _db.Products.Remove(product);
                int rowAffected = _db.SaveChanges();
                if(rowAffected>0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
