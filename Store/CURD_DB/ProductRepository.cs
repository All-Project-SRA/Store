using Store.Models;
using Store.Models.DB;
using System.Collections.Generic;
using System.Linq;

namespace Store.CURD_DB
{
    public class ProductsRepository
    {
        private readonly AppDbContext db;
        private Product _table;
    

        public ProductsRepository(AppDbContext context)
        {
            db = context;
        }
        /*
        public int Add(Product table)
        {
            if (db.Database.CanConnect())
            {
                db.Productss.Add(table);
                db.SaveChanges();
                return 1;

            }
            else
            {
                return 0;
            }

        }
        */

        public int Delete(int id)
        {
            if (db.Database.CanConnect())
            {
                _table = Find(id);
                db.Products.Remove(_table);
                db.SaveChanges();
                return 1;

            }
            else
            {
                return 0;
            }
        }

        public int Edit(int id, Product table)
        {
          //  db = new AppDbContext();

            if (db.Database.CanConnect())
            {
                db.Products.Update(table);
                db.SaveChanges();
                return 1;

            }
            else
            {
                return 0;
            }
        }

        public Product Find(int id)
        {
            if (db.Database.CanConnect())
            {
                return db.Products.Where(x => x.id == id).First();

            }
            else
            {
                return null;
            }
        }

        public List<Product> GetAllData()
        {
            if (db.Database.CanConnect())
            {
                return db.Products.ToList();

            }
            else
            {
                return null;
            }

        }
        /*
        public List<Product> GetAllDataByUser(string Userid)
        {
            if (db.Database.CanConnect())
            {
               return db.Products.Where(x => x. == Userid).ToList();

            }
            else
            {
                return null;
            }
        }
        */
        /*
        public List<Product> Search(string Searchitem)
        {
            if (db.Database.CanConnect())
            {
                return db.Products.Where(x => x.Fullname.Contains(Searchitem)
                || x.PostTitle == Searchitem
                || x.PostCatogary == Searchitem
                || x.PostTitle == Searchitem
                ).ToList();

            }
            else
            {
                return null;
            }
        }*/
    }
}




    

