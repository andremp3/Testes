using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneioLutaDominio;

namespace TorneioLutaTestes
{
   [TestClass]

   public class TorneioLutaTestesGrupo
   {
      [TestMethod]
      public void TestarGrupos()
      {

         // Construir Cenário
         Grupo grupo = new Grupo();

         Lutador lutador1 = new Lutador(1, "Jacaré", 39, new List<string> { "Jiu-jítsu" }, 32, 6, 26);
         Lutador lutador2 = new Lutador(2, "Chael", 41, new List<string> { "Greco-romana" }, 47, 16, 30);
         Lutador lutador3 = new Lutador(3, "Tyson", 52, new List<string> { "Boxe" }, 58, 6, 50);
         Lutador lutador4 = new Lutador(4, "Cigano", 35, new List<string> { "Boxe", "Jiu-Jitsu" }, 25, 5, 20);
         Lutador lutador5 = new Lutador(5, "Hughes", 45, new List<string> { "Artes marciais mistas" }, 54, 9, 45);

         grupo.Participantes.Add(lutador1);
         grupo.Participantes.Add(lutador2);
         grupo.Participantes.Add(lutador3);
         grupo.Participantes.Add(lutador4);
         grupo.Participantes.Add(lutador5);

         //Executar
         grupo.MontarPartidas();
         grupo.JogarPartidas();
         grupo.EncerrarGrupo();

         // Verificar
         Assert.AreEqual(lutador3.Nome, grupo.PrimeiroLugarGrupo.Nome, "Lutador " + grupo.PrimeiroLugarGrupo.Nome + " Venceu");

      }

   }
}
