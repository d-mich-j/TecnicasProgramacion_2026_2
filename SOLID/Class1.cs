//Un sistema de vacunas en una veterinaria 
Console.WriteLine("Caso 1 mascota comun:");
var sistema = new SistemaVeterinaria();
sistema.AtenderMascota("Juanito", "Perro", 2);

Console.WriteLine("Caso 2 mascota no contemplada:");
var sistema2 = new SistemaVeterinaria();
sistema.AtenderMascota("Jorgito", "Ave", 3);

Console.WriteLine("Caso 3 mascota especial:");
var sistema3 = new SistemaVeterinariaEspecial();
sistema.AtenderMascota("Rex", "Perro", 8);

Console.WriteLine("Caso 4 mascota especial:");
var sistema4 = new SistemaVeterinaria();
sistema.AtenderMascota("Bolillo", "Cocodrilo", 20);

//Clases dominio 

public class Mascota 
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }

    public Mascota(string nombre, string tipo, int edad) 
    {
        Nombre = nombre;
        Edad = edad;
        Tipo = tipo;
    }

    public bool EsValida() 
    {
        return !string.IsNullOrEmpty(Nombre) && Edad > 0;
    }

    public decimal CalcularVacuna() 
    {
        /*  Open-closed  */
        if (Tipo.StartsWith("P")) return 200;
        if (Tipo.StartsWith("G")) return 180;
        if (Tipo.Contains("tuga")) return 400;
        return Edad * 50;
    }

}

public class EmailService 
{
    public void Enviar(string mensaje) 
    {
        Console.WriteLine($"ENVIANDO CORRERO: {mensaje}");
    }
}

public class Notificador 
{
    private EmailService email = new EmailService();

    public void Notificar (Mascota mascota) 
    {
        email.Enviar($"Mascota info: {mascota.Nombre}; {mascota.CalcularVacuna}");
    }
}

public class SistemaVeterinaria 
{
    private List<Mascota> mascotas = new List<Mascota>();
    Notificador notificador = new Notificador();

    public virtual void AtenderMascota (string nombre, string tipo, int edad) 
    {
        var mascota = new Mascota(nombre, tipo, edad);

        if (!mascota.EsValida()) 
        {
            Console.WriteLine("Mascota no se puede registrar");
            return;
        }

        mascotas.Add(mascota);
        decimal costo = mascota.CalcularVacuna();
        notificador.Notificar(mascota);

        Console.WriteLine("Resumen de lista de mascotas - Reporte");

        foreach (var m in mascotas) 
        {
            Console.WriteLine($"{m.Nombre}-{m.Tipo}");
        }
    }

}


public class SistemaVeterinariaEspecial : SistemaVeterinaria 
{
    public override void AtenderMascota(string nombre, string tipo, int edad) 
    {
        if (tipo == "Perro") 
        {
            Console.WriteLine("Los perros no se atienden en este sistema");
            throw new Exception("Sistema incorrecto");
        }

        base.AtenderMascota(nombre, tipo, edad);
    }
}