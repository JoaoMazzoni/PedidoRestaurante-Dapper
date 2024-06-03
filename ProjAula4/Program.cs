using Controllers;
using Models;

Console.WriteLine("Inicio...");

Pedido pedido = new Pedido()
{
    Descricao = "Quero Tudo",
    Mesa = 10

};


if (new PedidoController().Inserir(pedido))
{
    Console.WriteLine("Inseriu Tudo!");
}
else
{
    Console.WriteLine("Erro!");
}

