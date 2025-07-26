int[] arrayNumerosSoma = { 10, 100, 1000 }; // A soma deve retornar 1.110

// Recursão para soma de números
int Soma(int[] array, int indice = 0)
{
    if (indice >= array.Length)
    {
        return 0;
    }

    return array[indice] + Soma(array, indice + 1); // Cada vez que entrar na função, irá entrar adicionando +1 ao elemento
}

Console.WriteLine(Soma(arrayNumerosSoma));
Console.WriteLine("Soma concluida");
Console.WriteLine();

Console.WriteLine("Entrando na soma fatorial");
Thread.Sleep(1000);

// Recursão de fatoração de números
int Fatorial(int num)
{
    if (num <= 1)
    {
        return 1;
    }

    return num * Fatorial(num - 1); // Cada vez que entrar na função, irá entrar multiplicando o número atual pela subtração de -1 ao número
}

Console.Write("Informe o número que deseja sabe seu fatorial: ");
int numParaFatorial = int.Parse(Console.ReadLine()!);

Console.WriteLine(Fatorial(numParaFatorial));

/*Explicação de recusão:
    Quando uma função chama a si mesma (substituindo o loop para deixar uma estrutura mais simples)
    Loops podem possuir um desempenho maior

    Possui o caso base, condição que define a recursividade como concluida (quando no array resta 0 ou 1 elemento)
    Possui o caso recursivo, condição que defina o que irá acontecer caso não tenha encontrado o caso base
*/