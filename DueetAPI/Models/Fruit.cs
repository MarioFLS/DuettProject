using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DueetAPI.Models
{
    public class Fruit
    {
        [Key]
        public int Id { get; set; }
        
        [Column("name")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MinLength(5, ErrorMessage = "O texto deve ter no mínimo 5 caracteres!")]
        public string Name { get; set; } = default!;

        [Column("description")]
        [Required(ErrorMessage = "O descrição é obrigatória!")]
        [MinLength(5, ErrorMessage = "O texto deve ter no mínimo 5 caracteres!")]
        public string Description { get; set; } = default!;

        [Column("value")]
        [Required(ErrorMessage = "O valor é obrigatória!")]
        [Range(1.0, double.MaxValue, ErrorMessage = "O valor atual = {0} deve ser maior que R${1}!")]
        public decimal Value { get; set; }

        [Column("tax")]
        [Required(ErrorMessage = "O taxa é obrigatória!")]
        [Range(1.0, double.MaxValue, ErrorMessage = "A taxa deve ser maior que {1}%!")]
        public decimal Tax { get; set; }

    }
}
