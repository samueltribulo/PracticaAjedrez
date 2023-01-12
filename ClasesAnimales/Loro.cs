using ClasesAnimales;
using System;

public class Loro : Animal
{
    public Loro(int Edad, double Altura, double Peso) : base(Edad, Altura, Peso)
    {
    }

    public override string PrintFood()
    {
        return "Comida: pipas";
    }

    public override string PrintProps()
    {
        return base.PrintProps();
    }
}
