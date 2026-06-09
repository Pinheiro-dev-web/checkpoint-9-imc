using System.ComponentModel.DataAnnotations;

namespace CadastroAlunos.Models
{
    public class Imc
    {
        [Required(ErrorMessage = "O peso é obrigatório.")]
        [Range(10, 300, ErrorMessage = "Por favor, digite um peso válido.")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "A altura é obrigatória.")]
        [Range(0.5, 2.5, ErrorMessage = "Por favor, digite uma altura válida.")]
        public double Altura { get; set; }

        public double Resultado { get; set; }
        public string Classificacao { get; set; } = string.Empty;
    }
}
