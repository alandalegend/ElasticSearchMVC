using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESmvc.Models
{
    public class Pagina
    {

        /// <summary>
        /// Pagina del libro
        /// </summary>
        public Int32 NumPagina { get; set; }
        /// <summary>
        /// Texto de la página
        /// </summary>
        public string Texto { get; set; }
    }
}