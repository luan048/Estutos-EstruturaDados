int[] arrayNum = { 5, 1, 3, 2, 4, 6 };

Console.WriteLine("Array original sem ordenação:");
Thread.Sleep(1500);

foreach (var num in arrayNum)
{
    Console.WriteLine(num);
}

// Ordenação por particionamento, o pivô muda a cada nova iteração do i++
for (int i = 0; i < arrayNum.Length; i++)
{
    for (int k = 0; k < arrayNum.Length - 1; k++)
    {
        if (arrayNum[k] > arrayNum[k + 1])
        {
            int temp = arrayNum[k];

            arrayNum[k] = arrayNum[k + 1];
            arrayNum[k + 1] = temp;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Array com ordenação:");
Thread.Sleep(1500);

foreach (var num in arrayNum)
{
    Console.WriteLine(num);
}

/*Explicação quicksort:
    Algoritmo de ordenação que utiliza estratégia Dividir para Conquistar (divide um grande problema em várias partes pequenas até chagar no caso-base)

    Deve-se escolher um elemento no array (chama-se de pivô) comparando com cada elemento do array até satisfazer o caso base
    Para encontrar o menor elemento em uma lista deve-se comparar o pivô com os outros elementos
*/