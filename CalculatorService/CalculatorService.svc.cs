using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculatorService.svc or CalculatorService.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorService : ICalculatorService
    {
        public Int32 Add(Int32 Num1, Int32 Num2)
        {
            return Num1 + Num2;
        }
        
        public Int32 Subtract(Int32 Num1, Int32 Num2)
        {
            return Num1 - Num2;
        }
        
        public Int32 Multiply(Int32 Num1, Int32 Num2)
        {
            return Num1 * Num2;
        }
        
        public Int32 Divide(Int32 Num1, Int32 Num2)
        {
            return Num1 / Num2;
        }
    }
}
