
namespace Serene.GenericAPIPlatform.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("GenericAPIPlatform"), Module("GenericAPIPlatform"), TableName("[dbo].[api_Type]")]
    [DisplayName("Api Type"), InstanceName("Api Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ApiTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Api Name"), Column("APIName"), Size(100), NotNull, QuickSearch]
        public String ApiName
        {
            get { return Fields.ApiName[this]; }
            set { Fields.ApiName[this] = value; }
        }

        [DisplayName("Api Icon"), Column("APIIcon"), Size(100)]
        public String ApiIcon
        {
            get { return Fields.ApiIcon[this]; }
            set { Fields.ApiIcon[this] = value; }
        }

        [DisplayName("Enabled"), NotNull]
        public Boolean? Enabled
        {
            get { return Fields.Enabled[this]; }
            set { Fields.Enabled[this] = value; }
        }

        [DisplayName("Target Uri"), Column("TargetURI"), Size(4000), NotNull]
        public String TargetUri
        {
            get { return Fields.TargetUri[this]; }
            set { Fields.TargetUri[this] = value; }
        }

        [DisplayName("Payload")]
        public String Payload
        {
            get { return Fields.Payload[this]; }
            set { Fields.Payload[this] = value; }
        }

        [DisplayName("Method"), Size(6), NotNull]
        public String Method
        {
            get { return Fields.Method[this]; }
            set { Fields.Method[this] = value; }
        }

        [DisplayName("Alt Target Uri"), Column("Alt_TargetURI"), Size(4000)]
        public String AltTargetUri
        {
            get { return Fields.AltTargetUri[this]; }
            set { Fields.AltTargetUri[this] = value; }
        }

        [DisplayName("Alt Payload"), Column("Alt_Payload")]
        public String AltPayload
        {
            get { return Fields.AltPayload[this]; }
            set { Fields.AltPayload[this] = value; }
        }

        [DisplayName("Alt Method"), Column("Alt_Method"), Size(6)]
        public String AltMethod
        {
            get { return Fields.AltMethod[this]; }
            set { Fields.AltMethod[this] = value; }
        }

        [DisplayName("Auto Close Supported"), NotNull]
        public Boolean? AutoCloseSupported
        {
            get { return Fields.AutoCloseSupported[this]; }
            set { Fields.AutoCloseSupported[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ApiName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ApiTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField ApiName;
            public StringField ApiIcon;
            public BooleanField Enabled;
            public StringField TargetUri;
            public StringField Payload;
            public StringField Method;
            public StringField AltTargetUri;
            public StringField AltPayload;
            public StringField AltMethod;
            public BooleanField AutoCloseSupported;
        }
    }
}
