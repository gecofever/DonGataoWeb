using DonGataoWeb.Modelos;
using DonGataoWeb.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonGataoWeb.Pages
{
    public class EdicaoModel : PageModel
    {
        private IProdutoService _service;
        public EdicaoModel(IProdutoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Produto);

            return RedirectToPage("/Index");
        }
        public IActionResult OnPostExclusao()
        {
            _service.Excluir(Produto.ProdutoId);
            return RedirectToPage("/Index");
        }
    }
}
