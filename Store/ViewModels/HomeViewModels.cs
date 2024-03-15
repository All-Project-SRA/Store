using Store.CURD_DB;
using Store.Models;
using Store.Models.DB;
using System.Collections.Generic;

namespace Store.ViewModels
{
    public class HomeViewModels
    {
        private readonly AppDbContext appDbContext;

        public HomeViewModels(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List <Categorie > Categorie_data() {

            CategorieRepository categorieRepository = new CategorieRepository(appDbContext);

            return  categorieRepository.GetAllData();


        }
        public List<Categorie> product_data()
        {

            CategorieRepository categorieRepository = new CategorieRepository(appDbContext);

            return categorieRepository.GetAllData();


        }


    }
}
