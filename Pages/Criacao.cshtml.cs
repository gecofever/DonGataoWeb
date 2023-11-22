using DonGataoWeb.Modelos;
using DonGataoWeb.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonGataoWeb.Pages
{
    public class CriacaoModel : PageModel
    {
        private IProdutoService _service;
        public CriacaoModel(IProdutoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Incluir(Produto);

            return RedirectToPage("/Index");
        }
    }
}
