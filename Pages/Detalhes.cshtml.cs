using DonGataoWeb.Modelos;
using DonGataoWeb.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonGataoWeb.Pages
{
    public class DetalhesModel : PageModel
    {
        private IProdutoService _service;
        public DetalhesModel(IProdutoService service)
        {
            _service = service;
        }
        public Produto Produto { get; private set; }
        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
