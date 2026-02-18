/*// programa pra ver excepciones 

int divisor = 0;
 //int resultados =107 divisor; //Lanza exepcion


try {
    int resultado = 10 / divisor;
}
catch (DivideByZeroException ex) //Todo lo que s coloque en el catch sucedera 
{
    Console.WriteLine(ex.Message);
    
}
finally {
    Console.WriteLine("Bloque que siempre s ejecuta");
}*/

try {
    Console.WriteLine("Introduce un numero entero positivo: );");
    int numero = int.Parse(Console.ReadLine() ?? "");
   
    if (numero<0)
    {
        throw new ArgumentException("El numero no puede ser negativo");//ArgumentExeption no me gusta lo que recibi 
    }
} 
catch (FormatException ex) //Excepcion de formato
{
    Console.WriteLine("Escribiste algo que no es un numero entero"); 
} 
catch (Exception ex) //error que no predecimos
{
    Console.WriteLine(ex.Message); //nos dice el error 
}
finally {
    Console.WriteLine("Esto siempre se ejecuta");
}