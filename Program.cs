Console.WriteLine("\t\tBem-Vindo ao Jogo da Sorte!\n");
Console.WriteLine("Desenvolvido por: Pedro Luca Galvão Couto");
Console.WriteLine("2024");
Console.WriteLine("Regras:");
Console.WriteLine("1 - O jogo sorteará 3 vezes um número aleatório de 1 a 6");
Console.WriteLine("2 - Caso a soma dos dados seja igual ou maior que 15 você vence");
Console.WriteLine("3 - Caso 2 dados sorteiem o mesmo resultado você ganhará um bônus de 2 pontos");
Console.WriteLine("4 - Caso 3 dados sorteiem o mesmo valor você ganhará 3 pontos de bônus\n");
Console.WriteLine("\t\tVai Encarar o Desafio?\n");
Console.WriteLine("Digite S para entrar no jogo ou qualquer outra tecla para sair");

bool x = true;

string play = Console.ReadLine();

if ((play == "s") || (play == "S"))
{
    do
    {
        Random dado = new();

        int rolagem1 = dado.Next(1, 7);
        int rolagem2 = dado.Next(1, 7);
        int rolagem3 = dado.Next(1, 7);

        int total = rolagem1 + rolagem2 + rolagem3;

        if ((rolagem1 == rolagem2) || (rolagem2 == rolagem3) || (rolagem1 == rolagem3))
        {
            if ((rolagem1 == rolagem2) && (rolagem2 == rolagem3))
            {
                Console.WriteLine("\nVocê conseguiu um triplo! Bônus de +6 pontos!\n");
                total += 6;
            }

            else
            {
                Console.WriteLine("\nVocê conseguiu um double! Bônus de +2 pontos!\n");
                total += 2;
            }
        }

        if (total >= 15)
        {
            Console.WriteLine("\n\t\tVocê Venceu!");
        }

        else
        {
            Console.WriteLine("\n\t\tVocê Perdeu!");
        }

        Console.WriteLine($"\nResultado da rolagem: {rolagem1} + {rolagem2} + {rolagem3} = {total}\n");

        Console.WriteLine("Deseja jogar outra vez?");
        Console.WriteLine("Digite s para jogar novamente e qualquer outra tecla para sair do jogo");
        play = Console.ReadLine();
        
        if ((play == "s") || (play == "S"))
        {
            x = true;
            Console.Clear();
        }
        else
        {
            x = false;
        }

    } while (x);
}
else
{
    Console.Clear();
}




/*string menssagem = "A raposa salta mais alto que o cachorro";
bool result = menssagem.Contains("cachorro");
Console.WriteLine(result);

if (menssagem.Contains("raposa"))
{
    Console.WriteLine("Qual é a lógica disso?");
}*/

