//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace OpenTrack.Responses {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ServiceLaborOpcodesTable {
        
        private ServiceLaborOpcodesTableServiceLaborOpcodeRecord[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceLaborOpcodeRecord", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceLaborOpcodesTableServiceLaborOpcodeRecord[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ServiceLaborOpcodesTableServiceLaborOpcodeRecord {
        
        private string companyNumberField;
        
        private string operationCodeField;
        
        private string description1Field;
        
        private string description2Field;
        
        private string description3Field;
        
        private string description4Field;
        
        private string majorCodeField;
        
        private string minorCodeField;
        
        private string manufacturerField;
        
        private string makeField;
        
        private string modelField;
        
        private string engineField;
        
        private string yearField;
        
        private string defLinePaymentMethodField;
        
        private string correctionLOPField;
        
        private string typeField;
        
        private string excludeDiscountField;
        
        private string skillLevelField;
        
        private string taxableField;
        
        private string hazardMaterialChargeField;
        
        private string shopSupplyChargeField;
        
        private string retailMethodField;
        
        private string retailAmountField;
        
        private string costMethodField;
        
        private string costAmountField;
        
        private string partsMethodField;
        
        private string partsAmountField;
        
        private string estimateField;
        
        private string estimatedHoursField;
        
        private string waiterFlagField;
        
        private string predefinedCauseDescriptionField;
        
        private string additionalDescriptionLine1Field;
        
        private string additionalDescriptionLine2Field;
        
        private string predefinedComplaintDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyNumber {
            get {
                return this.companyNumberField;
            }
            set {
                this.companyNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperationCode {
            get {
                return this.operationCodeField;
            }
            set {
                this.operationCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description1 {
            get {
                return this.description1Field;
            }
            set {
                this.description1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description2 {
            get {
                return this.description2Field;
            }
            set {
                this.description2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description3 {
            get {
                return this.description3Field;
            }
            set {
                this.description3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description4 {
            get {
                return this.description4Field;
            }
            set {
                this.description4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MajorCode {
            get {
                return this.majorCodeField;
            }
            set {
                this.majorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MinorCode {
            get {
                return this.minorCodeField;
            }
            set {
                this.minorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Make {
            get {
                return this.makeField;
            }
            set {
                this.makeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Engine {
            get {
                return this.engineField;
            }
            set {
                this.engineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DefLinePaymentMethod {
            get {
                return this.defLinePaymentMethodField;
            }
            set {
                this.defLinePaymentMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CorrectionLOP {
            get {
                return this.correctionLOPField;
            }
            set {
                this.correctionLOPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExcludeDiscount {
            get {
                return this.excludeDiscountField;
            }
            set {
                this.excludeDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SkillLevel {
            get {
                return this.skillLevelField;
            }
            set {
                this.skillLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Taxable {
            get {
                return this.taxableField;
            }
            set {
                this.taxableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HazardMaterialCharge {
            get {
                return this.hazardMaterialChargeField;
            }
            set {
                this.hazardMaterialChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ShopSupplyCharge {
            get {
                return this.shopSupplyChargeField;
            }
            set {
                this.shopSupplyChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RetailMethod {
            get {
                return this.retailMethodField;
            }
            set {
                this.retailMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RetailAmount {
            get {
                return this.retailAmountField;
            }
            set {
                this.retailAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CostMethod {
            get {
                return this.costMethodField;
            }
            set {
                this.costMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CostAmount {
            get {
                return this.costAmountField;
            }
            set {
                this.costAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PartsMethod {
            get {
                return this.partsMethodField;
            }
            set {
                this.partsMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PartsAmount {
            get {
                return this.partsAmountField;
            }
            set {
                this.partsAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Estimate {
            get {
                return this.estimateField;
            }
            set {
                this.estimateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EstimatedHours {
            get {
                return this.estimatedHoursField;
            }
            set {
                this.estimatedHoursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WaiterFlag {
            get {
                return this.waiterFlagField;
            }
            set {
                this.waiterFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PredefinedCauseDescription {
            get {
                return this.predefinedCauseDescriptionField;
            }
            set {
                this.predefinedCauseDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AdditionalDescriptionLine1 {
            get {
                return this.additionalDescriptionLine1Field;
            }
            set {
                this.additionalDescriptionLine1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AdditionalDescriptionLine2 {
            get {
                return this.additionalDescriptionLine2Field;
            }
            set {
                this.additionalDescriptionLine2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PredefinedComplaintDescription {
            get {
                return this.predefinedComplaintDescriptionField;
            }
            set {
                this.predefinedComplaintDescriptionField = value;
            }
        }
    }
}
