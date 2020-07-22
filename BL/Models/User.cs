using BL.Enums;
using System.ComponentModel.DataAnnotations;

namespace BL.Models
{
    public class User : BaseModel
    {
        public User() : base()
        { }

        [Required(ErrorMessage = "O nome de usuário deve ser inserido.")]
        [StringLength(50, ErrorMessage = "O nome de usuário precisa conter menos de 50 caracteres.")]
        [MinLength(5, ErrorMessage = "O nome de usuário precisa conter mais 5 caracteres.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "O email deve ser inserido.")]
        [StringLength(100, ErrorMessage = "O e-mail precisa conter menos de 100 caracteres.")]
        [MinLength(7, ErrorMessage = "O e-mail precisa conter mais 7 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha deve ser inserida.")]
        [StringLength(255, ErrorMessage = "A senha precisa conter menos de 255 caracteres.")]
        [MinLength(8, ErrorMessage = "A senha precisa conter mais que 8 caracteres.")]
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
