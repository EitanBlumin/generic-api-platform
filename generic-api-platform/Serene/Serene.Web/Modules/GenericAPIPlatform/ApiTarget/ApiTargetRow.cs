
namespace Serene.GenericAPIPlatform.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("GenericAPIPlatform"), Module("GenericAPIPlatform"), TableName("[dbo].[api_Target]")]
    [DisplayName("Api Target"), InstanceName("Api Target")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ApiTargetRow : Row, IIdRow, INameRow
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

        [DisplayName("Target Name"), Size(255), NotNull, QuickSearch]
        public String TargetName
        {
            get { return Fields.TargetName[this]; }
            set { Fields.TargetName[this] = value; }
        }

        [DisplayName("Target Description"), Size(4000)]
        public String TargetDescription
        {
            get { return Fields.TargetDescription[this]; }
            set { Fields.TargetDescription[this] = value; }
        }

        [DisplayName("Enabled"), NotNull]
        public Boolean? Enabled
        {
            get { return Fields.Enabled[this]; }
            set { Fields.Enabled[this] = value; }
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
            get { return Fields.TargetName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ApiTargetRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field ApiTypeId;
            public StringField TargetName;
            public StringField TargetDescription;
            public BooleanField Enabled;

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
