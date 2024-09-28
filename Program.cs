// ***** Estrutura de Dados *****

// ArrayList
using System.Collections;

var arrayList = new ArrayList();

arrayList.Add(1); // Indíce 0
arrayList.Add("Ronaldo"); // Indíce 1
arrayList.Add(true); // Indíce 2

Console.WriteLine(arrayList[1]); // Acessar o array por índice

/*
  arrayList.RemoveAt(1); // Remover o valor do índice informado do array
  arrayList = new ArrayList(); // Uma das maneira de limpar o array todo
  arrayList.Clear(); // Uma das maneira de limpar o array todo
*/

foreach (var item in arrayList) // Percorrer todos os elementos de um array
{
  Console.WriteLine(item);
}

// Array Tipado (Neste tipo de array é necessário informar o tipo de dados e o tamanho do array)
var arrayTipado = new int[3]; // Criando um array sem atribuir valores

arrayTipado[0] = 5;
arrayTipado[1] = 10;
arrayTipado[2] = 15;

Array.Resize(ref arrayTipado, 4); // Alterando o tamanho do array

arrayTipado[3] = 20;

foreach (var item in arrayTipado)
{
  Console.WriteLine(item);
}

var arrayTipadoString = new string[2] { "Ronaldo", "Domingues" }; // Criando um array atribuindo valores

foreach (var item in arrayTipadoString)
{
  Console.WriteLine(item);
}

// Lista Genérica (É semelhante ao arraylist, porém a lista genérica é mais performática que o array list)
var lista = new List<string>(3)
{
  "Ronaldo",
  "Domingues",
};

lista.Add("dos"); // Outra maneira de adicionar valores a lista
lista.Add("Santos");

var nome = lista[0];
Console.WriteLine(nome);

lista.RemoveAt(2); // Para remover um item da lista

foreach (var item in lista)
{
  Console.WriteLine(item);
}

// Dicionário (É uma estrutura de dados que recebe 2 parâmetros, chave e valor)
var dicionario = new Dictionary<int, string>()
{
  {1, "Ronaldo"},
  {2, "Domingues"}
};

dicionario.Add(3, "dos"); // Maneiras de adicionar valor ao dicionário
dicionario[4] = "Santos"; // Maneiras de adicionar valor ao dicionário

nome = dicionario[1]; // Ao contrário dos arrays o dicionário é acessado pela key e não pelo índice
Console.WriteLine(nome);

foreach (var item in dicionario)
{
  Console.WriteLine(item.Value);
}

// Queue ou Fila (Lógica de ordenação FIFO (first in first out), ou seja, o primeiro a entrar será o primeiro a sair)
var queue = new Queue<string>(); // Ao criar uma Queue não é obrigatório declarar o tipo de dados, essa declaração é opcional

queue.Enqueue("1"); // Enqueue() para empilhar valores a queue
queue.Enqueue("2");
queue.Enqueue("3");

foreach (var item in queue) // Percorrer todos os itens da queue
{
  Console.WriteLine(item);
}

var valorQueue = queue.Peek(); // Peek() para pegar o primeiro valor da queue
Console.WriteLine(valorQueue);

valorQueue = queue.Dequeue(); // Dequeue() para desempilhar valores da queue, acessa o dado e remove da coleção
Console.WriteLine(valorQueue);

valorQueue = queue.Dequeue();
Console.WriteLine(valorQueue);

valorQueue = queue.Dequeue();
Console.WriteLine(valorQueue);

// Stack ou Pilha (Lógica de ordenação LIFO (last in first out), ou seja, o último a entrar será o primeiro a sair)
var stack = new Stack<string>();

stack.Push("5");
stack.Push("10");
stack.Push("15");

foreach (var item in stack) // Percorrer todos os itens da stack
{
  Console.WriteLine(item);
}

var valorStack = stack.Peek(); // Peek() para pegar o primeiro valor da stack
Console.WriteLine(valorStack);

valorStack = stack.Pop(); // Pop() para desempilhar valores da stack, acessa o dado e remove da coleção
Console.WriteLine(valorStack);

valorStack = stack.Pop(); 
Console.WriteLine(valorStack);

valorStack = stack.Pop(); 
Console.WriteLine(valorStack);
