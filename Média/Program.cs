decimal n1, n2, media;

Console.WriteLine("Dgite a primeira nota ");
n1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Dgite a segunda nota ");
n2 = decimal.Parse(Console.ReadLine());

media = (n1 + n2) / 2;

if (media > 0)
{
    if (media <= 3)
    {
        Console.WriteLine("Reprovado");
    }
    else if (media > 3 && media <=5 )
    {
        Console.WriteLine("Aluno de exame");
    } else
    {
        Console.WriteLine("Aprovado");
    }
}