namespace PW_5
{
    class ProxyMath : AbstractMath
    {
        private Math math;

        public ProxyMath()
        {
            math = new Math();
        }

        public override double Addition(double fOper, double sOper)
        {
            return math.Addition(fOper, sOper);
        }

        public override double Division(double fOper, double sOper)
        {
            return math.Addition(fOper, sOper);
        }

        public override double Max(double fOper, double sOper)
        {
            throw new System.NotImplementedException("Max");
        }

        public override double Min(double fOper, double sOper)
        {
            throw new System.NotImplementedException("Min");
        }

        public override double Multiplication(double fOper, double sOper)
        {
            return math.Multiplication(fOper, sOper);
        }

        public override double Subtraction(double fOper, double sOper)
        {
            return math.Subtraction(fOper, sOper);
        }
    }
}
