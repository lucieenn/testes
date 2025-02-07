// Teste se é um triangulo retângulo ou não

/*Console.WriteLine("Calculo do triangulo retangulo. Digite um valor numérico:");
decimal val1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
decimal val2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor:");
decimal val3 = Convert.ToDecimal(Console.ReadLine());

if (Triangulo.InstanciaPublica().EhTrianguloRetangulo(val1, val2, val3))
    Console.WriteLine("Triangulo eh retangulo");
else Console.WriteLine("Triangulo NÃO eh retangulo");
*/

// Teste sobre área de triângulo retângulo

Console.WriteLine("Área de um triângulo retângulo. Digite CAT1:");
decimal cateto1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite CAT2:");
decimal cateto2 = Convert.ToDecimal(Console.ReadLine());

decimal areaTri = Triangulo.InstanciaPublica().AreaTriRetangulo(cateto1, cateto2);

Console.WriteLine("A área do triangulo retângulo é:" + areaTri);
Console.ReadLine();

public class Triangulo
{
    public static Triangulo instanciaInterna;

    public static Triangulo InstanciaPublica()
    {
        if (instanciaInterna == null)
            instanciaInterna = new Triangulo();

        return instanciaInterna;                
    }

    public bool EhTrianguloRetangulo(decimal valor1, decimal valor2, decimal valor3)
    {
        decimal valorMaior, valorMenor_A, valorMenor_B;

        // Se um dos lados for igual a zero, não é triângulo
        if ((valor1 == 0) || (valor2 == 0) || (valor3 == 0))
            return false;

        // Determinar qual valor é o maior
        if (valor1 > valor2 && valor1 > valor3)
        {
            valorMaior = valor1;
            valorMenor_A = valor2;
            valorMenor_B = valor3;
        }
        else if (valor2 > valor1 && valor2 > valor3)
        {
            valorMaior = valor2;
            valorMenor_A = valor1;
            valorMenor_B = valor3;
        }
        else
        {
            valorMaior = valor3;
            valorMenor_A = valor1;
            valorMenor_B = valor2;
        }

        // Calculo do triangulo retangulo: hipotenusa^2 == catA^2 + catB^2;

        if ((valorMaior * valorMaior) == (valorMenor_A * valorMenor_A) + (valorMenor_B * valorMenor_B))
            return true;
        else return false;
    }

    public decimal AreaTriRetangulo(decimal cat1, decimal cat2)
    {
        decimal area;
        area = (cat1 * cat2) / 2;

        return area;
    }
}