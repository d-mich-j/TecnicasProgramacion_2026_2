//Declarcion

int[] numeros = new list[5];
string[] palabras = new string[3] { "Hola", "mundo", "adios" };


//Accseso 

int primerNumero = numeros[0];
paabras[1] = "universo";

//Array multidimensional

int[][] matriz = new int[3];    //Jaged arrey en el primer arreglo se agrega el segundo arreglo
int [,] matriz2 = new int[3, 3];

int[,] matrizInicializada = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//Acceso

for (int i=0; i<=2; i++) 
{
    for (int j = 0; j <= 2; j++) 
    {
        Console.WriteLine(matrizInicializada[i,j]);
    }
    Console.WriteLine("\n");
}

int[][] jagedArreay = new int[3][];

//AsignaeElementos 

jagedArreay[0] = new int[] { 1, 2 };
jagedArreay[1] = new int[2] { 3, 4 }; 
jagedArreay[2] = new int[] { 6 };

//Acceder a los elementos

foreach (int[] arreglo in jagedArreay) 
{
    foreach (int j in arreglo )
    {
        Console.WriteLine(j);
    }
    Console.WriteLine("\n");
}