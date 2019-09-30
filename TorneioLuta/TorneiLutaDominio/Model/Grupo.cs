using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorneioLutaDominio
{
   public class Grupo
   {

      public IList<Lutador> Participantes { get; set; }
      public IList<Partida> Partidas { get; set; }

      public Lutador PrimeiroLugarGrupo { get; set; }
      public Lutador SegundoLugarGrupo { get; set; }


      public Grupo()
      {
         Participantes = new List<Lutador>();
         Partidas = new List<Partida>();
      }

      public void MontarPartidas()
      {

         //TO-DO: Fazer isso com o loop
         Partidas.Add(new Partida { Lutador1 = Participantes[0], Lutador2 = Participantes[1] });
         Partidas.Add(new Partida { Lutador1 = Participantes[0], Lutador2 = Participantes[2] });
         Partidas.Add(new Partida { Lutador1 = Participantes[0], Lutador2 = Participantes[3] });
         Partidas.Add(new Partida { Lutador1 = Participantes[0], Lutador2 = Participantes[4] });
         Partidas.Add(new Partida { Lutador1 = Participantes[1], Lutador2 = Participantes[2] });
         Partidas.Add(new Partida { Lutador1 = Participantes[1], Lutador2 = Participantes[3] });
         Partidas.Add(new Partida { Lutador1 = Participantes[1], Lutador2 = Participantes[4] });
         Partidas.Add(new Partida { Lutador1 = Participantes[2], Lutador2 = Participantes[3] });
         Partidas.Add(new Partida { Lutador1 = Participantes[2], Lutador2 = Participantes[4] });
         Partidas.Add(new Partida { Lutador1 = Participantes[3], Lutador2 = Participantes[4] });

      }

      public void JogarPartidas()
      {
         foreach (Partida partida in Partidas)
         {
            partida.Lutar();

         }
      }

      public void EncerrarGrupo()
      {
         var Resultados =
             from partida in Partidas
             group partida by partida.Vencedor into g
             select new { Vencedor = g.Key, Vitorias = g.Count() };

         Resultados = Resultados.OrderByDescending(P => P.Vitorias);

         PrimeiroLugarGrupo = Resultados.ToList()[0].Vencedor;
         SegundoLugarGrupo = Resultados.ToList()[1].Vencedor;



      }
   }
}