﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DetalleLibro.DetalleRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DetalleRef.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaLibros", ReplyAction="http://tempuri.org/IService1/ObtenerListaLibrosResponse")]
        System.Data.DataSet ObtenerListaLibros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaLibros", ReplyAction="http://tempuri.org/IService1/ObtenerListaLibrosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerListaLibrosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaLibrosOrdenada", ReplyAction="http://tempuri.org/IService1/ObtenerListaLibrosOrdenadaResponse")]
        System.Data.DataSet ObtenerListaLibrosOrdenada(int quien, int orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaLibrosOrdenada", ReplyAction="http://tempuri.org/IService1/ObtenerListaLibrosOrdenadaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerListaLibrosOrdenadaAsync(int quien, int orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerDetalleLibro", ReplyAction="http://tempuri.org/IService1/ObtenerDetalleLibroResponse")]
        System.Data.DataSet ObtenerDetalleLibro(int libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerDetalleLibro", ReplyAction="http://tempuri.org/IService1/ObtenerDetalleLibroResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerDetalleLibroAsync(int libro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DetalleLibro.DetalleRef.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DetalleLibro.DetalleRef.IService1>, DetalleLibro.DetalleRef.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ObtenerListaLibros() {
            return base.Channel.ObtenerListaLibros();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerListaLibrosAsync() {
            return base.Channel.ObtenerListaLibrosAsync();
        }
        
        public System.Data.DataSet ObtenerListaLibrosOrdenada(int quien, int orden) {
            return base.Channel.ObtenerListaLibrosOrdenada(quien, orden);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerListaLibrosOrdenadaAsync(int quien, int orden) {
            return base.Channel.ObtenerListaLibrosOrdenadaAsync(quien, orden);
        }
        
        public System.Data.DataSet ObtenerDetalleLibro(int libro) {
            return base.Channel.ObtenerDetalleLibro(libro);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerDetalleLibroAsync(int libro) {
            return base.Channel.ObtenerDetalleLibroAsync(libro);
        }
    }
}
