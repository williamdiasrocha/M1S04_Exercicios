using System.Buffers.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema 
{
    public class Suco : BebidaPai
    {
        public string TipoCaixa { get; set; }

        
        public Suco(string tipoCaixa, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base(id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            this.TipoCaixa = tipoCaixa;
            this.Id = id;
            this.Tipo = tipo;
            this.MiliLitro = miliLitro;
            this.NomeBebida = nomeBebida;
            this.ValorCompra = valorCompra;
            
        
        }

        public void ImprimirDados()
        {
            Console.WriteLine("O produto id {id} é um suco é do tipo {tipoCaixa} com quantidade de MiliLitros {miliLitros}");
        }
    }
}