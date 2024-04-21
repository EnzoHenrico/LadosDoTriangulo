float side1 = 0, side2 = 0, side3 = 0;

Console.WriteLine("Qual o tipo do triângulo?\n");

do
{
    Console.Write("Digite a medida do primeiro, lado do triângulo: ");
    side1 = float.Parse(Console.ReadLine());

    if (side1 <= 0)
    {
        Console.WriteLine("\nO lado do triângulo deve ser maior que 0, tente novamente.\n");
    }
}
while (side1 <= 0);

do
{
    Console.Write("Digite a medida do segundo lado do triângulo: ");
    side2 = float.Parse(Console.ReadLine());

    if (side2 <= 0)
    {
        Console.WriteLine("\nO lado do triângulo deve ser maior que 0, tente novamente.\n");
    }
}
while (side2 <= 0);

do
{
    Console.Write("Digite a medida do terceiro lado do triângulo: ");
    side3 = float.Parse(Console.ReadLine());

    if (side3 <= 0)
    {
        Console.WriteLine("\nO lado do triângulo deve ser maior que 0, tente novamente.\n");
    }
}
while (side3 <= 0);

if (side1 + side2 < side3)
{
    Console.WriteLine("\nA soma da medidas de dois lados é menor do que o terceiro, portanto o triângulo é inválido.");
}
else if (side1 == side2 && side2 == side3)
{
    Console.WriteLine("\nO triângulo é Equilátero.");
}
else if (
    (side1 == side2 && side1 != side3) ||
    (side2 == side3 && side2 != side1) ||
    (side3 == side1 && side3 != side2))
{
    Console.WriteLine("\nO triângulo é Isóceles.");
}
else
{
    // Três lados diferentes
    Console.WriteLine("\nO triângulo é Escaleno.");
}

// Interação final
Console.ReadKey();