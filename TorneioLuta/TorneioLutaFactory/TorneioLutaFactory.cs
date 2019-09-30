using TorneioLutaDominio;
using TorneioLutaWebClient;

namespace TorneioLutaFactory
{
   public static class TorneioLutaFactory
    {
      public static ITorneioLutaWebClient GetTorneioLutaWebClient()
      {
         return new TorneioLutaWebClient.TorneioLutaWebClient();
      }

      public static ITorneioLutaAppService GetTorneioLutaAppService()
      {
         return new TorneioLutaAppService(GetTorneioLutaWebClient());
      }
    }
}