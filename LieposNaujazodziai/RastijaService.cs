﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://liepa.rastija.lt", ClrNamespace="liepa.rastija.lt")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("", ClrNamespace="")]

namespace liepa.rastija.lt
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NaujazodisRastija", Namespace="http://liepa.rastija.lt")]
    public partial class NaujazodisRastija : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<int> ArticleIdField;
        
        private System.DateTime AtnaujinimoDataField;
        
        private int IdField;
        
        private int XmlIdField;
        
        private string ZodisField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ArticleId
        {
            get
            {
                return this.ArticleIdField;
            }
            set
            {
                this.ArticleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AtnaujinimoData
        {
            get
            {
                return this.AtnaujinimoDataField;
            }
            set
            {
                this.AtnaujinimoDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int XmlId
        {
            get
            {
                return this.XmlIdField;
            }
            set
            {
                this.XmlIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zodis
        {
            get
            {
                return this.ZodisField;
            }
            set
            {
                this.ZodisField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    //[System.Runtime.Serialization.CollectionDataContractAttribute(Name="GetItemResult", Namespace="http://liepa.rastija.lt", ItemName="Naujazodis")]  //Origs
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name = "GetItemResult", Namespace = "", ItemName = "Naujazodis")]
    public class GetItemResult : System.Collections.Generic.List<liepa.rastija.lt.Naujazodis>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    //[System.Runtime.Serialization.DataContractAttribute(Name="Naujazodis", Namespace="http://liepa.rastija.lt")]  //Orig
    [System.Runtime.Serialization.DataContractAttribute(Name = "Naujazodis", Namespace = "")]
    public partial class Naujazodis : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private ushort Zodzio_idField;
        
        private ushort RodomasField;
        
        private ushort SkolinysField;
        
        private string Sarasine_formaField;
        
        private string Pagrindine_formaField;
        
        private string Antra_formaField;
        
        private string Trecia_formaField;
        
        private System.Nullable<ushort> Pagrindines_formos_garso_idField;
        
        private string Pagrindines_formos_garso_failasField;
        
        private System.Nullable<ushort> Antros_formos_garso_idField;
        
        private string Antros_formos_garso_failasField;
        
        private System.Nullable<ushort> Trecios_formos_garso_idField;
        
        private string Trecios_formos_garso_failasField;
        
        private string RusisField;
        
        private string Kalbos_dalis_1Field;
        
        private string Kalbos_dalis_2Field;
        
        private string KirciuoteField;
        
        private string KilmeField;
        
        private string Originali_formaField;
        
        private ArrayOfNaujazodisGiminiskas_zodis Giminiski_zodziaiField;
        
        private string Papildoma_informacijaField;
        
        private ArrayOfNaujazodisReiksme ReiksmesField;
        
        private string PateiktaField;
        
        private string AtnaujintaField;
        
        private string Pateikta_skoliniuiField;
        
        private string Atnaujinta_skoliniuiField;
        
        private ArrayOfNaujazodisGarsas_pavyzdziuose Garsai_pavyzdziuoseField;
        
        private byte[] Pagrindines_formos_garso_failasBytesField;
        
        private byte[] Antros_formos_garso_failasBytesField;
        
        private byte[] Trecios_formos_garso_failasBytesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public ushort Zodzio_id
        {
            get
            {
                return this.Zodzio_idField;
            }
            set
            {
                this.Zodzio_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public ushort Rodomas
        {
            get
            {
                return this.RodomasField;
            }
            set
            {
                this.RodomasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public ushort Skolinys
        {
            get
            {
                return this.SkolinysField;
            }
            set
            {
                this.SkolinysField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Sarasine_forma
        {
            get
            {
                return this.Sarasine_formaField;
            }
            set
            {
                this.Sarasine_formaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Pagrindine_forma
        {
            get
            {
                return this.Pagrindine_formaField;
            }
            set
            {
                this.Pagrindine_formaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Antra_forma
        {
            get
            {
                return this.Antra_formaField;
            }
            set
            {
                this.Antra_formaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Trecia_forma
        {
            get
            {
                return this.Trecia_formaField;
            }
            set
            {
                this.Trecia_formaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<ushort> Pagrindines_formos_garso_id
        {
            get
            {
                return this.Pagrindines_formos_garso_idField;
            }
            set
            {
                this.Pagrindines_formos_garso_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Pagrindines_formos_garso_failas
        {
            get
            {
                return this.Pagrindines_formos_garso_failasField;
            }
            set
            {
                this.Pagrindines_formos_garso_failasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public System.Nullable<ushort> Antros_formos_garso_id
        {
            get
            {
                return this.Antros_formos_garso_idField;
            }
            set
            {
                this.Antros_formos_garso_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string Antros_formos_garso_failas
        {
            get
            {
                return this.Antros_formos_garso_failasField;
            }
            set
            {
                this.Antros_formos_garso_failasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public System.Nullable<ushort> Trecios_formos_garso_id
        {
            get
            {
                return this.Trecios_formos_garso_idField;
            }
            set
            {
                this.Trecios_formos_garso_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string Trecios_formos_garso_failas
        {
            get
            {
                return this.Trecios_formos_garso_failasField;
            }
            set
            {
                this.Trecios_formos_garso_failasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string Rusis
        {
            get
            {
                return this.RusisField;
            }
            set
            {
                this.RusisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string Kalbos_dalis_1
        {
            get
            {
                return this.Kalbos_dalis_1Field;
            }
            set
            {
                this.Kalbos_dalis_1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string Kalbos_dalis_2
        {
            get
            {
                return this.Kalbos_dalis_2Field;
            }
            set
            {
                this.Kalbos_dalis_2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string Kirciuote
        {
            get
            {
                return this.KirciuoteField;
            }
            set
            {
                this.KirciuoteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string Kilme
        {
            get
            {
                return this.KilmeField;
            }
            set
            {
                this.KilmeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public string Originali_forma
        {
            get
            {
                return this.Originali_formaField;
            }
            set
            {
                this.Originali_formaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public ArrayOfNaujazodisGiminiskas_zodis Giminiski_zodziai
        {
            get
            {
                return this.Giminiski_zodziaiField;
            }
            set
            {
                this.Giminiski_zodziaiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
        public string Papildoma_informacija
        {
            get
            {
                return this.Papildoma_informacijaField;
            }
            set
            {
                this.Papildoma_informacijaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=21)]
        public ArrayOfNaujazodisReiksme Reiksmes
        {
            get
            {
                return this.ReiksmesField;
            }
            set
            {
                this.ReiksmesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=22)]
        public string Pateikta
        {
            get
            {
                return this.PateiktaField;
            }
            set
            {
                this.PateiktaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=23)]
        public string Atnaujinta
        {
            get
            {
                return this.AtnaujintaField;
            }
            set
            {
                this.AtnaujintaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=24)]
        public string Pateikta_skoliniui
        {
            get
            {
                return this.Pateikta_skoliniuiField;
            }
            set
            {
                this.Pateikta_skoliniuiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=25)]
        public string Atnaujinta_skoliniui
        {
            get
            {
                return this.Atnaujinta_skoliniuiField;
            }
            set
            {
                this.Atnaujinta_skoliniuiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=26)]
        public ArrayOfNaujazodisGarsas_pavyzdziuose Garsai_pavyzdziuose
        {
            get
            {
                return this.Garsai_pavyzdziuoseField;
            }
            set
            {
                this.Garsai_pavyzdziuoseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=27)]
        public byte[] Pagrindines_formos_garso_failasBytes
        {
            get
            {
                return this.Pagrindines_formos_garso_failasBytesField;
            }
            set
            {
                this.Pagrindines_formos_garso_failasBytesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=28)]
        public byte[] Antros_formos_garso_failasBytes
        {
            get
            {
                return this.Antros_formos_garso_failasBytesField;
            }
            set
            {
                this.Antros_formos_garso_failasBytesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=29)]
        public byte[] Trecios_formos_garso_failasBytes
        {
            get
            {
                return this.Trecios_formos_garso_failasBytesField;
            }
            set
            {
                this.Trecios_formos_garso_failasBytesField = value;
            }
        }
    }
}


[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfNaujazodisGiminiskas_zodis", Namespace="", ItemName="Giminiskas_zodis")]
public class ArrayOfNaujazodisGiminiskas_zodis : System.Collections.Generic.List<Giminiskas_zodis>
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfNaujazodisReiksme", Namespace="", ItemName="Reiksme")]
public class ArrayOfNaujazodisReiksme : System.Collections.Generic.List<Reiksme>
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfNaujazodisGarsas_pavyzdziuose", Namespace="", ItemName="Garsas_pavyzdziuose")]
public class ArrayOfNaujazodisGarsas_pavyzdziuose : System.Collections.Generic.List<Garsas_pavyzdziuose>
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="Giminiskas_zodis", Namespace="")]
public partial class Giminiskas_zodis : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private System.Nullable<ushort> Giminisko_zodzio_idField;
    
    private string Giminisko_zodzio_tekstasField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Giminisko_zodzio_id
    {
        get
        {
            return this.Giminisko_zodzio_idField;
        }
        set
        {
            this.Giminisko_zodzio_idField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
    public string Giminisko_zodzio_tekstas
    {
        get
        {
            return this.Giminisko_zodzio_tekstasField;
        }
        set
        {
            this.Giminisko_zodzio_tekstasField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="Reiksme", Namespace="")]
public partial class Reiksme : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private System.Nullable<ushort> Reiksmes_idField;
    
    private System.Nullable<ushort> Reiksmes_nrField;
    
    private string Reiksmes_apibreztisField;
    
    private ArrayOfString Reiksmes_vartojimo_sritysField;
    
    private ArrayOfNaujazodisReiksmeReiksmes_variantas Reiksmes_variantaiField;
    
    private ArrayOfNaujazodisReiksmeReiksmes_sasaja Reiksmes_sasajosField;
    
    private string Vaizdo_failasField;
    
    private string Tekstas_vaizduiField;
    
    private string Naujazodzio_vartosenos_pavyzdziaiField;
    
    private string Skolinio_vartosenos_pavyzdziaiField;
    
    private string Pastabos_vartotojamsField;
    
    private string Pastabos_skoliniuiField;
    
    private byte[] Vaizdo_failasBytesField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Reiksmes_id
    {
        get
        {
            return this.Reiksmes_idField;
        }
        set
        {
            this.Reiksmes_idField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Reiksmes_nr
    {
        get
        {
            return this.Reiksmes_nrField;
        }
        set
        {
            this.Reiksmes_nrField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public string Reiksmes_apibreztis
    {
        get
        {
            return this.Reiksmes_apibreztisField;
        }
        set
        {
            this.Reiksmes_apibreztisField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
    public ArrayOfString Reiksmes_vartojimo_sritys
    {
        get
        {
            return this.Reiksmes_vartojimo_sritysField;
        }
        set
        {
            this.Reiksmes_vartojimo_sritysField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
    public ArrayOfNaujazodisReiksmeReiksmes_variantas Reiksmes_variantai
    {
        get
        {
            return this.Reiksmes_variantaiField;
        }
        set
        {
            this.Reiksmes_variantaiField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
    public ArrayOfNaujazodisReiksmeReiksmes_sasaja Reiksmes_sasajos
    {
        get
        {
            return this.Reiksmes_sasajosField;
        }
        set
        {
            this.Reiksmes_sasajosField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
    public string Vaizdo_failas
    {
        get
        {
            return this.Vaizdo_failasField;
        }
        set
        {
            this.Vaizdo_failasField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
    public string Tekstas_vaizdui
    {
        get
        {
            return this.Tekstas_vaizduiField;
        }
        set
        {
            this.Tekstas_vaizduiField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
    public string Naujazodzio_vartosenos_pavyzdziai
    {
        get
        {
            return this.Naujazodzio_vartosenos_pavyzdziaiField;
        }
        set
        {
            this.Naujazodzio_vartosenos_pavyzdziaiField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
    public string Skolinio_vartosenos_pavyzdziai
    {
        get
        {
            return this.Skolinio_vartosenos_pavyzdziaiField;
        }
        set
        {
            this.Skolinio_vartosenos_pavyzdziaiField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
    public string Pastabos_vartotojams
    {
        get
        {
            return this.Pastabos_vartotojamsField;
        }
        set
        {
            this.Pastabos_vartotojamsField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
    public string Pastabos_skoliniui
    {
        get
        {
            return this.Pastabos_skoliniuiField;
        }
        set
        {
            this.Pastabos_skoliniuiField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
    public byte[] Vaizdo_failasBytes
    {
        get
        {
            return this.Vaizdo_failasBytesField;
        }
        set
        {
            this.Vaizdo_failasBytesField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="", ItemName="Reiksmes_vartojimo_sritis")]
public class ArrayOfString : System.Collections.Generic.List<string>
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfNaujazodisReiksmeReiksmes_variantas", Namespace="", ItemName="Reiksmes_variantas")]
public class ArrayOfNaujazodisReiksmeReiksmes_variantas : System.Collections.Generic.List<Reiksmes_variantas>
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfNaujazodisReiksmeReiksmes_sasaja", Namespace="", ItemName="Reiksmes_sasaja")]
public class ArrayOfNaujazodisReiksmeReiksmes_sasaja : System.Collections.Generic.List<Reiksmes_sasaja>
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="Reiksmes_variantas", Namespace="")]
public partial class Reiksmes_variantas : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private System.Nullable<ushort> Varianto_zodzio_idField;
    
    private System.Nullable<ushort> Varianto_reiksmes_nrField;
    
    private string Varianto_zodzio_tekstasField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Varianto_zodzio_id
    {
        get
        {
            return this.Varianto_zodzio_idField;
        }
        set
        {
            this.Varianto_zodzio_idField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
    public System.Nullable<ushort> Varianto_reiksmes_nr
    {
        get
        {
            return this.Varianto_reiksmes_nrField;
        }
        set
        {
            this.Varianto_reiksmes_nrField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public string Varianto_zodzio_tekstas
    {
        get
        {
            return this.Varianto_zodzio_tekstasField;
        }
        set
        {
            this.Varianto_zodzio_tekstasField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="Reiksmes_sasaja", Namespace="")]
public partial class Reiksmes_sasaja : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private System.Nullable<ushort> Sasajos_zodzio_idField;
    
    private System.Nullable<ushort> Sasajos_zodzio_reiksmes_nrField;
    
    private string Sasajos_zodzio_tekstasField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Sasajos_zodzio_id
    {
        get
        {
            return this.Sasajos_zodzio_idField;
        }
        set
        {
            this.Sasajos_zodzio_idField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Sasajos_zodzio_reiksmes_nr
    {
        get
        {
            return this.Sasajos_zodzio_reiksmes_nrField;
        }
        set
        {
            this.Sasajos_zodzio_reiksmes_nrField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
    public string Sasajos_zodzio_tekstas
    {
        get
        {
            return this.Sasajos_zodzio_tekstasField;
        }
        set
        {
            this.Sasajos_zodzio_tekstasField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="Garsas_pavyzdziuose", Namespace="")]
public partial class Garsas_pavyzdziuose : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private System.Nullable<ushort> Garso_pavyzdziuose_idField;
    
    private string Garso_pavyzdziuose_failasField;
    
    private string Igarsintas_tekstasField;
    
    private byte[] Garso_pavyzdziuose_failasBytesField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
    public System.Nullable<ushort> Garso_pavyzdziuose_id
    {
        get
        {
            return this.Garso_pavyzdziuose_idField;
        }
        set
        {
            this.Garso_pavyzdziuose_idField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
    public string Garso_pavyzdziuose_failas
    {
        get
        {
            return this.Garso_pavyzdziuose_failasField;
        }
        set
        {
            this.Garso_pavyzdziuose_failasField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public string Igarsintas_tekstas
    {
        get
        {
            return this.Igarsintas_tekstasField;
        }
        set
        {
            this.Igarsintas_tekstasField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
    public byte[] Garso_pavyzdziuose_failasBytes
    {
        get
        {
            return this.Garso_pavyzdziuose_failasBytesField;
        }
        set
        {
            this.Garso_pavyzdziuose_failasBytesField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://liepa.rastija.lt", ConfigurationName="IRastijaService")]
public interface IRastijaService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://liepa.rastija.lt/IRastijaService/GetList", ReplyAction="http://liepa.rastija.lt/IRastijaService/GetListResponse")]
    liepa.rastija.lt.NaujazodisRastija[] GetList(System.Nullable<System.DateTime> atnaujinimoDataNuo);
    
    // CODEGEN: Generating message contract since element name GetItemResult from namespace http://liepa.rastija.lt is not marked nillable
    [System.ServiceModel.OperationContractAttribute(Action="http://liepa.rastija.lt/IRastijaService/GetItem", ReplyAction="http://liepa.rastija.lt/IRastijaService/GetItemResponse")]
    GetItemResponse GetItem(GetItemRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetItemRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItem", Namespace="http://liepa.rastija.lt", Order=0)]
    public GetItemRequestBody Body;
    
    public GetItemRequest()
    {
    }
    
    public GetItemRequest(GetItemRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://liepa.rastija.lt")]
public partial class GetItemRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public int xmlId;
    
    public GetItemRequestBody()
    {
    }
    
    public GetItemRequestBody(int xmlId)
    {
        this.xmlId = xmlId;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetItemResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemResponse", Namespace="http://liepa.rastija.lt", Order=0)]
    public GetItemResponseBody Body;
    
    public GetItemResponse()
    {
    }
    
    public GetItemResponse(GetItemResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://liepa.rastija.lt")]
public partial class GetItemResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
    public liepa.rastija.lt.GetItemResult GetItemResult;
    
    public GetItemResponseBody()
    {
    }
    
    public GetItemResponseBody(liepa.rastija.lt.GetItemResult GetItemResult)
    {
        this.GetItemResult = GetItemResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IRastijaServiceChannel : IRastijaService, System.ServiceModel.IClientChannel
{
}

//[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class RastijaServiceClient : System.ServiceModel.ClientBase<IRastijaService>, IRastijaService
{
    
    public RastijaServiceClient()
    {
    }
    
    public RastijaServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public RastijaServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RastijaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RastijaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public liepa.rastija.lt.NaujazodisRastija[] GetList(System.Nullable<System.DateTime> atnaujinimoDataNuo)
    {
        return base.Channel.GetList(atnaujinimoDataNuo);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetItemResponse IRastijaService.GetItem(GetItemRequest request)
    {
        return base.Channel.GetItem(request);
    }
    
    public liepa.rastija.lt.GetItemResult GetItem(int xmlId)
    {
        GetItemRequest inValue = new GetItemRequest();
        inValue.Body = new GetItemRequestBody();
        inValue.Body.xmlId = xmlId;
        GetItemResponse retVal = ((IRastijaService)(this)).GetItem(inValue);
        return retVal.Body.GetItemResult;
    }
}