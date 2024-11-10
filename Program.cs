class Program
{

    static void Menu()
    {
        Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝
        ");

        Console.WriteLine(@"
Digite + para soma
Digite - para subtração
Digite * para multiplicação
Digite / para divisão
Digite . para sair
        ");

    }


    static (double num1, double num2) Numeros()
    {
        Console.Write("Digite um número: ");
        double num1 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite outro número: ");
        double num2 = double.Parse(Console.ReadLine()!);

        return (num1, num2);

    }


    static double Somar(double num1, double num2)
    {
        return num1 + num2;
    }
    

    static double Subtrair(double num1, double num2) 
    {
        return num1 - num2;
    }


    static double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }


    static double Dividir(double num1, double num2)
    {
        return num1 / num2;
    }


    static void VoltarAoMenu()
    {
        Console.Write("Digite qualquer tecla para voltar ao menu: ");
        Console.ReadLine();
        Console.Clear();
    }


    static void Main() 
    {


        while (true)
        {
            Console.Clear();
            Menu();
            Console.Write("Digite sua opção: ");
            string opcao = Console.ReadLine()!;

            if (opcao == ".")
            {
                Console.WriteLine("Saindo...");
                Environment.Exit(0);
            }


            Console.Clear();

            

            switch (opcao) 
            {
                case "+": 
                    Console.WriteLine("Você escolheu SOMA: ");
                    var numerosSoma = Numeros();
                    double soma = Somar(numerosSoma.num1, numerosSoma.num2);
                    Console.WriteLine($"{numerosSoma.num1} + {numerosSoma.num2} = {soma}");
                    
                    break;

                case "-":
                    Console.WriteLine("Você escolheu SUBTRAÇÃO: ");
                    var numerosSub = Numeros();
                    double subtracao = Subtrair(numerosSub.num1, numerosSub.num2);
                    Console.WriteLine($"{numerosSub.num1} - {numerosSub.num2} = {subtracao}");

                    break;

                case "*":
                    Console.WriteLine("Você escolheu MULTIPLICAÇÃO: ");
                    var numerosMulti = Numeros();
                    double multiplicacao = Multiplicar(numerosMulti.num1, numerosMulti.num2);
                    Console.WriteLine($"{numerosMulti.num1} * {numerosMulti.num2} = {multiplicacao}");

                    break;
                
                case "/":
                    Console.WriteLine("Você escolheu DIVISÃO: ");
                    var numerosDiv = Numeros();
                    if (numerosDiv.num2 == 0) 
                    {
                        Console.WriteLine("Impossivel dividir por 0!");
                    }
                    else
                    {
                        double divisao = Dividir(numerosDiv.num1, numerosDiv.num2);
                        Console.WriteLine($"{numerosDiv.num1} / {numerosDiv.num2} = {divisao:F2}");
                    }

                    break;
                    
                default:
                    Console.WriteLine("Opção invalida!");
                    break;

            }

            VoltarAoMenu();

        }

    }   

}