using System;

namespace VogCodeChallenge.API
{
    public static class TestModule
    {
        //The method is ambiguous and it is better to provide a definitive name for it, to find out what is its functionality
        //The input parameter is better to be defined as a special type
        
        private const double Tolerance = 0.001;
        public static object Module(object testObject)
        {
            switch (testObject)
            {
                case 1:
                case 2:
                    return Doubler((int)testObject);
                case int value when value >= 3:
                    return Tripler(value);
                //By comparison of floating point numbers, loss of precision will occur, so it is better to define a tolerance value
                case float floatValue when Math.Abs(floatValue - 1.0f) < Tolerance:
                    return Leveler(floatValue);
                default:
                    return testObject;
            }
            
            int Doubler(int amount) => amount * 2;
            int Tripler(int amount) => amount * 3;
            //operator precedence should be observed
            //if you want to return double value it is better to compare value with 0.1d and multiply it by 10d
            double Leveler(double amount) => (amount - 0.1f) * 10f;
        }
    }
}