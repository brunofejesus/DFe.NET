//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Security.Cryptography.X509Certificates;

namespace MDFe.Wsdl.Gerado.MDFeConsultaProtoloco
{ // 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MDFeConsultaSoap12", Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsulta")]
    public partial class MDFeConsulta : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
        private mdfeCabecMsg mdfeCabecMsgValueField;
    
        private System.Threading.SendOrPostCallback mdfeConsultaMDFOperationCompleted;
    
        /// <remarks/>
        public MDFeConsulta(string url, string codigoEstado, string versao, X509Certificate2 x509Certificate2, int timeOut) {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = url;
            this.mdfeCabecMsgValue = new mdfeCabecMsg
            {
                cUF = codigoEstado,
                versaoDados = versao
            };
            this.ClientCertificates.Add(x509Certificate2);
            this.Timeout = timeOut;
        }
    
        public mdfeCabecMsg mdfeCabecMsgValue {
            get {
                return this.mdfeCabecMsgValueField;
            }
            set {
                this.mdfeCabecMsgValueField = value;
            }
        }
    
        /// <remarks/>
        public event mdfeConsultaMDFCompletedEventHandler mdfeConsultaMDFCompleted;
    
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("mdfeCabecMsgValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsulta/mdfeConsultaMDF", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsulta")]
        public System.Xml.XmlNode mdfeConsultaMDF([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsulta")] System.Xml.XmlNode mdfeDadosMsg) {
            object[] results = this.Invoke("mdfeConsultaMDF", new object[] {
                mdfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }
    
        /// <remarks/>
        public System.IAsyncResult BeginmdfeConsultaMDF(System.Xml.XmlNode mdfeDadosMsg, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("mdfeConsultaMDF", new object[] {
                mdfeDadosMsg}, callback, asyncState);
        }
    
        /// <remarks/>
        public System.Xml.XmlNode EndmdfeConsultaMDF(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }
    
        /// <remarks/>
        public void mdfeConsultaMDFAsync(System.Xml.XmlNode mdfeDadosMsg) {
            this.mdfeConsultaMDFAsync(mdfeDadosMsg, null);
        }
    
        /// <remarks/>
        public void mdfeConsultaMDFAsync(System.Xml.XmlNode mdfeDadosMsg, object userState) {
            if ((this.mdfeConsultaMDFOperationCompleted == null)) {
                this.mdfeConsultaMDFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmdfeConsultaMDFOperationCompleted);
            }
            this.InvokeAsync("mdfeConsultaMDF", new object[] {
                mdfeDadosMsg}, this.mdfeConsultaMDFOperationCompleted, userState);
        }
    
        private void OnmdfeConsultaMDFOperationCompleted(object arg) {
            if ((this.mdfeConsultaMDFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mdfeConsultaMDFCompleted(this, new mdfeConsultaMDFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsulta")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeConsulta", IsNullable=false)]
    public partial class mdfeCabecMsg : System.Web.Services.Protocols.SoapHeader {
    
        private string cUFField;
    
        private string versaoDadosField;
    
        private System.Xml.XmlAttribute[] anyAttrField;
    
        /// <remarks/>
        public string cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
            }
        }
    
        /// <remarks/>
        public string versaoDados {
            get {
                return this.versaoDadosField;
            }
            set {
                this.versaoDadosField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    public delegate void mdfeConsultaMDFCompletedEventHandler(object sender, mdfeConsultaMDFCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mdfeConsultaMDFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
        private object[] results;
    
        internal mdfeConsultaMDFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
            this.results = results;
            }
    
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}