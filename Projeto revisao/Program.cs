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










//avancado

bool loop = true;
string[] alunos = new string[10];
int[] notasAlunos = new int[50];
int controladorIndexAlunos = 0;
int controladorIndexNotas = 0;
int mediaaluno = 0;



while (loop == true)
{
    Console.WriteLine("== Gerenciador de notas ==\nEscolha uma das opções asseguir\n1. Adicionar Alunos\n2. Listar Alunos\n3. Estatísticas\n4. Sair");
    int escolha = int.Parse(Console.ReadLine());


    //Insirar um aluno e 5 notas
    if (escolha == 1)
    {
        Console.WriteLine("Insira o nome do aluno");
        string inputAluno = Console.ReadLine();
        alunos[controladorIndexAlunos] = inputAluno;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Insira a {i + 1}ª nota (5 notas no total): ");
            notasAlunos[controladorIndexNotas] = int.Parse(Console.ReadLine());
            controladorIndexNotas++;
        }

        controladorIndexAlunos++;
    }
    //Listar aluno e escolher alunos e mostrar suas notas
    else if (escolha == 2)
        
    {

        Console.WriteLine("Escolha o aluno cujo deseja mostrar as notas: ");

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine(i + "." + alunos[i]);
        }
        Console.WriteLine("Digite o numero do aluno: ");
        int numeroIndexEscolhaAluno = int.Parse(Console.ReadLine());

        Console.WriteLine($"As notas de {alunos[numeroIndexEscolhaAluno]} sao:");

        for (int i = 0; i < 5; i++)
        {
            if (numeroIndexEscolhaAluno != 0)
            {
                Console.Write((i * numeroIndexEscolhaAluno));

            }
            else
            {
                Console.Write(i);
            }
        }
    }

    //Estatisticas
    else if (escolha == 3)
    {


    }
    else if (escolha >= 4)
    {
        loop = false;
    }
   


}