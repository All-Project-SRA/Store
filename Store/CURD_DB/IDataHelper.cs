using System.Collections.Generic;

namespace Store.CURD_DB
{



    public interface IDataHelper<Table>
    {
        List<Table> GetAllData();
        List<Table> GetAllDataByUser(string Userid);

        List<Table> Search(string Searchitem);

        Table Find(int id);

       

        int Add(Table table);
        int Edit(int id, Table table);
        int Delete(int id);

    }
}
