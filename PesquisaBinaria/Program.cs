int[] listaNumerosOrdenados = { 1, 3, 5, 7, 9 };

void PercorrerLista(int item)
{
    int baixo = 0; // Representa o primeiro indice
    int alto = listaNumerosOrdenados.Length - 1; // Representa o último indice

    while (baixo <= alto)
    {
        int meio = (baixo + alto) / 2; // Armazena o valor do meio do array
        int chute = listaNumerosOrdenados[meio]; // Armazena o valor do 'chute' atual

        if (chute == item)
        {
            Console.WriteLine($"Número {item} encontrado no indice: {meio}"); // Ele retorna a posição do elemento desejado
            return;
        }
        else if (chute > item)
        {
            alto = meio - 1; // Caso o chute seja maior que o item, serão eliminados todos os números que estão acima do valor chutado
        }
        else
        {
            baixo = meio + 1; // Caso o chute seja menor que o item, serão eliminados todos os números que estão abaixo do valor chutado
        }
    }
}

PercorrerLista(5);

/*Explicação da pesquisa binária:
    É uma forma de buscar a posição de um determinado elemento
    Ele sempre vai no meio da lista, caso não satisfaça a condição, ele dá como eliminado todos os demais valores abaixo (caso seja menor que o valor da condição),
    ou elimina os demais acima (caso seja maior que o valor da condição)
    !ELE SEMPRE FAZ A BUSCA A PARTIR DO VALOR QUE ESTÁ NO MEIO DA LISTA!
*/