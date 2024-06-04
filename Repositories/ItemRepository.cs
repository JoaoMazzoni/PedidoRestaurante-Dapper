

using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class ItemRepository : IItemRepository
    {
        private string Conn { get; set; }

        public ItemRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public int Inserir(Item item)
        {
            int idItem = 0;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();                                                             
                idItem = db.ExecuteScalar<int>(Item.INSERT, item); // ExecuteScalar - Retorna a primeira Coluna da primeira Linha                                                                                                                No caso, irá retornar com base na tabela gerada pelo SELECT.
                db.Close();
            }

            return idItem;

        }
    }
}
