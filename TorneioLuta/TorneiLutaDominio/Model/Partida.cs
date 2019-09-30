using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorneioLutaDominio
{
   public class Partida
   {

      public Lutador Lutador1 { get; set; }

      public Lutador Lutador2 { get; set; }

      public Lutador Vencedor { get; set; }

      public Lutador Perdedor { get; set; }

      public void Lutar()
      {

         if (Lutador1.PercentualVitorias > Lutador2.PercentualVitorias)
         {
            AtualizarPlacar(Lutador1, Lutador2);
         }
         else if (Lutador1.PercentualVitorias < Lutador2.PercentualVitorias)
         {
            AtualizarPlacar(Lutador2, Lutador1);
         }
         else if (Lutador1.PercentualVitorias == Lutador2.PercentualVitorias)
         {

            if (Lutador1.ArtesMarciais.Count() > Lutador2.ArtesMarciais.Count())
            {
               AtualizarPlacar(Lutador1, Lutador2);
            }
            else if (Lutador1.ArtesMarciais.Count() < Lutador2.ArtesMarciais.Count())
            {
               AtualizarPlacar(Lutador2, Lutador1);
            }
            else if (Lutador1.ArtesMarciais.Count() == Lutador2.ArtesMarciais.Count())
            {
               if (Lutador1.Lutas > Lutador2.Lutas)
               {
                  AtualizarPlacar(Lutador1, Lutador2);
               }
               else
               {
                  AtualizarPlacar(Lutador2, Lutador1);
               }
            }
         }

      }

      public void AtualizarPlacar(Lutador vencedor, Lutador perdedor)
      {

         Vencedor = vencedor;
         Perdedor = perdedor;
         vencedor.Vitorias++;
         perdedor.Derrotas++;
         vencedor.Lutas++;
         perdedor.Lutas++;
         vencedor.AtualizarPercentualVitorias();
         perdedor.AtualizarPercentualVitorias();
      }

   }

}