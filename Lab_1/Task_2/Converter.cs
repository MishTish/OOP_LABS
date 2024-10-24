
namespace Task_2
{
    internal class Converter
    {
        private double _excRateUsd;
        private double _excRateEur;
        private double _excRatePln;
        public Converter(double usd, double eur, double pln)
        {
            _excRateUsd = usd;
            _excRateEur = eur;
            _excRatePln = pln;
        }
        public double Uah_Usd(double value)
        {
            return value * _excRateUsd;
        }
        public double Uah_Eur(double value)
        {
            return value * _excRateEur;
        }
        public double Uah_Pln(double value)
        {
            return value * _excRatePln;
        }
        public double Usd_Uah(double value)
        {
            return value / _excRateUsd;
        }
        public double Eur_Uah(double value)
        {
            return value / _excRateEur;
        }
        public double Pln_Uah(double value)
        {
            return value / _excRatePln;
        }
    }

}
