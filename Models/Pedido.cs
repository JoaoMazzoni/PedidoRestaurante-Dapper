namespace Models
{
    public class Pedido
    {
        public readonly static string GETALL = "SELECT p.Id, p.Descricao, p.Mesa, i.ItemId, i.Descricao FROM TB_PEDIDO p inner join TB_ITEM i on p.ItemId = i.ItemId";
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Mesa { get; set; }
        public Item Item { get; set; }

        public override string? ToString()
        {
            return $"\nId: {Id}\nDescrição: {Descricao}\nMesa: {Mesa}\nItem: {Item.Descricao}";
        }
    }
}
