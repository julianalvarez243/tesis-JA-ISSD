using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        public string Contrasenia { get; set; }

        [Required]
        public string Rol { get; set; } = "Mozo";

    }
}
