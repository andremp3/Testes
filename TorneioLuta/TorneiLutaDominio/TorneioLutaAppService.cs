using System.Collections.Generic; 

namespace TorneioLutaDominio
{
   public class TorneioLutaAppService : ITorneioLutaAppService
   {
      private readonly ITorneioLutaWebClient _webClient;

      public TorneioLutaAppService(ITorneioLutaWebClient webClient)
      {
         _webClient = webClient;
      }

      public IEnumerable<Lutador> BuscarListaLutadores()
      {
         
         return _webClient.BuscarListaLutadores();
      }

      public Campeonato ExecutarCampeonato(IList<Lutador> lutadoresSelecionados)
      {
         Campeonato campeonato = new Campeonato();
         campeonato.ExecutarCampeonato(lutadoresSelecionados);

         return campeonato;
      }
   }
}