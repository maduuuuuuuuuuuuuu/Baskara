double a, b, c, delta, x1, x2;
Console.WriteLine("");
Console.WriteLine("Baskara");

Console.WriteLine("denomine o cociente a");
a = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("denomine o cociente b");
b = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("denomine o cociente c");
c = Convert.ToDouble(Console.ReadLine()!);

if (a == 0){
    Console.WriteLine("");
    Console.WriteLine("Não é uma equação de 2° grau");
}
else {
    delta = b * b - 4 * a * c;

    if (delta < 0){
    Console.WriteLine("");    
    Console.WriteLine($"como delta = {delta} a equação não possui raízes reais!");
}
    else{
    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine("");
Console.WriteLine($"O resultado de x1 = {x1}");
Console.WriteLine($"O resultado de x2 = {x2}");
Console.WriteLine("");
    }
}    

