﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorServiceTestApp.CalculatorService1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService1.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        int Add(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtract", ReplyAction="http://tempuri.org/ICalculatorService/SubtractResponse")]
        int Subtract(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtract", ReplyAction="http://tempuri.org/ICalculatorService/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiply", ReplyAction="http://tempuri.org/ICalculatorService/MultiplyResponse")]
        int Multiply(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiply", ReplyAction="http://tempuri.org/ICalculatorService/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Divide", ReplyAction="http://tempuri.org/ICalculatorService/DivideResponse")]
        int Divide(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Divide", ReplyAction="http://tempuri.org/ICalculatorService/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(int Num1, int Num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : CalculatorServiceTestApp.CalculatorService1.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<CalculatorServiceTestApp.CalculatorService1.ICalculatorService>, CalculatorServiceTestApp.CalculatorService1.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int Num1, int Num2) {
            return base.Channel.Add(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int Num1, int Num2) {
            return base.Channel.AddAsync(Num1, Num2);
        }
        
        public int Subtract(int Num1, int Num2) {
            return base.Channel.Subtract(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int Num1, int Num2) {
            return base.Channel.SubtractAsync(Num1, Num2);
        }
        
        public int Multiply(int Num1, int Num2) {
            return base.Channel.Multiply(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int Num1, int Num2) {
            return base.Channel.MultiplyAsync(Num1, Num2);
        }
        
        public int Divide(int Num1, int Num2) {
            return base.Channel.Divide(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int Num1, int Num2) {
            return base.Channel.DivideAsync(Num1, Num2);
        }
    }
}
