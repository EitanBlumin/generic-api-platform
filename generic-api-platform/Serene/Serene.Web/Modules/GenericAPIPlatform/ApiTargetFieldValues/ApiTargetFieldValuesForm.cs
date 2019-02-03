
namespace Serene.GenericAPIPlatform.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("GenericAPIPlatform.ApiTargetFieldValues")]
    [BasedOnRow(typeof(Entities.ApiTargetFieldValuesRow), CheckNames = true)]
    public class ApiTargetFieldValuesForm
    {
        public Int32 TargetId { get; set; }
        public String FieldName { get; set; }
        public String FieldValue { get; set; }
    }
}