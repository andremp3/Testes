using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TorneioLutaDominio;

namespace TorneioLuta.Controllers
{
   public class TorneioController : Controller
    {
      private readonly ITorneioLutaAppService _appService;

      public TorneioController()
      {
         _appService = TorneioLutaFactory.TorneioLutaFactory.GetTorneioLutaAppService();
      }

      // GET: Torneio
      public ActionResult Index()
      {
         try
         {
            List<Lutador> lutadores = _appService.BuscarListaLutadores().ToList();
            Session["Lutadores"] = lutadores;
            return View(lutadores);
         }
         catch (System.Exception ex)
         {
            throw ex;
         }

      }

      // POST: Iniciar Torneio
      [HttpPost]
      public ActionResult IniciarTorneio()
      {
         List<Lutador> participantes = new List<Lutador>();

         string[] IDSelecionados = Request["LutadoresSelecionados"].Split(new char[] { ',' } );

         foreach (Lutador lutador in (Session["Lutadores"] as List<Lutador>))
         {
            if (IDSelecionados.Contains(lutador.Id.ToString()))
            {
               participantes.Add(lutador);
            }
         }

         Campeonato campeonato = _appService.ExecutarCampeonato(participantes);

         return View("ResultadoTorneio", campeonato);
      }

      protected override void OnException(ExceptionContext filterContext)
      {
         filterContext.ExceptionHandled = true;

         filterContext.Result = new ViewResult
         {
            ViewName = "~/Views/Shared/Error.cshtml"
         };
      }

   }
}