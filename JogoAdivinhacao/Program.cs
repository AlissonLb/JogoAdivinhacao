string[] perguntas =
{
    "O que é que tem capa mas não é super-herói, tem folha mas não é árvore, tem orelha mas não é gente?",
    "O que é, o que é? Tem asas, mas não voa, tem penas, mas não é um pássaro. ",
    "O que tem capa mas não é herói, tem folha mas não é árvore? "
};

string[] respostas =
{
    "Livro",
    "Pena",
    "Caderno"
};

string jogar = "s";
string resposta = "";
int index = 0;
while (jogar == "s")
{
    Random rand = new Random();
    index = rand.Next(0, perguntas.Length);
    Console.WriteLine($"Pergunta: {perguntas[index]}");
    Console.WriteLine("Resposta: ");
    resposta = Console.ReadLine();
    if (resposta.ToUpper() != respostas[index].ToUpper())
    {
        Console.WriteLine("Que pena você errou");
    }
    else
    {
        Console.WriteLine("Parabéns voce acertou !!!!");
    }
    Console.WriteLine("Deseja jogar Novamente S/N");
    jogar = Console.ReadLine();

}