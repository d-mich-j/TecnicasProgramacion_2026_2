//Implementaciones del juego 

try {
    Console.WriteLine("BINVENIDO AL TORNEO DE GUERREROS ");
    Console.WriteLine("Ingresa el nombre de tu guerrero:");
    string Nombre = Console.ReadLine()??"";
    
} catch {

}

//Apartado de funciones 

static Guerrero SeleccionarClase() {
    while (true) {
        try {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("SELECCIONA TU CLASE ");
            Console.WriteLine("     1. Caballero ");
            Console.WriteLine("     2. Mago");
            Console.WriteLine("     3. Arquero");
            Console.WriteLine("     4. Guerrero sombra");
        } catch {

        }
    }
}


//Definiciones de clases 

public class Guerrero 
{
    //Atributos
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }


    //Constructor 
    public Guerrero(string nombre, int vida, int ataque ) 
    {
        Vida = vida;
        Ataque = ataque;
        Nombre = nombre;
    }

    //Metodos 
    public virtual void Atacar(Guerrero enemigo) {
        int danio = Ataque + new Random().Next();
        //recibir daño
        enemigo.Recibirdanio(danio);
        Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} causa {danio} de danio");
    }
    public void Recibirdanio(int cantidad) {
        Vida = Math.Max ( Vida - cantidad,0); //Math.Max si la suma e smenor que sero regresa 0, en otro caso es el resultado de a suma 

    }

    //Sobrecarga del operador +
    public static Guerrero operator + (Guerrero g1, Guerrero g2) {
        Console.WriteLine($"{g1.Nombre} + {g2.Nombre} se fusionan en un nuevo guerrero ");
        return new Guerrero ($"{g1.Nombre}----{g2.Nombre}", (g1.Vida + g2.Vida)/2, (g1.Ataque+g2.Ataque)/2 );
    }
}

//Clase Caballero

public class Caballero : Guerrero {
    //Constructor
    public Caballero(string nombre) : base(nombre, 120, 20) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {
        Console.WriteLine($"{Nombre}(Caballero) usa golpe critico");
        base.Atacar(enemigo);
    }
}

//Clase Mago
public class Mago : Guerrero {
    //Constructor 
    //Constructor
    public Mago(string nombre) : base(nombre, 80, 25) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {
        Console.WriteLine($"{Nombre}(Mago) lanza hechizo de fuego");
        base.Atacar(enemigo);
    }
}

//Clase Arquero
public class Arquero : Guerrero {
    //Constructor 
    //Constructor
    public Arquero(string nombre) : base(nombre, 90, 15) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {

        int probabilidad = new Random().Next(1,100);
        if (probabilidad < 30) {
            Console.WriteLine($"{Nombre} (Arquero) dispara una flecha y falla ");
        }else {
            Console.WriteLine($"{Nombre}(Arquero) lanza una flecha y acierta");
            base.Atacar(enemigo);
        }
            
    }
}
//Clase Guerrero Sombra
public class GuerreroSombra : Guerrero {
    //Constructor 
    //Constructor
    public GuerreroSombra(string nombre) : base(nombre, 110, 22) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {

        int chance = new Random().Next(1, 100);
        if (chance < 20) {
            Console.WriteLine($"{Nombre} (Guerrero Sombra) desaparece   ");
        } else {
            Console.WriteLine($"{Nombre}(Guerrero Sombra) ataca sigilozamente");
            base.Atacar(enemigo);
        }

    }
}