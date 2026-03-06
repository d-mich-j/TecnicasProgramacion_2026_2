//Programa principal
bool continua = true;

List<IPago> LIST = new List<IPago>();

do {
    Console.WriteLine("Ingres el monto a pagar: ");
    string montoTexto = Console.ReadLine() ?? "";
    if (double.TryParse(montoTexto, out double monto)) {

        string modoPagoT;
        int modoPago;
        do {

            Console.WriteLine("1- Pago con tarjeta");
            Console.WriteLine("2- Pago con tarjeta");

            modoPagoT = Console.ReadLine() ?? "";


        } while (!int.TryParse (modoPagoT, out  modoPago) || (modoPago != 1 && modoPago !=2 ));
        
        if (modoPago == 1) {

            Console.WriteLine("Ingresa el numero de tarjeta");
            string tarjeta = Console.ReadLine() ?? "";

            //Creando objeto´para pago con tarjeta 

            IPago pago = new PagoTarjeta(tarjeta,monto);
            listaPagos.Add(pago);

        }
        else if(modoPago == 2) {
            //Creando objeto para pago en efectivo 

            IPago pago = new PagoEfectivo(monto);
            listaPagos.Add(pago);

        }

    } else 
    {
        Console.WriteLine("Error monto invalido");
        return;
    }

    Console.WriteLine("Presiona S para procesar mas pagos ");
    char continuaT = char.Parse(Console.ReadLine() ?? "".ToLower);

    if (continuaT == 's') 
    {
        continua = true;
    }else {
        continua = false;
    }

    
} while (continua);

foreach (IPago pago in listaPago){
    PagoEfectivo.ProcesarPago;

}

//Interfaz y clases 

public interface IPago {
    void ProcesarPago();

}

//Clase de pago en efectivo

public class PagoEfectivo : IPago 
{

    //Atributos

    public double Monto { get; set; }

    //Constructor

    public PagoEfectivo(double monto) 
    {
        Monto = monto;
    }

    //Metodos 
    public void ProcesarPago() 
    {
        Console.WriteLine($"PAGO EN EFECTIVO DE {Monto} PROCESADO");

    }

}

public class PagoTarjeta (string numeroTarjeta, double monto) 
{
    //Atributos

    public string NumeroTarjeta { get; set; }
    public double Monto { get; set; }

    //Constructor 

    public PagoTarjeta(string numeroTarjeta, double monto) {
        NumeroTarjeta = numeroTarjeta;
        Monto = monto;
    }

    //Metodos 

    public void ProcesarPago() 
    {
        if (NumeroTarjeta.Length == 16) {
            Console.WriteLine($"PAGO EN TARJETA DE {monto} PROCESADO ");

        }else {
            Console.WriteLine("Tarjeta invalida");
        }
    }

}
 

