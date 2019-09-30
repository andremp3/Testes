using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneioLutaDominio;

namespace TorneioLutaTestes
{
   [TestClass]

   public class TorneioLutaTestesCampeonato
   {
      [TestMethod]
      public void TestarCampeonato()
      {

         // Construir Cenário
         Campeonato campeonato = new Campeonato();

         List<Lutador> lutadores = new List<Lutador>();

         lutadores.Add(new Lutador(24, "Jacaré", 39, new List<string> { "Jiu-jítsu" }, 32, 6, 26));
         lutadores.Add(new Lutador(23, "Chael", 41, new List<string> { "Greco-romana" }, 47, 16, 30));
         lutadores.Add(new Lutador(18, "Tyson", 52, new List<string> { "Boxe" }, 58, 6, 50));
         lutadores.Add(new Lutador(2, "Apollo", 43, new List<string> { "Boxe" }, 47, 1, 46));
         lutadores.Add(new Lutador(25, "Cigano", 35, new List<string> { "Boxe", "Jiu-Jitsu" }, 25, 5, 20));
         lutadores.Add(new Lutador(21, "Hughes", 45, new List<string> { "Artes marciais mistas" }, 54, 9, 45));
         lutadores.Add(new Lutador(15, "Acelino", 43, new List<string> { "Boxe" }, 43, 2, 41));
         lutadores.Add(new Lutador(14, "Micky", 53, new List<string> { "Boxe" }, 51, 13, 38));
         lutadores.Add(new Lutador(13, "Joe", 66, new List<string> { "Boxe" }, 69, 3, 66));
         lutadores.Add(new Lutador(12, "Roberto", 67, new List<string> { "Boxe" }, 119, 16, 103));
         lutadores.Add(new Lutador(11, "Julio", 56, new List<string> { "Boxe" }, 115, 6, 107));
         lutadores.Add(new Lutador(5, "Henry", 32, new List<string> { "Olímpica estilo livre" }, 16, 2, 14));
         lutadores.Add(new Lutador(4, "Tyron", 36, new List<string> { "Wrestling", "KickBoxing", "Boxe" }, 23, 3, 19));
         lutadores.Add(new Lutador(3, "Rocky", 42, new List<string> { "Boxe" }, 81, 23, 57));
         lutadores.Add(new Lutador(1, "Adonis", 32, new List<string> { "Boxe" }, 26, 1, 25));
         lutadores.Add(new Lutador(37, "Muhammad", 74, new List<string> { "Boxe" }, 61, 5, 56));
         lutadores.Add(new Lutador(36, "Liddell", 49, new List<string> { "Wrestling", "Kempo", "Kickboxing" }, 30, 9, 21));
         lutadores.Add(new Lutador(35, "Robinson", 67, new List<string> { "Boxe" }, 200, 19, 173));
         lutadores.Add(new Lutador(34, "Anderson", 43, new List<string> { "Boxe", "Muay Thai", "Jiu-Jitsu","Taekwondo","Capoeira" }, 44, 9, 34));
         lutadores.Add(new Lutador(33, "Foreman", 70, new List<string> { "Boxe" }, 81, 5, 76));

         //Executar
         campeonato.ExecutarCampeonato(lutadores);

         // Verificar
         Assert.AreEqual(campeonato.Campeao.Nome, "Apollo", "Lutador " + campeonato.Campeao.Nome + " Venceu");

      }

   }
}
