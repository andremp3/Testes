using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Text;
using TorneioLutaDominio;

namespace TorneioLutaWebClient
{
   public class TorneioLutaWebClient : ITorneioLutaWebClient
   {

      public IEnumerable<Lutador> BuscarListaLutadores()
      {
         string _sURL = ConfigurationManager.AppSettings["UrlServicoLutadores"];
         List<Lutador> lutadores;
         using (var webClient = new WebClient())
         {
            webClient.Encoding = Encoding.UTF8;
            try
            {
               string jsonLutadores = webClient.DownloadString(_sURL);
               lutadores = JsonConvert.DeserializeObject<List<Lutador>>(jsonLutadores);
            }
            catch (System.Exception ex)
            {
               throw ex;
            }
         }
         return lutadores;
      }

   }
}