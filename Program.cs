using System.Xml.Xsl;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System.ComponentModel.Design;
using sistema;




Menu.DisplayInicial();

/* while(manterMenuAberto)
{
    // removido Menu.DisplayInicial();
    string opcao = Console.ReadLine().Trim();

    switch (opcao)
    {
        case "1":
            Menu.InserirBebida();
            break;
        case "2":
            BebidaPai bebida = new BebidaPai(0, "", 0, "", 0);
            Repositorio.AlterarBebida();
                         
            /* Refrigerante novoRefri = new Refrigerante(false, 3, "não", "", 350, "DollyGuaraná", 3.50M);
            Repositorio.AlterarBebida(novoRefri);
            Suco novoSuco = new Suco("Caixa", 2, "Suco", "", 350, "QuiSuco", 3.50M);
            Repositorio.AlterarBebida(novoSuco);
            BebidaPai novaBebida = new BebidaPai( 1, "Coca-Cola", "", 350, "Coca-Cola", 3.50M);
            Repositorio.AlterarBebida(novaBebida); */
        //     break;
        // case "3":
        //     Console.WriteLine("Digite o ID da bebida a ser excluída:");
        //     int id = int.Parse(Console.ReadLine());
        //     Repositorio.ExcluirBebida(id);
        //     break;
        // case "4":
        //     Repositorio.ListarBebidas();
        //     break;
        // case "5":
        //     Repositorio.ListarSucos();
        //     break;
        // case "6":
        //     Repositorio.ListarRefrigerantes();
        //     break;
        // case "7":
        //     Console.WriteLine("Encerrando programa...");
        //     manterMenuAberto = false;
        //     break;
        // default:
        //     //Erro no sistema, espero por 5 milissegundos
        //     Console.WriteLine("Dados com erros, aguarde 5 milissegundos para a tela carregar display inicial");
        //     Thread.Sleep(5000);
        //     Menu.DisplayInicial();
        //     break;


        
        /*Suco suco = new Suco("", 0, "", 0, "", 0);
            Repositorio.AdicionarSuco(suco);
            suco.ImprimirDados();
            Console.WriteLine("");
            Refrigerante refrigerante = new Refrigerante(true, 0, "", 0, "", 0);
            Repositorio.AdicionarRefrigerante(refrigerante);
            refrigerante.ImprimirDados();
            Console.WriteLine(""); 
            Bebida bebida = new Bebida(0, "", 0, "", 0);
            Repositorio.AdicionarBebida(bebida);
            bebida.ImprimirDados();
            Console.WriteLine("");
            Repositorio.AlterarBebida(bebida);
            bebida.Comprar();
            bebida.ImprimirDados();
            Repositorio.ExcluirPorId(bebida);*/