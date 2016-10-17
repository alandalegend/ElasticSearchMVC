using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESmvc.Models
{

    /// <summary>
    /// Clase que define un libro, en él podrás encontrar algunas propiedades, mismas que se crean al momento de indexar a ElasticSearch
    /// </summary>
    public class Libro
    {
        public Libro()
        {
            this.Paginas = new List<Pagina>();
        }

        /// <summary>
        /// Identificador del Libro
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// Titulo del Libro
        /// </summary>
        public String Titulo { get; set; }

        /// <summary>
        /// Fecha en que se da de alta el libro
        /// </summary>
        public DateTime FechaAlta { get; set; }

        /// <summary>
        /// Define si está activo o no
        /// </summary>
        public Boolean  Activo { get; set; }

        /// <summary>
        /// Paginas del libro
        /// </summary>
        public virtual List<Models.Pagina> Paginas { get; set; }
    }
}