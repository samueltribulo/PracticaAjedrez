using ClasesAnimales;
using System;
using System.Security.Cryptography.X509Certificates;

public class Leon:Animal
{
    public Leon(int Edad, double Altura, double Peso) : base(Edad, Altura, Peso)
    {
    }

    public override string PrintFood()
    {
        return "Comida: Carne";
    }

    public override string PrintProps()
    {
        return base.PrintProps();
    }

}
