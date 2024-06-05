using Controllers;
using Models;
using System.Threading.Channels;

Console.WriteLine("Inicio...");

//Pedido pedido = new Pedido
//{
//    Id = 1,
//    Descricao = "Quero tudo10",
//    Mesa = 10,
//    Item = new Item { Descricao = "Item top!" }
//};

//if (new PedidoController().Inserir(pedido))
//{
//    Console.WriteLine("Inseriu tudo!!!!");
//}
//else
//{
//    Console.WriteLine("ERRO");
//}

new PedidoController().GetAll().ForEach( x => Console.WriteLine(x));