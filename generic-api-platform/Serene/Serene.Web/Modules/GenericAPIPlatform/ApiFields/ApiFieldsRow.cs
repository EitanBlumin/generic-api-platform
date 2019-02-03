
namespace Serene.GenericAPIPlatform.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("GenericAPIPlatform"), Module("GenericAPIPlatform"), TableName("[dbo].[api_Fields]")]
    [DisplayName("Api Fields"), InstanceName("Api Fields")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ApiFieldsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Api Type"), Column("APITypeID"), NotNull, ForeignKey("[dbo].[api_Type]", "ID"), LeftJoin("jApiType"), TextualField("ApiTypeApiName")]
        public Int32? ApiTypeId
        {
            get { return Fields.ApiTypeId[this]; }
            set { Fields.ApiTypeId[this] = value; }
        }

        [DisplayName("Field Name"), Size(100), NotNull, QuickSearch]
        public String FieldName
        {
            get { return Fields.FieldName[this]; }
            set { Fields.FieldName[this] = value; }
        }

        [DisplayName("Field Label"), Size(1000), NotNull]
        public String FieldLabel
        {
            get { return Fields.FieldLabel[this]; }
            set { Fields.FieldLabel[this] = value; }
        }

        [DisplayName("Field Data Type"), Size(100), NotNull]
        public String FieldDataType
        {
            get { return Fields.FieldDataType[this]; }
            set { Fields.FieldDataType[this] = value; }
        }

        [DisplayName("Field Default Value"), Size(4000)]
        public String FieldDefaultValue
        {
            get { return Fields.FieldDefaultValue[this]; }
            set { Fields.FieldDefaultValue[this] = value; }
        }

        [DisplayName("Allow Alert Placeholders"), NotNull]
        public Boolean? AllowAlertPlaceholders
        {
            get { return Fields.AllowAlertPlaceholders[this]; }
            set { Fields.AllowAlertPlaceholders[this] = value; }
        }

        [DisplayName("Api Type Api Name"), Expression("jApiType.[APIName]")]
        public String ApiTypeApiName
        {
            get { return Fields.ApiTypeApiName[this]; }
            set { Fields.ApiTypeApiName[this] = value; }
        }

        [DisplayName("Api Type Api Icon"), Expression("jApiType.[APIIcon]")]
        public String ApiTypeApiIcon
        {
            get { return Fields.ApiTypeApiIcon[this]; }
            set { Fields.ApiTypeApiIcon[this] = value; }
        }

        [DisplayName("Api Type Enabled"), Expression("jApiType.[Enabled]")]
        public Boolean? ApiTypeEnabled
        {
            get { return Fields.ApiTypeEnabled[this]; }
            set { Fields.ApiTypeEnabled[this] = value; }
        }

        [DisplayName("Api Type Target Uri"), Expression("jApiType.[TargetURI]")]
        public String ApiTypeTargetUri
        {
            get { return Fields.ApiTypeTargetUri[this]; }
            set { Fields.ApiTypeTargetUri[this] = value; }
        }

        [DisplayName("Api Type Payload"), Expression("jApiType.[Payload]")]
        public String ApiTypePayload
        {
            get { return Fields.ApiTypePayload[this]; }
            set { Fields.ApiTypePayload[this] = value; }
        }

        [DisplayName("Api Type Method"), Expression("jApiType.[Method]")]
        public String ApiTypeMethod
        {
            get { return Fields.ApiTypeMethod[this]; }
            set { Fields.ApiTypeMethod[this] = value; }
        }

        [DisplayName("Api Type Alt Target Uri"), Expression("jApiType.[Alt_TargetURI]")]
        public String ApiTypeAltTargetUri
        {
            get { return Fields.ApiTypeAltTargetUri[this]; }
            set { Fields.ApiTypeAltTargetUri[this] = value; }
        }

        [DisplayName("Api Type Alt Payload"), Expression("jApiType.[Alt_Payload]")]
        public String ApiTypeAltPayload
        {
            get { return Fields.ApiTypeAltPayload[this]; }
            set { Fields.ApiTypeAltPayload[this] = value; }
        }

        [DisplayName("Api Type Alt Method"), Expression("jApiType.[Alt_Method]")]
        public String ApiTypeAltMethod
        {
            get { return Fields.ApiTypeAltMethod[this]; }
            set { Fields.ApiTypeAltMethod[this] = value; }
        }

        [DisplayName("Api Type Auto Close Supported"), Expression("jApiType.[AutoCloseSupported]")]
        public Boolean? ApiTypeAutoCloseSupported
        {
            get { return Fields.ApiTypeAutoCloseSupported[this]; }
            set { Fields.ApiTypeAutoCloseSupported[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FieldName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ApiFieldsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field ApiTypeId;
            public StringField FieldName;
            public StringField FieldLabel;
            public StringField FieldDataType;
            public StringField FieldDefaultValue;
            public BooleanField AllowAlertPlaceholders;

            public StringField ApiTypeApiName;
            public StringField ApiTypeApiIcon;
            public BooleanField ApiTypeEnabled;
            public StringField ApiTypeTargetUri;
            public StringField ApiTypePayload;
            public StringField ApiTypeMethod;
            public StringField ApiTypeAltTargetUri;
            public StringField ApiTypeAltPayload;
            public StringField ApiTypeAltMethod;
            public BooleanField ApiTypeAutoCloseSupported;
        }
    }
}
