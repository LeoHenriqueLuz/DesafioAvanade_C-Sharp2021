/*Você terá o desafio de escrever um algoritmo que leia 2 números e
 imprima o resultado da divisão do primeiro pelo segundo.
 Caso não for possível mostre a mensagem “divisao impossivel”
  para os valores em questão.*/

 class Desafio
{
    static void Main()
    {
        int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split();
                decimal x = decimal.Parse(line[0]);
                decimal y = decimal.Parse(line[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    decimal divisao = x / y; 
                    if (divisao < 0 && (divisao.ToString("N1") == "0.0"))
                    Console.WriteLine("-0.0");
                    else
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
    }
}