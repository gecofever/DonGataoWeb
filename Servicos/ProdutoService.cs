using DonGataoWeb.Modelos;
using DonGataoWeb.Servicos;
using Microsoft.AspNetCore.Http.Features;

namespace DonGataoWeb.Pages;

public class ProdutoService : IProdutoService
{
    public ProdutoService()
        => CarregarListaInicial();
    private IList<Produto> _produtos;

    private void CarregarListaInicial()
    {
        _produtos = new List<Produto>()
        {
            new Produto
            {
                ProdutoId = 1,
                Nome = "Shaving",
                Descricao = "Utilizado para facilitar o barbear, faz com que a lâmina deslize, sem agradir  a pele, auxiliandndo na hidratação dos pêlos.",
                ImagemUri = "/images/shaving.jpg",
                Preco = 35.00,
                Delivery = true,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                ProdutoId = 2,
                Nome = "Pomada Modeladora",
                Descricao = "Modele seus cortes e penteados, deixe seus cabelos sempre com aspecto arrumado e aproveite nossos aromas.",
                ImagemUri = "/images/pomada.jpg",
                Preco = 17.00,
                Delivery = true,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                ProdutoId = 3,
                Nome = "Loção Pós Barba",
                Descricao = "Protege sua pele de irritações e deixa perfumada e macia",
                ImagemUri = "/images/locao.jpg",
                Preco = 28.00,
                Delivery = true,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                ProdutoId = 4,
                Nome = "Maquina de Corte",
                Descricao = "Maquina de uso profissional, motor mais pontente da categoria, com diversos pentes para tamanhos de cabelo.",
                ImagemUri = "/images/maquina.jpg",
                Preco = 480.00,
                Delivery = true,
                DataCadastro = DateTime.Now
            }
        };
    }
    public IList<Produto> ObterTodos()
    => _produtos;

    public Produto Obter(int id)
        => ObterTodos().SingleOrDefault(item => item.ProdutoId == id);

    public void Incluir(Produto produto)
    {
        var proximoID = _produtos.Max(item => item.ProdutoId) + 1;
        produto.ProdutoId = proximoID;
        _produtos.Add(produto);
    }

    public void Alterar(Produto produto)
    {
        var produtoEncontrado = _produtos.SingleOrDefault(item => item.ProdutoId == produto.ProdutoId);
        produtoEncontrado.Nome = produto.Nome;
        produtoEncontrado.Descricao = produto.Descricao;
        produtoEncontrado.ImagemUri = produto.ImagemUri;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.Delivery = produto.Delivery;
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _produtos.Remove(produtoEncontrado);
    }
    
}