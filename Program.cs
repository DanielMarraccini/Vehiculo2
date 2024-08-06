class Vehiculo
{

    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)    //contructor
    {

        Marca = marca; //se instancia
        Modelo = modelo;
    }

    protected void MostrarDetalles()
    {

        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

class Coche : Vehiculo
{
    public int NumeroPuertas { get; set; }
    public Coche(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
    {

        NumeroPuertas = numeroPuertas;
    }

    public void MostrarInformacionCoche()
    {

        MostrarDetalles();  //Llamada al método protegido de la clase base
        Console.WriteLine($"Número de puertas: {NumeroPuertas}");
    }

}

class Program
{

    static void Main()
    {

        Coche coche = new Coche("Toyota", "Corona", 4);
        coche.MostrarInformacionCoche();
    }
}