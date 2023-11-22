using DonGataoWeb.Modelos;
namespace DonGataoWeb.Servicos;

public interface IProdutoService
{
    IList<Produto> ObterTodos();
    Produto Obter(int id);
    void Incluir(Produto produto);
    void Alterar(Produto produto);
    void Excluir(int id);
}