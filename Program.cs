Persona niño = new Infante(5, "Raul", "");
Persona adulto = new Adulto(35, "UPC", "Daniel Barros");
Persona jovenAdulto = new JovenAdulto(26, "El Copey", "Maria");

niño.Presentarse();
adulto.Presentarse();
adulto.Votar();
jovenAdulto.Presentarse();
jovenAdulto.Votar();


adulto = new JovenAdulto(28, "Barranquilla", "Daniel");

adulto.Presentarse();
adulto.Votar();


public abstract class Persona
{

    public int Edad { get; set; }
    public string Nombres { get; set; }
    public string SitioVotacion { get; set; }

    protected Persona(int edad, string nombres, string sitioVotacion)
    {
        Edad = edad;
        Nombres = nombres;
        SitioVotacion = sitioVotacion;
    }

    public virtual void Presentarse()
    {
        Console.WriteLine($"Hola soy {Nombres} y tengo {Edad} años");
    }

    public abstract void Votar();
}

// Tipos de personas segun el tiempo
public class Infante : Persona
{
    public Infante(int edad, string nombres, string sitioVotacion) : base(edad, nombres, sitioVotacion)
    {
    }

    public override void Votar()
    {
        throw new NotImplementedException();
    }
}

public class Adulto : Persona
{
    public Adulto(int edad, string nombres, string sitioVotacion) : base(edad, nombres, sitioVotacion)
    {
    }

    public override void Votar()
    {
        Console.WriteLine($"Soy un adulto y voto en {SitioVotacion}");
    }
}

public class JovenAdulto : Persona
{
    public JovenAdulto(int edad, string nombres, string sitioVotacion) : base(edad, nombres, sitioVotacion)
    {
    }

    public override void Votar()
    {
        Console.WriteLine($"Soy un joven adulto y voto en {SitioVotacion}");
    }
}