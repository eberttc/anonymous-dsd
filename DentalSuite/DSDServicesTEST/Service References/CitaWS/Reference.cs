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
        private int CodigoHorarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoOdontologoField;
        
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
        public int CodigoHorario {
            get {
                return this.CodigoHorarioField;
            }
            set {
                if ((this.CodigoHorarioField.Equals(value) != true)) {
                    this.CodigoHorarioField = value;
                    this.RaisePropertyChanged("CodigoHorario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoOdontologo {
            get {
                return this.CodigoOdontologoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoOdontologoField, value) != true)) {
                    this.CodigoOdontologoField = value;
                    this.RaisePropertyChanged("CodigoOdontologo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultaCita", Namespace="http://schemas.datacontract.org/2004/07/DSDServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class ConsultaCita : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int citaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string especialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string horarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string odontologoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string pacienteField;
        
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
        public int cita {
            get {
                return this.citaField;
            }
            set {
                if ((this.citaField.Equals(value) != true)) {
                    this.citaField = value;
                    this.RaisePropertyChanged("cita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string especialidad {
            get {
                return this.especialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.especialidadField, value) != true)) {
                    this.especialidadField = value;
                    this.RaisePropertyChanged("especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((object.ReferenceEquals(this.fechaField, value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string horario {
            get {
                return this.horarioField;
            }
            set {
                if ((object.ReferenceEquals(this.horarioField, value) != true)) {
                    this.horarioField = value;
                    this.RaisePropertyChanged("horario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string odontologo {
            get {
                return this.odontologoField;
            }
            set {
                if ((object.ReferenceEquals(this.odontologoField, value) != true)) {
                    this.odontologoField = value;
                    this.RaisePropertyChanged("odontologo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string paciente {
            get {
                return this.pacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.pacienteField, value) != true)) {
                    this.pacienteField = value;
                    this.RaisePropertyChanged("paciente");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/consultarCitas", ReplyAction="http://tempuri.org/ICitas/consultarCitasResponse")]
        System.Collections.Generic.List<DSDServicesTEST.CitaWS.ConsultaCita> consultarCitas(string fecha, int especialidad, string odontologo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICitas/enviarPromociones", ReplyAction="http://tempuri.org/ICitas/enviarPromocionesResponse")]
        string enviarPromociones();
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
        
        public System.Collections.Generic.List<DSDServicesTEST.CitaWS.ConsultaCita> consultarCitas(string fecha, int especialidad, string odontologo) {
            return base.Channel.consultarCitas(fecha, especialidad, odontologo);
        }
        
        public string enviarPromociones() {
            return base.Channel.enviarPromociones();
        }
    }
}
