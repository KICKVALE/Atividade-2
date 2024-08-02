using MinhaEmpresa.Cliente;
using MinhaEmpresa.Produto;
using System;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("João Silva", "joao.silva@exemple.com");
        Produto produto = new Produto("Agua");

        Console.WriteLine($"Cliente: {cliente.Nome} \nEmail: {cliente.Email} \nProduto: {produto.Produtos}");
    }
}