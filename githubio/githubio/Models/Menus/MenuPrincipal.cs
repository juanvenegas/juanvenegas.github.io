using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models.Menus
{
    public class MenuPrincipal
    {
        [Key]
        public int IdMenu { get; set; }
        public int IdSeccion { get; set; }
        [StringLength(150)]
        public string NombreMenu { get; set; }
        public string ControladorMenu { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
    }
}