
namespace Models
{
    public class Item
    {                                                                                         // Seleciona e retorna na forma de INT o IDENTITY (ID) da inserção mais recente de uma tabela.
        public readonly static string INSERT = "INSERT INTO TB_ITEM (Descricao) VALUES (@Descricao); SELECT CAST(SCOPE_IDENTITY() AS INT)";
        
        public int ItemId { get; set; }
        public string Descricao { get; set; }   
        
    }
}
