using System;
// programa principal banco

Banco banco = new Banco();
int sel = int.Parse(Console.ReadLine() ?? "");

try {

    CuentaBancaria cuentaOrigen = banco.BuscarCuenta("123456");
    CuentaBancaria cuentaDestino = banco.BuscarCuenta("789456");


    Console.WriteLine("Que operacion desea realizar ");
    Console.WriteLine("     1. Deposito  ");
    Console.WriteLine("     2. Retirar ");
    Console.WriteLine("     3. Transferir ");

    switch (sel) {
        case 1:

            Console.WriteLine($"Saldo inicial:${cuentaOrigen.Saldo}");
            break;

        case 2:

            Console.WriteLine($"Saldo inicial:${cuentaOrigen.Saldo}");

            break;

        case 3:
            //Transferencia
            Console.WriteLine($"Saldo inicial:${cuentaOrigen.Saldo}");

            Console.WriteLine("Haciendo transferencia");
            Console.WriteLine($"Saldo inicial: ${cuentaOrigen.Saldo}");
            cuentaOrigen.Transferir(cuentaDestino, 10);
            Console.WriteLine($"Saldo final: ${cuentaOrigen.Saldo}");
            break;

        default:
            Console.WriteLine("La operacion no es valida");
            break;
    }


} 
catch(CuentaNoEncontradaException ex ) {
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex) {
    Console.WriteLine(ex.Message);
}
catch (DepositoInvalidoException ex) {
    Console.WriteLine(ex.Message);
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}



public class SaldoInsuficienteException : Exception 
{
    //Constructor
    public SaldoInsuficienteException(string mensaje) : base(mensaje) {}
}
public class CuentaNoEncontradaException : Exception {
    //Constructor
    public CuentaNoEncontradaException(string mensaje) : base(mensaje) { }
}
public class DepositoInvalidoException : Exception {
    //Constructor
    public DepositoInvalidoException(string mensaje) : base(mensaje) { }
}
public class SaldoInsufcienteException : Exception {
    //Constructor
    public SaldoInsufcienteException(string mensaje) : base(mensaje) { }
}

//Cuenta de banco 
public class CuentaBancaria 
{

    //Atrbutos
    public string NumeroCuenta { get; }
    public decimal Saldo { get; set; }

    //Constructor
    public CuentaBancaria (string numeroCuenta, decimal saldo) 
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    //Metodos 

    public void Depositar(decimal cantidad) 
    {
        if (cantidad < 0) {
            throw new DepositoInvalidoException("No puedes depositar cantidades negativas");
        }
        Saldo += cantidad;
    }
    public void Retirar (decimal cantidad) {
        if (cantidad > Saldo ) {
            throw new SaldoInsufcienteException("Saldo Insuficiente para la operacion");
        }
        Saldo -= cantidad;
    }
    public void Transferir (CuentaBancaria destino, decimal cantidad) {
        if (destino == null) {
            throw new CuentaNoEncontradaException("Cuenta no encontrada ");
        }
        Retirar(cantidad);
        destino.Depositar(cantidad);

    }
}

public class Banco {
    //Atributos

    private CuentaBancaria[] cuentas;
    //Constructor
    public Banco() 
    {
        cuentas = new CuentaBancaria[]
        {
            new CuentaBancaria("123456",6),
            new CuentaBancaria("789456",20),
            new CuentaBancaria("741852",10000)
        };
    }
    //Metodos 

    public CuentaBancaria BuscarCuenta(string numeroCuenta) 
    {
        foreach (CuentaBancaria cuenta in cuentas) {
            if (cuenta.NumeroCuenta == numeroCuenta) {
                return cuenta;
            }
        }
        throw new CuentaNoEncontradaException("Cuenta no encontrada");
    }
}