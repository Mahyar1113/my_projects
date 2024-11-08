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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SoapClient.localhost {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GeoSoap", Namespace="http://tempuri.org/")]
    public partial class Geo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPointByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDistanceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetClosestPositionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Geo() {
            this.Url = global::SoapClient.Properties.Settings.Default.SoapClient_localhost_Geo;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetPointByIDCompletedEventHandler GetPointByIDCompleted;
        
        /// <remarks/>
        public event GetDistanceCompletedEventHandler GetDistanceCompleted;
        
        /// <remarks/>
        public event GetClosestPositionCompletedEventHandler GetClosestPositionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPointByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GeoPoint GetPointByID(int id) {
            object[] results = this.Invoke("GetPointByID", new object[] {
                        id});
            return ((GeoPoint)(results[0]));
        }
        
        /// <remarks/>
        public void GetPointByIDAsync(int id) {
            this.GetPointByIDAsync(id, null);
        }
        
        /// <remarks/>
        public void GetPointByIDAsync(int id, object userState) {
            if ((this.GetPointByIDOperationCompleted == null)) {
                this.GetPointByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPointByIDOperationCompleted);
            }
            this.InvokeAsync("GetPointByID", new object[] {
                        id}, this.GetPointByIDOperationCompleted, userState);
        }
        
        private void OnGetPointByIDOperationCompleted(object arg) {
            if ((this.GetPointByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPointByIDCompleted(this, new GetPointByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDistance", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double GetDistance(double x, double y, int id) {
            object[] results = this.Invoke("GetDistance", new object[] {
                        x,
                        y,
                        id});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void GetDistanceAsync(double x, double y, int id) {
            this.GetDistanceAsync(x, y, id, null);
        }
        
        /// <remarks/>
        public void GetDistanceAsync(double x, double y, int id, object userState) {
            if ((this.GetDistanceOperationCompleted == null)) {
                this.GetDistanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDistanceOperationCompleted);
            }
            this.InvokeAsync("GetDistance", new object[] {
                        x,
                        y,
                        id}, this.GetDistanceOperationCompleted, userState);
        }
        
        private void OnGetDistanceOperationCompleted(object arg) {
            if ((this.GetDistanceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDistanceCompleted(this, new GetDistanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetClosestPosition", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GeoPoint GetClosestPosition(double importX, double importY) {
            object[] results = this.Invoke("GetClosestPosition", new object[] {
                        importX,
                        importY});
            return ((GeoPoint)(results[0]));
        }
        
        /// <remarks/>
        public void GetClosestPositionAsync(double importX, double importY) {
            this.GetClosestPositionAsync(importX, importY, null);
        }
        
        /// <remarks/>
        public void GetClosestPositionAsync(double importX, double importY, object userState) {
            if ((this.GetClosestPositionOperationCompleted == null)) {
                this.GetClosestPositionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetClosestPositionOperationCompleted);
            }
            this.InvokeAsync("GetClosestPosition", new object[] {
                        importX,
                        importY}, this.GetClosestPositionOperationCompleted, userState);
        }
        
        private void OnGetClosestPositionOperationCompleted(object arg) {
            if ((this.GetClosestPositionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetClosestPositionCompleted(this, new GetClosestPositionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GeoPoint {
        
        private int idField;
        
        private double xField;
        
        private double yField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public double X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public double Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetPointByIDCompletedEventHandler(object sender, GetPointByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPointByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPointByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GeoPoint Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GeoPoint)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetDistanceCompletedEventHandler(object sender, GetDistanceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDistanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDistanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetClosestPositionCompletedEventHandler(object sender, GetClosestPositionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetClosestPositionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetClosestPositionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GeoPoint Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GeoPoint)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591