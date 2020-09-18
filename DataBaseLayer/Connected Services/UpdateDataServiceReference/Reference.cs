﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseLayer.UpdateDataServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UpdateDataServiceReference.IUpdateDataService")]
    public interface IUpdateDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDataService/UpdateComputer", ReplyAction="http://tempuri.org/IUpdateDataService/UpdateComputerResponse")]
        string UpdateComputer(
                    int _id, 
                    string _computerName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate, 
                    byte[] _barcode, 
                    byte[] _qrCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDataService/UpdateComputer", ReplyAction="http://tempuri.org/IUpdateDataService/UpdateComputerResponse")]
        System.Threading.Tasks.Task<string> UpdateComputerAsync(
                    int _id, 
                    string _computerName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate, 
                    byte[] _barcode, 
                    byte[] _qrCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDataService/UpdateNotebooks", ReplyAction="http://tempuri.org/IUpdateDataService/UpdateNotebooksResponse")]
        string UpdateNotebooks(
                    int id, 
                    string _notebooksName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDataService/UpdateNotebooks", ReplyAction="http://tempuri.org/IUpdateDataService/UpdateNotebooksResponse")]
        System.Threading.Tasks.Task<string> UpdateNotebooksAsync(
                    int id, 
                    string _notebooksName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDataService/UpdateMonitors", ReplyAction="http://tempuri.org/IUpdateDataService/UpdateMonitorsResponse")]
        string UpdateMonitors(int _id, string _companyFixedAsset, string _tagService, string _location, string _user, string _model, string _coments, System.DateTime purchaseDate, System.DateTime warrantyDate, byte[] _barcode, byte[] _qrCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateDataService/UpdateMonitors", ReplyAction="http://tempuri.org/IUpdateDataService/UpdateMonitorsResponse")]
        System.Threading.Tasks.Task<string> UpdateMonitorsAsync(int _id, string _companyFixedAsset, string _tagService, string _location, string _user, string _model, string _coments, System.DateTime purchaseDate, System.DateTime warrantyDate, byte[] _barcode, byte[] _qrCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUpdateDataServiceChannel : DataBaseLayer.UpdateDataServiceReference.IUpdateDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdateDataServiceClient : System.ServiceModel.ClientBase<DataBaseLayer.UpdateDataServiceReference.IUpdateDataService>, DataBaseLayer.UpdateDataServiceReference.IUpdateDataService {
        
        public UpdateDataServiceClient() {
        }
        
        public UpdateDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UpdateDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdateDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdateDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string UpdateComputer(
                    int _id, 
                    string _computerName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate, 
                    byte[] _barcode, 
                    byte[] _qrCode) {
            return base.Channel.UpdateComputer(_id, _computerName, _operatingSystem, _companyFixedAsset, _tagService, _location, _user, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, purchaseDate, warrantyDate, _barcode, _qrCode);
        }
        
        public System.Threading.Tasks.Task<string> UpdateComputerAsync(
                    int _id, 
                    string _computerName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate, 
                    byte[] _barcode, 
                    byte[] _qrCode) {
            return base.Channel.UpdateComputerAsync(_id, _computerName, _operatingSystem, _companyFixedAsset, _tagService, _location, _user, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, purchaseDate, warrantyDate, _barcode, _qrCode);
        }
        
        public string UpdateNotebooks(
                    int id, 
                    string _notebooksName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate) {
            return base.Channel.UpdateNotebooks(id, _notebooksName, _operatingSystem, _companyFixedAsset, _tagService, _location, _user, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, purchaseDate, warrantyDate);
        }
        
        public System.Threading.Tasks.Task<string> UpdateNotebooksAsync(
                    int id, 
                    string _notebooksName, 
                    string _operatingSystem, 
                    string _companyFixedAsset, 
                    string _tagService, 
                    string _location, 
                    string _user, 
                    string _office, 
                    string _ip, 
                    string _model, 
                    string _cpu, 
                    string _ram, 
                    string _hardDrive, 
                    string _coments, 
                    System.DateTime purchaseDate, 
                    System.DateTime warrantyDate) {
            return base.Channel.UpdateNotebooksAsync(id, _notebooksName, _operatingSystem, _companyFixedAsset, _tagService, _location, _user, _office, _ip, _model, _cpu, _ram, _hardDrive, _coments, purchaseDate, warrantyDate);
        }
        
        public string UpdateMonitors(int _id, string _companyFixedAsset, string _tagService, string _location, string _user, string _model, string _coments, System.DateTime purchaseDate, System.DateTime warrantyDate, byte[] _barcode, byte[] _qrCode) {
            return base.Channel.UpdateMonitors(_id, _companyFixedAsset, _tagService, _location, _user, _model, _coments, purchaseDate, warrantyDate, _barcode, _qrCode);
        }
        
        public System.Threading.Tasks.Task<string> UpdateMonitorsAsync(int _id, string _companyFixedAsset, string _tagService, string _location, string _user, string _model, string _coments, System.DateTime purchaseDate, System.DateTime warrantyDate, byte[] _barcode, byte[] _qrCode) {
            return base.Channel.UpdateMonitorsAsync(_id, _companyFixedAsset, _tagService, _location, _user, _model, _coments, purchaseDate, warrantyDate, _barcode, _qrCode);
        }
    }
}
