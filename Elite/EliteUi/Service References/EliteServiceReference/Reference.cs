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
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace EliteUi.EliteServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EliteServiceReference.IEliteService")]
    public interface IEliteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEliteService/SendKeyDown", ReplyAction="http://tempuri.org/IEliteService/SendKeyDownResponse")]
        System.Threading.Tasks.Task SendKeyDownAsync(ushort virtualKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEliteService/SendKeyUp", ReplyAction="http://tempuri.org/IEliteService/SendKeyUpResponse")]
        System.Threading.Tasks.Task SendKeyUpAsync(ushort virtualKey);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEliteServiceChannel : EliteUi.EliteServiceReference.IEliteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EliteServiceClient : System.ServiceModel.ClientBase<EliteUi.EliteServiceReference.IEliteService>, EliteUi.EliteServiceReference.IEliteService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EliteServiceClient() : 
                base(EliteServiceClient.GetDefaultBinding(), EliteServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.NetHttpBinding_IEliteService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EliteServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(EliteServiceClient.GetBindingForEndpoint(endpointConfiguration), EliteServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EliteServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EliteServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EliteServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EliteServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EliteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task SendKeyDownAsync(ushort virtualKey) {
            return base.Channel.SendKeyDownAsync(virtualKey);
        }
        
        public System.Threading.Tasks.Task SendKeyUpAsync(ushort virtualKey) {
            return base.Channel.SendKeyUpAsync(virtualKey);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.NetHttpBinding_IEliteService)) {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.NetHttpBinding_IEliteService)) {
                return new System.ServiceModel.EndpointAddress(new System.Uri("http://localhost:8642/EliteService"), new System.ServiceModel.DnsEndpointIdentity("localhost"));
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return EliteServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetHttpBinding_IEliteService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return EliteServiceClient.GetEndpointAddress(EndpointConfiguration.NetHttpBinding_IEliteService);
        }
        
        public enum EndpointConfiguration {
            
            NetHttpBinding_IEliteService,
        }
    }
}
