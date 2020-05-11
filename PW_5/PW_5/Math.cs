namespace PW_5
{
    class Math : AbstractMath
    {
        public override double Addition(double fOper, double sOper)
        {
            return fOper + sOper;
        }

        public override double Division(double fOper, double sOper)
        {
            return fOper / sOper;
        }

        public override double Max(double fOper, double sOper)
        {
            return fOper > sOper ? fOper : sOper;
        }

        public override double Min(double fOper, double sOper)
        {
            return fOper < sOper ? fOper : sOper;
        }

        public override double Multiplication(double fOper, double sOper)
        {
            return fOper * sOper;
        }

        public override double Subtraction(double fOper, double sOper)
        {
            return fOper - sOper;
        }
    }
}
