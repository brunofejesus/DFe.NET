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

namespace MDFe.Wsdl.Gerado.MDFeStatusServico
{ // 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MDFeStatusServicoSoap12", Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeStatusServico")]
    public partial class MDFeStatusServico : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
        private mdfeCabecMsg mdfeCabecMsgValueField;
    
        private System.Threading.SendOrPostCallback mdfeStatusServicoMDFOperationCompleted;
    
        /// <remarks/>
        public MDFeStatusServico(string url, string codigoEstado, string versao, X509Certificate2 x509Certificate2, int timeOut) {
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
        public event mdfeStatusServicoMDFCompletedEventHandler mdfeStatusServicoMDFCompleted;
    
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("mdfeCabecMsgValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeStatusServico/mdfeStatusServicoMDF", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeStatusServico")]
        public System.Xml.XmlNode mdfeStatusServicoMDF([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeStatusServico")] System.Xml.XmlNode mdfeDadosMsg) {
            object[] results = this.Invoke("mdfeStatusServicoMDF", new object[] {
                mdfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }
    
        /// <remarks/>
        public System.IAsyncResult BeginmdfeStatusServicoMDF(System.Xml.XmlNode mdfeDadosMsg, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("mdfeStatusServicoMDF", new object[] {
                mdfeDadosMsg}, callback, asyncState);
        }
    
        /// <remarks/>
        public System.Xml.XmlNode EndmdfeStatusServicoMDF(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }
    
        /// <remarks/>
        public void mdfeStatusServicoMDFAsync(System.Xml.XmlNode mdfeDadosMsg) {
            this.mdfeStatusServicoMDFAsync(mdfeDadosMsg, null);
        }
    
        /// <remarks/>
        public void mdfeStatusServicoMDFAsync(System.Xml.XmlNode mdfeDadosMsg, object userState) {
            if ((this.mdfeStatusServicoMDFOperationCompleted == null)) {
                this.mdfeStatusServicoMDFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmdfeStatusServicoMDFOperationCompleted);
            }
            this.InvokeAsync("mdfeStatusServicoMDF", new object[] {
                mdfeDadosMsg}, this.mdfeStatusServicoMDFOperationCompleted, userState);
        }
    
        private void OnmdfeStatusServicoMDFOperationCompleted(object arg) {
            if ((this.mdfeStatusServicoMDFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mdfeStatusServicoMDFCompleted(this, new mdfeStatusServicoMDFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeStatusServico")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeStatusServico", IsNullable=false)]
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
    public delegate void mdfeStatusServicoMDFCompletedEventHandler(object sender, mdfeStatusServicoMDFCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mdfeStatusServicoMDFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
        private object[] results;
    
        internal mdfeStatusServicoMDFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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