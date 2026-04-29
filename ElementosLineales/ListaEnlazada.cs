//Lista enlazada 
//Funciona como una lista, cada elemento tiene un valor y un puntero al siguiente elemento 


//Crear

LinkedList<string> frutas = new LinkedList<string>();

//Agregar nodos

frutas.AddLast("Mango");
frutas.AddLast("Mandarina");
frutas.AddLast("Sandia");
frutas.AddLast("Uva");

foreach (string s in frutas) 
{
    Console.WriteLine(s);
}

//Recorrer mostrando enlaces

Console.WriteLine("Frutas en lista enazada");

LinkedListNode<string> actual = frutas.First;

while (actual != nuell) 
{
    string anterior = actual.Previous?.Value ?? "null";
    string siguiente = actual.Next?.Value ?? "null";

    Console.WriteLine($"[{anterior}]<- {actual.Value} -> [{siguiente}]");
    actual = actual.Next;

}

LinkedListNode<string> nodoNuevo = frutas.Find("Uva");
frutas.AddBefor(frutas.First(), "Mango");
frutas.AddAfter(nodoNuevo, "Tuna");