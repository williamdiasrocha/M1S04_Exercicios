using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema;

namespace sistema
{
    public class BebidaPai
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }

        public BebidaPai(int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra)
        {
            Id = id;
            Tipo = tipo;;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorCompra = valorCompra;
        }

      
        
        public void Comprar()
        {
            Console.WriteLine("$Valor da compra do produto id {id} alterado para {valorcompra}");
        }

        
    }
}