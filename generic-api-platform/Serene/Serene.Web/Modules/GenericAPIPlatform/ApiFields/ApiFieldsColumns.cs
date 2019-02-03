
namespace Serene.GenericAPIPlatform.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("GenericAPIPlatform.ApiFields")]
    [BasedOnRow(typeof(Entities.ApiFieldsRow), CheckNames = true)]
    public class ApiFieldsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String ApiTypeApiName { get; set; }
        [EditLink]
        public String FieldName { get; set; }
        public String FieldLabel { get; set; }
        public String FieldDataType { get; set; }
        public String FieldDefaultValue { get; set; }
        public Boolean AllowAlertPlaceholders { get; set; }
    }
}