using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneioLutaDominio;

namespace TorneioLutaTestes
{
   [TestClass]

   public class TorneioLutaTestesPartida
   {
      [TestMethod]
      public void TestarLutaVitoriaLutador1()
      {

         // Construir Cenário
         Lutador lutador1 = new Lutador(1, "Balboa", 40, new List<string> { "Boxe"}, 150, 5, 145);
         Lutador lutador2 = new Lutador(2, "Creed", 45, new List<string> { "Boxe" }, 170, 10, 160);

         // Executar
         lutador1.AtualizarPercentualVitorias();
         lutador2.AtualizarPercentualVitorias();

         Partida partida = new Partida { Lutador1 = lutador1, Lutador2 = lutador2 };

         partida.Lutar();

         // Verificar
         Assert.AreEqual(partida.Vencedor, lutador1, "Lutador 1 Venceu");

      }

      [TestMethod]
      public void TestarCriterioDesempate()
      {

         // Construir Cenário
         Lutador lutador1 = new Lutador(1, "Balboa", 40, new List<string> { "Boxe" }, 150, 5, 145);
         Lutador lutador2 = new Lutador(2, "Creed", 45, new List<string> { "Boxe", "DaRua" }, 150, 5, 145);

         // Executar
         lutador1.AtualizarPercentualVitorias();
         lutador2.AtualizarPercentualVitorias();

         Partida partida = new Partida { Lutador1 = lutador1, Lutador2 = lutador2 };

         partida.Lutar();

         // Verificar
         Assert.AreEqual(partida.Vencedor, lutador2, "Lutador 2 Venceu");

      }
   }
}
