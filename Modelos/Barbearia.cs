using System.ComponentModel.DataAnnotations;

namespace DonGataoWeb.Modelos;

public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
    [StringLength(40, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve conter entre 10 e 40 caracteres.")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
    [StringLength(250, MinimumLength = 30, ErrorMessage = "Campo 'Nome' deve conter entre 30 e 250 caracteres.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Campo 'Caminho URL da imagem' obrigatório.")]
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUri { get; set; }

    [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }
    
    [Display(Name = "Faz Entregar")]
    public bool Delivery { get; set; }
    public string DeliveryFormatado => Delivery ? "Sim" : "Não";

    [Display(Name = "Disponível desde")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    public DateTime DataCadastro { get; set; }
}