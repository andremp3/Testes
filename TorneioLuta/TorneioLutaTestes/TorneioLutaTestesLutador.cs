using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneioLutaDominio;

namespace TorneioLutaTestes
{
   [TestClass]
   public class TorneioLutaTestesLutador
   {
      [TestMethod]
      public void TestarPercentualVitorias()
      {

         // Construir Cenário
         int PercentualEsperado = 96;
         Lutador lutador = new Lutador(1, "Balboa", 40, new List<string> { "1", "2" }, 50, 2, 48);

         // Executar
         lutador.AtualizarPercentualVitorias();

         // Verificar
         int PercentualAtual = lutador.PercentualVitorias;
         Assert.AreEqual(PercentualEsperado, PercentualAtual, "Percentual de Vitórias calculou corretamente.");

      }
   }
}
