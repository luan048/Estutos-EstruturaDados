int[] arrayNumeros = { 5, 1, 3, 7, 4, 8, 2, 6 };

void QuickSort(int[] array, int inicio, int fim)
{
    if (inicio < fim)
    {
        int pivoIndex = Particionar(array, inicio, fim);
        QuickSort(array, inicio, pivoIndex - 1);
        QuickSort(array, pivoIndex + 1, fim);
    }
}

int Particionar(int[] array, int inicio, int fim)
{
    int pivo = array[(inicio + fim) / 2];
    int esquerda = inicio;
    int direita = fim;

    while (esquerda <= direita)
    {
        while (array[esquerda] < pivo) esquerda++;
        while (array[direita] > pivo) direita--;

        if (esquerda <= direita)
        {
            int temp = array[esquerda];
            array[esquerda] = array[direita];
            array[direita] = temp;
            esquerda++;
            direita--;
        }
    }

    return esquerda;
}

QuickSort(arrayNumeros, 0, arrayNumeros.Length - 1);

Console.WriteLine("Array ordenado:");
foreach (var item in arrayNumeros)
{
    Console.WriteLine(item);
}


/*Explicação: 
    Quicksort onde o pivô escolhido é o elemento do meio, mais rápido por diminuir pela metade o tempo de percorrer a lista
    Tempo de execução O(n²)

    Tudo isso consiste em ordanizar todos os elementos maiores que o pivô de um lado, e os menor que o pivô de um outro
*/  