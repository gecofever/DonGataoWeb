using DonGataoWeb.Modelos;
using DonGataoWeb.Servicos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonGataoWeb.Pages;

public class IndexModel : PageModel
{
    private IProdutoService _service;
    public IndexModel(IProdutoService service)
    {
        _service = service;
    }
    public IList<Produto> ListaProduto { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home Page";
        
        ListaProduto = _service.ObterTodos();
    }

    public void OnPost()
    {
        
    }
}