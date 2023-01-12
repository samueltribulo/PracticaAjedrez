using ClasesAnimales;
using System;

public class Conejo : Animal
{
    public Conejo(int Edad, double Altura, double Peso) : base(Edad, Altura, Peso)
    {
    }

    public override string PrintFood()
    {
        return "Comida: Zanahoria";
    }
    public override string PrintProps()
    {
        return base.PrintProps();
    }
}
