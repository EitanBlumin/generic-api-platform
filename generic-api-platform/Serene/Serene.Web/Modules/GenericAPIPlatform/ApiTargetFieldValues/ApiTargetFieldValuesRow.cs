
namespace Serene.GenericAPIPlatform.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("GenericAPIPlatform"), Module("GenericAPIPlatform"), TableName("[dbo].[api_TargetFieldValues]")]
    [DisplayName("Api Target Field Values"), InstanceName("Api Target Field Values")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ApiTargetFieldValuesRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Target"), Column("TargetID"), NotNull, ForeignKey("[dbo].[api_Target]", "ID"), LeftJoin("jTarget"), TextualField("TargetTargetName")]
        public Int32? TargetId
        {
            get { return Fields.TargetId[this]; }
            set { Fields.TargetId[this] = value; }
        }

        [DisplayName("Field Name"), Size(100), NotNull, QuickSearch]
        public String FieldName
        {
            get { return Fields.FieldName[this]; }
            set { Fields.FieldName[this] = value; }
        }

        [DisplayName("Field Value"), Size(4000), NotNull]
        public String FieldValue
        {
            get { return Fields.FieldValue[this]; }
            set { Fields.FieldValue[this] = value; }
        }

        [DisplayName("Target Api Type Id"), Expression("jTarget.[APITypeID]")]
        public Int32? TargetApiTypeId
        {
            get { return Fields.TargetApiTypeId[this]; }
            set { Fields.TargetApiTypeId[this] = value; }
        }

        [DisplayName("Target Target Name"), Expression("jTarget.[TargetName]")]
        public String TargetTargetName
        {
            get { return Fields.TargetTargetName[this]; }
            set { Fields.TargetTargetName[this] = value; }
        }

        [DisplayName("Target Target Description"), Expression("jTarget.[TargetDescription]")]
        public String TargetTargetDescription
        {
            get { return Fields.TargetTargetDescription[this]; }
            set { Fields.TargetTargetDescription[this] = value; }
        }

        [DisplayName("Target Enabled"), Expression("jTarget.[Enabled]")]
        public Boolean? TargetEnabled
        {
            get { return Fields.TargetEnabled[this]; }
            set { Fields.TargetEnabled[this] = value; }
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

        public ApiTargetFieldValuesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field TargetId;
            public StringField FieldName;
            public StringField FieldValue;

            public Int32Field TargetApiTypeId;
            public StringField TargetTargetName;
            public StringField TargetTargetDescription;
            public BooleanField TargetEnabled;
        }
    }
}
