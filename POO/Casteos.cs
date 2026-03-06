//Cateos 
//Conversion implicita lo permite por que es mas grande 

int numeroEntero = 42;
double numDouble = numeroEntero;

Console.WriteLine(numDouble);

//Conversion explicita pierdo informacion para guardar 

double numDouble2 = 42.75;
int numEntero2 = (int)numDouble2;
Console.WriteLine(numEntero2);

//Conversion co metodos 

string texto = "123";
int numerot = Convert.ToInt32(texto);
Console.WriteLine(numerot);

//Parse

string texto2 = "3.14";
double doublet = Convert.ToDouble(texto2);
Console.WriteLine(doublet); //mas tardado 

//solucion si se que es un numero

string texto21 = "3.14";
double doublet21 = double.Parse(texto2);
Console.WriteLine(doublet);

//tRY Parse 

string texto3 = "31.4";
bool exito = int.TryParse(texto3, out int resultado);
Console.WriteLine(exito);
Console.WriteLine(resultado);


//Casteos entre objetos y clases 

//upper casting hijo-padre

Animal mianimal = new Perro();

//Down casting Padre-Hijo

Perro perro = (Perro)new Animal();
perro.ladrar();