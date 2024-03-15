using Microsoft.EntityFrameworkCore;
using Store.Models;
using Store.Models.DB;
using System.Collections.Generic;
using System.Linq;

namespace Store.CURD_DB
{
    public class CategorieRepository : IDataHelper<Categorie>
    {



        private readonly AppDbContext db;
        private Product _table;


        public CategorieRepository(AppDbContext context)
        {
            db = context;
        }


        public int Add(Categorie table)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Edit(int id, Categorie table)
        {
            throw new System.NotImplementedException();
        }

        public Categorie Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Categorie> GetAllData( )
        {
            
            return db.Categories.Include(x=>x.Catgories_M).ToList();
            

        }

        

        public List<Categorie> GetAllDataByUser(string Userid)
        {
            throw new System.NotImplementedException();
        }

        public List<Categorie> Search(string Searchitem)
        {
            throw new System.NotImplementedException();
        }
    }
}
