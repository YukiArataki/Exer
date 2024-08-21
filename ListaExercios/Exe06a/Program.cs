//1 - Criar um vetor de valores inteiros 
//2 - Percorrer o vetor com um laço
//3 - Gerar um valor aleatório em C# 
//4 - Ordenar o vetor usando o Bubble Sort

int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);
    
Console.Write(vetor[i] + " ");
}
bool troca = false;
do{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
{
    
    if(vetor[i] > vetor[i + 1])
    {
        troca = true;
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
        troca = true;
    }
     
}
}while(troca == true);

Console.WriteLine("\n");
//Imprimir o vetor com valores ordenados
for(int i = 0; i <vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}