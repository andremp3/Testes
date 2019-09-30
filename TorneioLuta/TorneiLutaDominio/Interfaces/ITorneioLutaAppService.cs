using System.Collections.Generic;

namespace TorneioLutaDominio
{
   public interface ITorneioLutaAppService
   {
      IEnumerable<Lutador> BuscarListaLutadores();

      Campeonato ExecutarCampeonato(IList<Lutador> lutadoresSelecionados);
   }
}