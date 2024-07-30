namespace cSharpReview.CurrencyExercice
{
    internal class ConversorDeMoeda
    {
        public static double Cambio;
        public static double Quant;
        public static double Iof = 0.06;
        public static double DollarToReal()
        {
            return Quant * Cambio * (1 + Iof);
        }

    }
}
