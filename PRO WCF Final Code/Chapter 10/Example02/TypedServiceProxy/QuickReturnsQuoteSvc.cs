﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IQuoteService")]
public interface IQuoteService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuoteService/GetQuote", ReplyAction="http://tempuri.org/IQuoteService/GetQuoteResponse")]
    double GetQuote(string ticker);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IQuoteServiceChannel : IQuoteService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class QuoteServiceClient : System.ServiceModel.ClientBase<IQuoteService>, IQuoteService
{
    
    public QuoteServiceClient()
    {
    }
    
    public QuoteServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public QuoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public QuoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public QuoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double GetQuote(string ticker)
    {
        return base.Channel.GetQuote(ticker);
    }
}