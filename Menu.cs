using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema;


namespace sistema
{
    public static class Menu
    {
        public static void DisplayInicial()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao SISTEMA DE BEBIDAS:");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o número da opção desejada:");
            Console.WriteLine("1 - Inserir bebida.");
            Console.WriteLine("2 - Alterar bebida.");
            Console.WriteLine("3 - Excluir bebida.");
            Console.WriteLine("4 - Listar todas as bebidas.");
            Console.WriteLine("5 - Listar todos os sucos.");
            Console.WriteLine("6 - Listar todos os refrigerantes.");
            Console.WriteLine("7 - Sair.");

            int selecaoDoUsuario = int.Parse(Console.ReadLine());

            try
            {
                if (selecaoDoUsuario ==1)//inserir bebida
                {

                    Submenu.SubDisplay();
                }
                else if (selecaoDoUsuario == 2)//alterar bebida
                {
                    Console.WriteLine("Alterar bebida:");
                    BebidaPai bebida = new BebidaPai(0,"",0,"",0);
                    Repositorio.AlterarBebida(bebida);
                }
                else if (selecaoDoUsuario == 3)//excluir bebida
                {
                    Console.WriteLine("Excluir bebida.");
                    BebidaPai bebida = new BebidaPai(0, "", 0, "", 0);
                    Repositorio.ExcluirBebida(bebida);
                    
                }
                else if (selecaoDoUsuario == 4)//listar bebidas
                {
                    BebidaPai bebida = new BebidaPai(0, "", 0, "", 0);
                    Console.WriteLine("Todas as bebidas registradas:");
                    Console.WriteLine("");
                    Repositorio.ListarBebidas(bebida);
                }
                else if (selecaoDoUsuario == 5)//listar sucos
                {
                    Suco suco = new Suco("", 0, "", 0, "", 0);
                    Console.WriteLine("Todas os sucos registrados:");
                    Repositorio.ListarSucos(suco);
                }
                else if (selecaoDoUsuario == 6)//listar refris
                {
                    Refrigerante refrigerante = new Refrigerante(true, 0, "", 0, "", 0);
                    Console.WriteLine("Todas os refrigerantes registrados:");
                    Repositorio.ListarRefrigerantes(refrigerante);
                }
                else if (selecaoDoUsuario == 7)//sair
                {
                    Console.WriteLine("Programa finalizado.");
                    return;
                }
                else {
                    Console.WriteLine("Opção inválida.");
                    Menu.DisplayInicial();
                }
                return;
            }
            catch
            {
                Console.WriteLine("Erro inesperado;");
            }

        }
    }
    public static class Submenu
    {
        public static void SubDisplay()
        {

            Console.WriteLine("   Digite o numero de sua seleção:");
            Console.WriteLine("      1 - Adicionar suco.");
            Console.WriteLine("      2 - Adicionar refrigerante.");
            Console.WriteLine("      3 - Adicionar outra bebida.");
            Console.WriteLine("      4 - Retornar ao menu principal.");
            int selecaoDoUsuario;
            selecaoDoUsuario = int.Parse(Console.ReadLine());
            try
            {
                if (selecaoDoUsuario == 1)
                {
                    Suco suco = new Suco("", 0, "", 0, "", 0);
                    Repositorio.AdicionarSuco(suco);
                    Console.WriteLine("     Tecle ENTER para retornar ao menu principal.");
                    Console.ReadLine();
                    Menu.DisplayInicial();
                }
                else if (selecaoDoUsuario == 2)
                {
                    Refrigerante refrigerante = new Refrigerante(true, 0, "", 0, "", 0);
                    Repositorio.AdicionarRefrigerante(refrigerante);
                    Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
                    Console.ReadLine();
                    Menu.DisplayInicial();
                }
                else if (selecaoDoUsuario == 3)
                {
                    BebidaPai bebida = new BebidaPai(0, "", 0, "", 0);
                    Repositorio.AdicionarBebida(bebida);
                    Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
                    Console.ReadLine();
                    Menu.DisplayInicial();
                }
                else
                {
                    Console.WriteLine("Opção inválida, retornando ao menu principal.");
                    Console.WriteLine("");
                    Menu.DisplayInicial();
                }
            }
            catch { Console.WriteLine("Opção digitada invalida, encerrando programa com código de erro 1."); }
        }
    }
}
