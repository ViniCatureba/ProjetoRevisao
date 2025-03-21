//Projeto ^^



//principal

int[] notas = new int[5];

for (int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.WriteLine($"Insira a {i + 1}º nota: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota < 0 || nota > 10)
        {
            throw new ArgumentOutOfRangeException("Nota invalida, insira uma nota entre 0 e 10");
        }
        notas[i] = nota;
    }
    catch (FormatException e) {
        Console.WriteLine("Insira um numero inteiro");
    }
}
Console.WriteLine("Suas notas foram: ");

int totalmedia = 0;
foreach (int i in notas)
{
    Console.Write(i +" ");
    totalmedia = totalmedia + i;
}
int media = totalmedia/notas.Length;
Console.WriteLine($"\nSua media é {media}");

if (media >= 7)
{
    Console.WriteLine("Você foi aprovado");
}
else
{
    Console.WriteLine("Voce nao foi aprovado");
}



bool loop = true;
while (loop == true)
{
    Console.WriteLine("== Gerenciador de notas ==\nEscolha uma das opções asseguir\n1. Adicionar Alunos\n2. Listar Alunos\n3. Estatísticas\n4. Sair");
    int escolha = int.Parse(Console.ReadLine());

    loop = false;
}