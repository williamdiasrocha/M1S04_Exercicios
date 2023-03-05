
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema
{
    public class Refrigerante : BebidaPai
    {
        public bool Vidro { get; set; }
        


        public Refrigerante(bool vidro, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base(id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            Vidro = vidro;
            Tipo = "Refrigerante";
            ValorCompra = valorCompra;
        }

        public void ImprimirDados()
        {
            if(Vidro == true)
            {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitro} é um vidro");
            }
            else if(Vidro == false)
            {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitro} é uma garrafa pet.");
            }

        
        }
    }
}