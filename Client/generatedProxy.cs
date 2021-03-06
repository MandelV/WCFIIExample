﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Payment", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    public partial class Payment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private double AmountField;
        
        private string CcNumberField;
        
        private Service.PaymentStatus PaymentStatusField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Amount
        {
            get
            {
                return this.AmountField;
            }
            set
            {
                this.AmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CcNumber
        {
            get
            {
                return this.CcNumberField;
            }
            set
            {
                this.CcNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Service.PaymentStatus PaymentStatus
        {
            get
            {
                return this.PaymentStatusField;
            }
            set
            {
                this.PaymentStatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentStatus", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    public enum PaymentStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VALIDATED = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CANCELED = 1,
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IBank")]
public interface IBank
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/CreatePayment", ReplyAction="http://tempuri.org/IBank/CreatePaymentResponse")]
    void CreatePayment(string ccNumber, double amount);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/CreatePayment", ReplyAction="http://tempuri.org/IBank/CreatePaymentResponse")]
    System.Threading.Tasks.Task CreatePaymentAsync(string ccNumber, double amount);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/GetPayment", ReplyAction="http://tempuri.org/IBank/GetPaymentResponse")]
    Service.Payment GetPayment(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/GetPayment", ReplyAction="http://tempuri.org/IBank/GetPaymentResponse")]
    System.Threading.Tasks.Task<Service.Payment> GetPaymentAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/GetPayments", ReplyAction="http://tempuri.org/IBank/GetPaymentsResponse")]
    Service.Payment[] GetPayments();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/GetPayments", ReplyAction="http://tempuri.org/IBank/GetPaymentsResponse")]
    System.Threading.Tasks.Task<Service.Payment[]> GetPaymentsAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IBankChannel : IBank, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class BankClient : System.ServiceModel.ClientBase<IBank>, IBank
{
    
    public BankClient()
    {
    }
    
    public BankClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BankClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BankClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BankClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void CreatePayment(string ccNumber, double amount)
    {
        base.Channel.CreatePayment(ccNumber, amount);
    }
    
    public System.Threading.Tasks.Task CreatePaymentAsync(string ccNumber, double amount)
    {
        return base.Channel.CreatePaymentAsync(ccNumber, amount);
    }
    
    public Service.Payment GetPayment(int id)
    {
        return base.Channel.GetPayment(id);
    }
    
    public System.Threading.Tasks.Task<Service.Payment> GetPaymentAsync(int id)
    {
        return base.Channel.GetPaymentAsync(id);
    }
    
    public Service.Payment[] GetPayments()
    {
        return base.Channel.GetPayments();
    }
    
    public System.Threading.Tasks.Task<Service.Payment[]> GetPaymentsAsync()
    {
        return base.Channel.GetPaymentsAsync();
    }
}
