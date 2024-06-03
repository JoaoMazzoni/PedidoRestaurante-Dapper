using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string Conn { get; set; }
        public PedidoRepository()
        {
            Conn = "Server=127.0.0.1; Database=DBPedidoRestaurante; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        }

        public bool Inserir(Pedido pedido)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa) VALUES (@Descricao, @Mesa)", pedido);
                // Comando da biblioteca Dapper | Substitui todo aquele comando extenso para adicionar no banco.

                status = true;  
                db.Close();
            }


            return status;

        }





    }
}
