using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorneioLutaDominio
{
   public class Campeonato
   {

      public Lutador Campeao { get; set; }
      public Lutador Segundo { get; set; }
      public Lutador Terceiro { get; set; }

      public IList<Lutador> Participantes { get; set; }

      public IList<Grupo> Grupos { get; set; }

      public IList<Partida> Quarta { get; set; }

      public IList<Partida> Semi { get; set; }

      public IList<Partida> Final { get; set; }

      public Campeonato()
      {
         Participantes = new List<Lutador>();
         Grupos = new List<Grupo>();
         Quarta = new List<Partida>();
         Semi = new List<Partida>();
         Final = new List<Partida>();
         GerarGrupos(4);
      }

      public void GerarGrupos(int NumeroGrupos)
      {
         for (int i = 0; i < NumeroGrupos; i++)
         {
            Grupos.Add(new Grupo { });
         }
      }

      public void CarregarGrupos()
      {

         Participantes = Participantes.OrderByDescending(x => x.Idade).ToList();

         int LutInicial = 0;
         int LutFinal = 4;
         for (int Grupo = 0; Grupo <= 3; Grupo++)
         {
       
            for (int Lut = LutInicial; Lut <= LutFinal; Lut++)
            {
               Grupos[Grupo].Participantes.Add(Participantes[Lut]);
            }
            LutInicial = LutFinal + 1;
            LutFinal = LutInicial + 4;
         }
      }

      public void Encerrar()
      {
         Campeao = Final[0].Vencedor;
         Segundo = Final[0].Perdedor;
         Terceiro = Final[1].Vencedor;
      }

      public void ExecutarCampeonato(IList<Lutador> lutadoresSelecionados)
      {
         Participantes = lutadoresSelecionados;

         CarregarGrupos();

         foreach (Grupo grupo in Grupos)
         {
            grupo.MontarPartidas();
            grupo.JogarPartidas();
            grupo.EncerrarGrupo();
         }

         //TO-DO Melhorar isso:
         Quarta.Add(new Partida { Lutador1 = Grupos[0].PrimeiroLugarGrupo, Lutador2 = Grupos[1].SegundoLugarGrupo });
         Quarta.Add(new Partida { Lutador1 = Grupos[0].SegundoLugarGrupo, Lutador2 = Grupos[1].PrimeiroLugarGrupo });
         Quarta.Add(new Partida { Lutador1 = Grupos[2].PrimeiroLugarGrupo, Lutador2 = Grupos[3].SegundoLugarGrupo });
         Quarta.Add(new Partida { Lutador1 = Grupos[2].SegundoLugarGrupo, Lutador2 = Grupos[3].PrimeiroLugarGrupo });

         foreach (Partida quarta in Quarta)
         {
            quarta.Lutar();
         }

         //TO-DO Melhorar isso:
         Semi.Add(new Partida { Lutador1 = Quarta[0].Vencedor, Lutador2 = Quarta[1].Vencedor });
         Semi.Add(new Partida { Lutador1 = Quarta[2].Vencedor, Lutador2 = Quarta[3].Vencedor });

         foreach (Partida semi in Semi)
         {
            semi.Lutar();
         }

         //TO-DO Melhorar isso:
         Final.Add(new Partida { Lutador1 = Semi[0].Vencedor, Lutador2 = Semi[1].Vencedor });
         Final.Add(new Partida { Lutador1 = Semi[0].Perdedor, Lutador2 = Semi[1].Perdedor });

         foreach (Partida final in Final)
         {
            final.Lutar();
         }

         Encerrar();
      }

   }
}