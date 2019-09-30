using System.Collections.Generic;

namespace TorneioLutaDominio
{
   public interface ITorneioLutaWebClient
   {
      IEnumerable<Lutador> BuscarListaLutadores();

   }
}