﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSDServicesTEST.CitaWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cita", Namespace="http://schemas.datacontract.org/2004/07/DSDServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cita : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoEspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoHorarioOdontologoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaReservaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoEspecialidad {
            get {
                return this.CodigoEspecialidadField;
            }
            set {
                if ((this.CodigoEspecialidadField.Equals(value) != true)) {
                    this.CodigoEspecialidadField = value;
                    this.RaisePropertyChanged("CodigoEspecialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoHorarioOdontologo {
            get {
                return this.CodigoHorarioOdontologoField;
            }
            set {
                if ((this.CodigoHorarioOdontologoField.Equals(value) != true)) {
                    this.CodigoHorarioOdontologoField = value;
                    this.RaisePropertyChanged("CodigoHorarioOdontologo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoPaciente {
            get {
                return this.CodigoPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoPacienteField, value) != true)) {
                    this.CodigoPacienteField = value;
                    this.RaisePropertyChanged("CodigoPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaReserva {
            get {
                return this.FechaReservaField;
            }
            set {
                if ((this.FechaReservaField.Equals(value) != true)) {
                    this.FechaReservaField = value;
                    this.RaisePropertyChanged("FechaReserva");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServiceOfCitaz_SY3AMPv", Namespace="http://schemas.datacontract.org/2004/07/DSDServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class RespuestaServiceOfCitaz_SY3AMPv : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DSDServicesTEST.CitaWS.Cita ClaseOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeDescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MetodoOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServicioOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoMensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DSDServicesTEST.CitaWS.Cita ClaseOrigen {
            get {
                return this.ClaseOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaseOrigenField, value) != true)) {
                    this.ClaseOrigenField = value;
                    this.RaisePropertyChanged("ClaseOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeDescripcion {
            get {
                return this.MensajeDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeDescripcionField, value) != true)) {
                    this.MensajeDescripcionField = value;
                    this.RaisePropertyChanged("MensajeDescripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MetodoOrigen {
            get {
                return this.MetodoOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.MetodoOrigenField, value) != true)) {
                    this.MetodoOrigenField = value;
                    this.RaisePropertyChanged("MetodoOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServicioOrigen {
            get {
                return this.ServicioOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.ServicioOrigenField, value) != true)) {
                    this.ServicioOrigenField = value;
                    this.RaisePropertyChanged("ServicioOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoMensaje {
            get {
                return this.TipoMensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoMensajeField, value) != true)) {
                    this.TipoMensajeField = value;
                    this.RaisePropertyChanged("TipoMensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CitaWS.ICitas")]
    public interface ICitas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/registrarCita", ReplyAction="http://tempuri.org/ICitas/registrarCitaResponse")]
        DSDServicesTEST.CitaWS.RespuestaServiceOfCitaz_SY3AMPv registrarCita(DSDServicesTEST.CitaWS.Cita cita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/modificarCita", ReplyAction="http://tempuri.org/ICitas/modificarCitaResponse")]
        DSDServicesTEST.CitaWS.RespuestaServiceOfCitaz_SY3AMPv modificarCita(DSDServicesTEST.CitaWS.Cita cita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/cancelarCita", ReplyAction="http://tempuri.org/ICitas/cancelarCitaResponse")]
        void cancelarCita(DSDServicesTEST.CitaWS.Cita cita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/listarCitas", ReplyAction="http://tempuri.org/ICitas/listarCitasResponse")]
        System.Collections.Generic.List<DSDServicesTEST.CitaWS.Cita> listarCitas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/listarCitasPacienteAdministrador", ReplyAction="http://tempuri.org/ICitas/listarCitasPacienteAdministradorResponse")]
        System.Collections.Generic.List<DSDServicesTEST.CitaWS.Cita> listarCitasPacienteAdministrador();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICitasChannel : DSDServicesTEST.CitaWS.ICitas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CitasClient : System.ServiceModel.ClientBase<DSDServicesTEST.CitaWS.ICitas>, DSDServicesTEST.CitaWS.ICitas {
        
        public CitasClient() {
        }
        
        public CitasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CitasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CitasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CitasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DSDServicesTEST.CitaWS.RespuestaServiceOfCitaz_SY3AMPv registrarCita(DSDServicesTEST.CitaWS.Cita cita) {
            return base.Channel.registrarCita(cita);
        }
        
        public DSDServicesTEST.CitaWS.RespuestaServiceOfCitaz_SY3AMPv modificarCita(DSDServicesTEST.CitaWS.Cita cita) {
            return base.Channel.modificarCita(cita);
        }
        
        public void cancelarCita(DSDServicesTEST.CitaWS.Cita cita) {
            base.Channel.cancelarCita(cita);
        }
        
        public System.Collections.Generic.List<DSDServicesTEST.CitaWS.Cita> listarCitas() {
            return base.Channel.listarCitas();
        }
        
        public System.Collections.Generic.List<DSDServicesTEST.CitaWS.Cita> listarCitasPacienteAdministrador() {
            return base.Channel.listarCitasPacienteAdministrador();
        }
    }
}
