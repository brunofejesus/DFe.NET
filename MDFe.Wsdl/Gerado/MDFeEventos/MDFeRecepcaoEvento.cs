﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="MDFeRecepcaoEventoSoap12", Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeRecepcaoEvento")]
public partial class MDFeRecepcaoEvento : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private mdfeCabecMsg mdfeCabecMsgValueField;
    
    private System.Threading.SendOrPostCallback mdfeRecepcaoEventoOperationCompleted;
    
    /// <remarks/>
    public MDFeRecepcaoEvento(string url, string codigoEstado, string versao, X509Certificate2 x509Certificate2, int timeOut) {
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
    public event mdfeRecepcaoEventoCompletedEventHandler mdfeRecepcaoEventoCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapHeaderAttribute("mdfeCabecMsgValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeRecepcaoEvento/mdfeRecepcaoEvento", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeRecepcaoEvento")]
    public System.Xml.XmlNode mdfeRecepcaoEvento([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeRecepcaoEvento")] System.Xml.XmlNode mdfeDadosMsg) {
        object[] results = this.Invoke("mdfeRecepcaoEvento", new object[] {
                    mdfeDadosMsg});
        return ((System.Xml.XmlNode)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginmdfeRecepcaoEvento(System.Xml.XmlNode mdfeDadosMsg, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("mdfeRecepcaoEvento", new object[] {
                    mdfeDadosMsg}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Xml.XmlNode EndmdfeRecepcaoEvento(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Xml.XmlNode)(results[0]));
    }
    
    /// <remarks/>
    public void mdfeRecepcaoEventoAsync(System.Xml.XmlNode mdfeDadosMsg) {
        this.mdfeRecepcaoEventoAsync(mdfeDadosMsg, null);
    }
    
    /// <remarks/>
    public void mdfeRecepcaoEventoAsync(System.Xml.XmlNode mdfeDadosMsg, object userState) {
        if ((this.mdfeRecepcaoEventoOperationCompleted == null)) {
            this.mdfeRecepcaoEventoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmdfeRecepcaoEventoOperationCompleted);
        }
        this.InvokeAsync("mdfeRecepcaoEvento", new object[] {
                    mdfeDadosMsg}, this.mdfeRecepcaoEventoOperationCompleted, userState);
    }
    
    private void OnmdfeRecepcaoEventoOperationCompleted(object arg) {
        if ((this.mdfeRecepcaoEventoCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.mdfeRecepcaoEventoCompleted(this, new mdfeRecepcaoEventoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeRecepcaoEvento")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/mdfe/wsdl/MDFeRecepcaoEvento", IsNullable=false)]
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
public delegate void mdfeRecepcaoEventoCompletedEventHandler(object sender, mdfeRecepcaoEventoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class mdfeRecepcaoEventoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal mdfeRecepcaoEventoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
