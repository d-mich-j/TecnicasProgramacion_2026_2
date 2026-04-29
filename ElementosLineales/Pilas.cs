//Pila 
//LIFO ultio en entrar primero en salir 
//Solo se puede acceder al elemento superior
//No permite bsquedas 
//No tiene indices 

//Crear

Stack<string> pila = new Stack<string>();

//Apilar 
pila.Push("Primero");
pila.Push("Segundo");
pila.Push("Tercero");

foreach (string s in pila) 
{
    Console.WriteLine(s);
}

//POP sacar elemeno de pila

string ultima = pila.Pop(); //Devuelve el valor y elimina  

foreach (string s in pila) 
{
    Console.WriteLine(s);
}

string superios = pila.Peek(); //Ve el elemento sin eliminar 

foreach (string s in pila) 
{
    Console.WriteLine(s);
}