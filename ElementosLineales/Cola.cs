//COLA (QUEUE)
//FIFO primero en entrar primero en salir 
//Solo accede l primer elememnto 
//No permite busqueda

//Crear

Queue<string> cola = new Queue<string>();

//Añadir elementos 

cola.Enqueue("Primero");
cola.Enqueue("Segundo");
cola.Enqueue("Tercero");

foreach (string s in cola) 
{
    Console.WriteLine(s);
}

string primerElemento = cola.Dequeue(); //Devuelve el primer valor y lo elimina 
string frontal = cola.Peek(); //Devuelve el elemento sin eliminar 