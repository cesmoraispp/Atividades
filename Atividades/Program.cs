// Exercicio 1
class program
{
    static void Main()
    {
        int A = 10;
        int B = 20;

        A = B;
        B = A;

        Console.WriteLine("O valor de A é:" + A);
        Console.WriteLine("O valor de B é:" + B);


        //Exercicio 2
        int totalEleitores, votosBrancos, votosNulos, votosValidos;

        Console.Write("Informe o número total de eleitores: ");
        totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos brancos: ");
        votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos nulos: ");
        votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos válidos: ");
        votosValidos = int.Parse(Console.ReadLine());

        double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
        double percentualNulos = (double)votosNulos / totalEleitores * 100;
        double percentualValidos = (double)votosValidos / totalEleitores * 100;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Percentual de votos brancos: {percentualBrancos}%");
        Console.WriteLine($"Percentual de votos nulos: {percentualNulos}%");
        Console.WriteLine($"Percentual de votos válidos: {percentualValidos}%");

        //Exercicio 3
        Console.WriteLine("Digite um valor:");
        int valor = int.Parse(Console.ReadLine());

        if (valor >= 0)
        {
            Console.WriteLine("Positivo");
        }
        else
        {
            Console.WriteLine("Negativo");
        }

        //Exercicio 4
        Console.WriteLine("Sálario fixo do vendedor");
        double salarioFixo = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor ttoal das vendas");
        double valorTotal = double.Parse(Console.ReadLine());

        double comissao;
        if (valorTotal <= 1500)
        {
            comissao = valorTotal * 0.03;
        }
        else
        {
            comissao = 1500 * 0.03 + valorTotal - 1500 * 0.05;
        }

        //Exercicio 5
        Console.Write("primeiro time: ");
        string time1 = Console.ReadLine();

        Console.Write("número de gols marcados pelo primeiro time: ");
        int golsTime1 = int.Parse(Console.ReadLine());

        Console.Write("nome do segundo time: ");
        string time2 = Console.ReadLine();

        Console.Write("número de gols marcados pelo segundo time: ");
        int golsTime2 = int.Parse(Console.ReadLine());

        string vencedor;
        if (golsTime1 > golsTime2)
        {
            vencedor = time1;
        }
        else if (golsTime2 > golsTime1)
        {
            vencedor = time2;
        }
        else
        {
            vencedor = "EMPATE";
        }

        Console.WriteLine($"O vencedor da partida é: {vencedor}");

        //Exercicio 6
        Console.WriteLine("Primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine());

        double valor2;
        do
        {
            Console.WriteLine("Segundo valor:");
            valor2 = double.Parse(Console.ReadLine());
        } while (valor2 == 0);

        double resultado = valor1 / valor2;
        Console.WriteLine("Resultado da divisão é:" + resultado);

        //Exercicio 7
        Console.WriteLine("Tabuada do 8:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = 8 * i;
            Console.WriteLine($"8 x {i} = {resultado}");
        }

        //Exercicio 8
        int quantidadeValores = 10;
        double soma = 10;


        for (int i = 1; i <= quantidadeValores; i++)
        {
            Console.Write("Informe o {i}º valor: ");
            double valor = double.Parse(Console.ReadLine());
            soma += valor;
        }
        double media = soma / quantidadeValores;
        Console.WriteLine("A média aritmética dos valores é: {media:F2}");

    }
}















