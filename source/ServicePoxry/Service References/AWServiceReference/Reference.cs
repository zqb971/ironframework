﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicePoxry.AWServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/BusinessEntities")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContactIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CurrentFlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime HireDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ManagerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaritalStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalIDNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SalariedFlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short SickLeaveHoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short VacationHoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid rowguidField;
        
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
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContactID {
            get {
                return this.ContactIDField;
            }
            set {
                if ((this.ContactIDField.Equals(value) != true)) {
                    this.ContactIDField = value;
                    this.RaisePropertyChanged("ContactID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CurrentFlag {
            get {
                return this.CurrentFlagField;
            }
            set {
                if ((this.CurrentFlagField.Equals(value) != true)) {
                    this.CurrentFlagField = value;
                    this.RaisePropertyChanged("CurrentFlag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime HireDate {
            get {
                return this.HireDateField;
            }
            set {
                if ((this.HireDateField.Equals(value) != true)) {
                    this.HireDateField = value;
                    this.RaisePropertyChanged("HireDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginID {
            get {
                return this.LoginIDField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginIDField, value) != true)) {
                    this.LoginIDField = value;
                    this.RaisePropertyChanged("LoginID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ManagerID {
            get {
                return this.ManagerIDField;
            }
            set {
                if ((this.ManagerIDField.Equals(value) != true)) {
                    this.ManagerIDField = value;
                    this.RaisePropertyChanged("ManagerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaritalStatus {
            get {
                return this.MaritalStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.MaritalStatusField, value) != true)) {
                    this.MaritalStatusField = value;
                    this.RaisePropertyChanged("MaritalStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                if ((this.ModifiedDateField.Equals(value) != true)) {
                    this.ModifiedDateField = value;
                    this.RaisePropertyChanged("ModifiedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalIDNumber {
            get {
                return this.NationalIDNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalIDNumberField, value) != true)) {
                    this.NationalIDNumberField = value;
                    this.RaisePropertyChanged("NationalIDNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SalariedFlag {
            get {
                return this.SalariedFlagField;
            }
            set {
                if ((this.SalariedFlagField.Equals(value) != true)) {
                    this.SalariedFlagField = value;
                    this.RaisePropertyChanged("SalariedFlag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short SickLeaveHours {
            get {
                return this.SickLeaveHoursField;
            }
            set {
                if ((this.SickLeaveHoursField.Equals(value) != true)) {
                    this.SickLeaveHoursField = value;
                    this.RaisePropertyChanged("SickLeaveHours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short VacationHours {
            get {
                return this.VacationHoursField;
            }
            set {
                if ((this.VacationHoursField.Equals(value) != true)) {
                    this.VacationHoursField = value;
                    this.RaisePropertyChanged("VacationHours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid rowguid {
            get {
                return this.rowguidField;
            }
            set {
                if ((this.rowguidField.Equals(value) != true)) {
                    this.rowguidField = value;
                    this.RaisePropertyChanged("rowguid");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="PagedListOfEmployeegSBaJWHs", Namespace="http://schemas.datacontract.org/2004/07/IronFramework.Utility.UI", ItemName="Employee")]
    [System.SerializableAttribute()]
    public class PagedListOfEmployeegSBaJWHs : System.Collections.Generic.List<ServicePoxry.AWServiceReference.Employee> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="PagedListOfContactgSBaJWHs", Namespace="http://schemas.datacontract.org/2004/07/IronFramework.Utility.UI", ItemName="Contact")]
    [System.SerializableAttribute()]
    public class PagedListOfContactgSBaJWHs : System.Collections.Generic.List<ServicePoxry.AWServiceReference.Contact> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/BusinessEntities")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdditionalContactInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContactIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmailPromotionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool NameStyleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordSaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuffixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid rowguidField;
        
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
        public string AdditionalContactInfo {
            get {
                return this.AdditionalContactInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.AdditionalContactInfoField, value) != true)) {
                    this.AdditionalContactInfoField = value;
                    this.RaisePropertyChanged("AdditionalContactInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContactID {
            get {
                return this.ContactIDField;
            }
            set {
                if ((this.ContactIDField.Equals(value) != true)) {
                    this.ContactIDField = value;
                    this.RaisePropertyChanged("ContactID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmailPromotion {
            get {
                return this.EmailPromotionField;
            }
            set {
                if ((this.EmailPromotionField.Equals(value) != true)) {
                    this.EmailPromotionField = value;
                    this.RaisePropertyChanged("EmailPromotion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                if ((this.ModifiedDateField.Equals(value) != true)) {
                    this.ModifiedDateField = value;
                    this.RaisePropertyChanged("ModifiedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NameStyle {
            get {
                return this.NameStyleField;
            }
            set {
                if ((this.NameStyleField.Equals(value) != true)) {
                    this.NameStyleField = value;
                    this.RaisePropertyChanged("NameStyle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordSalt {
            get {
                return this.PasswordSaltField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordSaltField, value) != true)) {
                    this.PasswordSaltField = value;
                    this.RaisePropertyChanged("PasswordSalt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Suffix {
            get {
                return this.SuffixField;
            }
            set {
                if ((object.ReferenceEquals(this.SuffixField, value) != true)) {
                    this.SuffixField = value;
                    this.RaisePropertyChanged("Suffix");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid rowguid {
            get {
                return this.rowguidField;
            }
            set {
                if ((this.rowguidField.Equals(value) != true)) {
                    this.rowguidField = value;
                    this.RaisePropertyChanged("rowguid");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AWServiceReference.IEmployeeBoService")]
    public interface IEmployeeBoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeBoService/CreateEmployeeResponse")]
        bool CreateEmployee(ServicePoxry.AWServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/CreateEmployee2", ReplyAction="http://tempuri.org/IEmployeeBoService/CreateEmployee2Response")]
        int CreateEmployee2(ServicePoxry.AWServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/DelEmployee", ReplyAction="http://tempuri.org/IEmployeeBoService/DelEmployeeResponse")]
        bool DelEmployee(ServicePoxry.AWServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/FindEmployeeByTitle", ReplyAction="http://tempuri.org/IEmployeeBoService/FindEmployeeByTitleResponse")]
        ServicePoxry.AWServiceReference.PagedListOfEmployeegSBaJWHs FindEmployeeByTitle(out int totalcount, string title, System.Nullable<int> pageIndex, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeBoService/GetEmployeeResponse")]
        ServicePoxry.AWServiceReference.Employee GetEmployee(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeBoService/UpdateEmployeeResponse")]
        bool UpdateEmployee(ServicePoxry.AWServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeBoService/GetPagedListContact", ReplyAction="http://tempuri.org/IEmployeeBoService/GetPagedListContactResponse")]
        ServicePoxry.AWServiceReference.PagedListOfContactgSBaJWHs GetPagedListContact(out int totalcount, System.Nullable<int> pageIndex, int pageSize);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeBoServiceChannel : ServicePoxry.AWServiceReference.IEmployeeBoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeBoServiceClient : System.ServiceModel.ClientBase<ServicePoxry.AWServiceReference.IEmployeeBoService>, ServicePoxry.AWServiceReference.IEmployeeBoService {
        
        public EmployeeBoServiceClient() {
        }
        
        public EmployeeBoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeBoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeBoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeBoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateEmployee(ServicePoxry.AWServiceReference.Employee employee) {
            return base.Channel.CreateEmployee(employee);
        }
        
        public int CreateEmployee2(ServicePoxry.AWServiceReference.Employee employee) {
            return base.Channel.CreateEmployee2(employee);
        }
        
        public bool DelEmployee(ServicePoxry.AWServiceReference.Employee employee) {
            return base.Channel.DelEmployee(employee);
        }
        
        public ServicePoxry.AWServiceReference.PagedListOfEmployeegSBaJWHs FindEmployeeByTitle(out int totalcount, string title, System.Nullable<int> pageIndex, int pageSize) {
            return base.Channel.FindEmployeeByTitle(out totalcount, title, pageIndex, pageSize);
        }
        
        public ServicePoxry.AWServiceReference.Employee GetEmployee(int pid) {
            return base.Channel.GetEmployee(pid);
        }
        
        public bool UpdateEmployee(ServicePoxry.AWServiceReference.Employee employee) {
            return base.Channel.UpdateEmployee(employee);
        }
        
        public ServicePoxry.AWServiceReference.PagedListOfContactgSBaJWHs GetPagedListContact(out int totalcount, System.Nullable<int> pageIndex, int pageSize) {
            return base.Channel.GetPagedListContact(out totalcount, pageIndex, pageSize);
        }
    }
}
