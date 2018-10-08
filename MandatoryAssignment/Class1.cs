using System;

namespace MandatoryAssignment
{
    public class Class1
    {
        public double ConvertionGramToOunce(double gram)
        {
            double ounce = gram / 28.3495231;
            return ounce;
        }
        public double ConvertionOunceToGram(double ounce)
        {
            double gram = ounce * 28.3495231;
            return gram;
        }
    }
}
