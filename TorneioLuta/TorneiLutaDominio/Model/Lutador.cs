using System;
using System.Collections.Generic;

namespace TorneioLutaDominio
{
   public class Lutador
   {
      public int Id { get; set; }
      public string Nome { get; set; }
      public int Idade { get; set; }
      public IList<string> ArtesMarciais { get; set; }
      public int Lutas { get; set; }
      public int Derrotas { get; set; }
      public int Vitorias { get; set; }

      public int PercentualVitorias { get; set; }

      public void AtualizarPercentualVitorias()
      {
         if (Lutas == 0 || Vitorias == 0)
         {
            PercentualVitorias = 0;
         }
         else
         {
            double _Vitorias = Vitorias;
            double _Lutas = Lutas;
            PercentualVitorias = Convert.ToInt32((_Vitorias / _Lutas) * 100);
         }

      }

      public Lutador(int Id, string Nome, int Idade, IList<string> ArtesMarciais, int Lutas, int Derrotas, int Vitorias)
      {
         this.Id = Id;
         this.Nome = Nome;
         this.Idade = Idade;
         this.ArtesMarciais = ArtesMarciais;
         this.Lutas = Lutas;
         this.Derrotas = Derrotas;
         this.Vitorias = Vitorias;
         AtualizarPercentualVitorias();
      }

   }

}