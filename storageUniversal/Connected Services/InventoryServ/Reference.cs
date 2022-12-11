﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.28307.1000
// 
namespace storageUniversal.InventoryServ {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InventoryServ.InventoryFuncsSoap")]
    public interface InventoryFuncsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcAmountOut", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<float> CalcAmountOutAsync(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInventoryDataTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Data.DataTable> GetInventoryDataTableAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInventoryUserDataTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Data.DataTable> GetInventoryUserDataTableAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/changeInventoryRow", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> changeInventoryRowAsync(storageUniversal.InventoryServ.InventoryRow inventoryRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteInventoryRow", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> DeleteInventoryRowAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getNewItemId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> getNewItemIdAsync(int UserId);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class InventoryRow : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private float quantityField;
        
        private float neededQuantityField;
        
        private int ownerUserIdField;
        
        private float amountOutField;
        
        private string remarkesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
                this.RaisePropertyChanged("Quantity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float NeededQuantity {
            get {
                return this.neededQuantityField;
            }
            set {
                this.neededQuantityField = value;
                this.RaisePropertyChanged("NeededQuantity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int OwnerUserId {
            get {
                return this.ownerUserIdField;
            }
            set {
                this.ownerUserIdField = value;
                this.RaisePropertyChanged("OwnerUserId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public float AmountOut {
            get {
                return this.amountOutField;
            }
            set {
                this.amountOutField = value;
                this.RaisePropertyChanged("AmountOut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Remarkes {
            get {
                return this.remarkesField;
            }
            set {
                this.remarkesField = value;
                this.RaisePropertyChanged("Remarkes");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InventoryFuncsSoapChannel : storageUniversal.InventoryServ.InventoryFuncsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryFuncsSoapClient : System.ServiceModel.ClientBase<storageUniversal.InventoryServ.InventoryFuncsSoap>, storageUniversal.InventoryServ.InventoryFuncsSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InventoryFuncsSoapClient() : 
                base(InventoryFuncsSoapClient.GetDefaultBinding(), InventoryFuncsSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.InventoryFuncsSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventoryFuncsSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(InventoryFuncsSoapClient.GetBindingForEndpoint(endpointConfiguration), InventoryFuncsSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventoryFuncsSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InventoryFuncsSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventoryFuncsSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InventoryFuncsSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InventoryFuncsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Threading.Tasks.Task<float> CalcAmountOutAsync(int itemId) {
            return base.Channel.CalcAmountOutAsync(itemId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetInventoryDataTableAsync() {
            return base.Channel.GetInventoryDataTableAsync();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetInventoryUserDataTableAsync(int userId) {
            return base.Channel.GetInventoryUserDataTableAsync(userId);
        }
        
        public System.Threading.Tasks.Task<bool> changeInventoryRowAsync(storageUniversal.InventoryServ.InventoryRow inventoryRow) {
            return base.Channel.changeInventoryRowAsync(inventoryRow);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteInventoryRowAsync(int id) {
            return base.Channel.DeleteInventoryRowAsync(id);
        }
        
        public System.Threading.Tasks.Task<int> getNewItemIdAsync(int UserId) {
            return base.Channel.getNewItemIdAsync(UserId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.InventoryFuncsSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.InventoryFuncsSoap)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:50581/InventoryFuncs.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return InventoryFuncsSoapClient.GetBindingForEndpoint(EndpointConfiguration.InventoryFuncsSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return InventoryFuncsSoapClient.GetEndpointAddress(EndpointConfiguration.InventoryFuncsSoap);
        }
        
        public enum EndpointConfiguration {
            
            InventoryFuncsSoap,
        }
    }
}
