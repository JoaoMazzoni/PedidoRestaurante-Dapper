using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Models;
using System.Configuration;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string Conn { get; set; }
        public PedidoRepository()
        {
            //Conn = "Server=127.0.0.1; Database=DBPedidoRestaurante; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Inserir(Pedido pedido)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();                          //Nome das Colunas no Banco        Valores de cada Coluna
                db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa, ItemId) VALUES (@Descricao, @Mesa, @ItemId)", new {Descricao = pedido.Descricao, Mesa = pedido.Mesa, 
                    ItemId = pedido.Item.ItemId});
                // Comando da biblioteca Dapper | Substitui todo aquele comando extenso para adicionar no banco.
                status = true;  
                db.Close();
            }


            return status;

        }





    }
}
