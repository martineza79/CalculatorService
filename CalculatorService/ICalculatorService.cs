using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        Int32 Add(Int32 Num1, Int32 Num2);

        [OperationContract]
        Int32 Subtract(Int32 Num1, Int32 Num2);

        [OperationContract]
        Int32 Multiply(Int32 Num1, Int32 Num2);

        [OperationContract]
        Int32 Divide(Int32 Num1, Int32 Num2);
    }
}
