using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elasticsearch;
using Elasticsearch.Net;
using Nest;
using ESmvc.Models;
using System.IO;

namespace ESmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var modelo = new List<Models.Libro>();

            //Define de donde se obtendrá la instacia de ElasticSearch
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"));
            settings.DefaultIndex("id");
            var client = new ElasticClient(settings);

            //Definición del libro
            var libro = new Libro()
            {
                Titulo = Path.GetRandomFileName() +" "+ new Random().Next(1, 89),
                Id = new Random().Next(1, 89).ToString(),
                Activo = true,
                FechaAlta = DateTime.Now
            };

            //Definición de las páginas
            for (Int32 pagina = 1; pagina <= 10; pagina++)
            {
                var paginaDetalle = new Models.Pagina()
                {
                    NumPagina = pagina,
                    Texto = Path.GetRandomFileName()
                };
                libro.Paginas.Add(paginaDetalle);
            }

            var indexar = client.Index<Libro>(libro);
            //String busqueda = "kyloefu5";

            //Int32 paginado = 1000;
            //    var result = client.Search<Libro>(s => s
            //    .From(0)
            //    .Size(paginado)
            //    .Query(q =>
            //    //Busqueda con Like
            //    q.QueryString(qs => qs.Query("*" + busqueda + "*"))
            //    //Palabra exacta
            //    //q.Term(p => p.Firstname, busqueda) 
            //    )
            //  .Sort(ss => ss
            //  .Field(f => f
            //.Field(p => p.Id)
            //.Order(SortOrder.Descending)
            //.UnmappedType(FieldType.Integer))));
            var result = client.Search<Libro>();
            modelo = result.Documents.ToList();

            return View(modelo);
        }
    }
}