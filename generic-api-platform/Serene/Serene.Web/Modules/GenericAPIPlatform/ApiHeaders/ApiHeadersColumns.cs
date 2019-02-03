
namespace Serene.GenericAPIPlatform.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("GenericAPIPlatform.ApiHeaders")]
    [BasedOnRow(typeof(Entities.ApiHeadersRow), CheckNames = true)]
    public class ApiHeadersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String ApiTypeApiName { get; set; }
        [EditLink]
        public String HeaderName { get; set; }
        public String HeaderValue { get; set; }
        public Boolean AllowPlaceholders { get; set; }
    }
}