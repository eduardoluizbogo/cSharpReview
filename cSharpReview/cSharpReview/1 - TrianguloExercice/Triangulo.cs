namespace cSharpReview
{
    class Triangulo
    {
        public double A; //Atributes starts w/ uppercase
        public double B;
        public double C;

        public double Area() //starts w/ uppercase
        { 
            double p = (A+B+C) / 2.0;
            return Math.Sqrt(p * (p-A) * (p-B) * (p-C));
        }
    }
}


