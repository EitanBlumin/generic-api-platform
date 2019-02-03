
namespace Serene.GenericAPIPlatform.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("GenericAPIPlatform.ApiTargetFieldValues")]
    [BasedOnRow(typeof(Entities.ApiTargetFieldValuesRow), CheckNames = true)]
    public class ApiTargetFieldValuesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String TargetTargetName { get; set; }
        [EditLink]
        public String FieldName { get; set; }
        public String FieldValue { get; set; }
    }
}