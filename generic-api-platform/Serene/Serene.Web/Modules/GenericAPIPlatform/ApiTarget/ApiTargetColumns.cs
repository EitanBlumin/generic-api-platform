
namespace Serene.GenericAPIPlatform.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("GenericAPIPlatform.ApiTarget")]
    [BasedOnRow(typeof(Entities.ApiTargetRow), CheckNames = true)]
    public class ApiTargetColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String ApiTypeApiName { get; set; }
        [EditLink]
        public String TargetName { get; set; }
        public String TargetDescription { get; set; }
        public Boolean Enabled { get; set; }
    }
}