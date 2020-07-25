using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BL.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O email deve ser inserido.")]
        [StringLength(100, ErrorMessage = "O e-mail precisa conter menos de 100 caracteres.")]
        [MinLength(7, ErrorMessage = "O e-mail precisa conter mais 7 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha deve ser inserida.")]
        [StringLength(255, ErrorMessage = "A senha precisa conter menos de 255 caracteres.")]
        [MinLength(8, ErrorMessage = "A senha precisa conter mais que 8 caracteres.")]
        public string Password { get; set; }
    }
}
