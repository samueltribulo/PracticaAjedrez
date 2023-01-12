namespace ClasesAnimales
{
    public abstract class Animal
    {
        public Animal(int Edad, double Altura, double Peso)
        {

            this.EdadSet = Edad;
            this.AlturaSet = Altura;
            this.PesoSet = Peso;

        }

        public int EdadSet { get; set; }

        public double PesoSet { get; set; }

        public double AlturaSet { get; set; }

        public int Edad
        {
            get
            {
                return this.EdadSet;
            }
        }

        public double Altura
        {
            get
            {
                return this.AlturaSet;
            }
        }

        public double Peso
        {
            get
            {
                return this.PesoSet;
            }
        }

        public virtual string PrintProps()
        {

            return $"Edad: {this.Edad}.\nPeso: {this.Peso}.\nAltura: {this.Altura}.";

        }

        public abstract string PrintFood();

    }
}