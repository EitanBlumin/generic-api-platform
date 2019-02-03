
namespace Serene.GenericAPIPlatform.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("GenericAPIPlatform.ApiFields")]
    [BasedOnRow(typeof(Entities.ApiFieldsRow), CheckNames = true)]
    public class ApiFieldsForm
    {
        public Int32 ApiTypeId { get; set; }
        public String FieldName { get; set; }
        public String FieldLabel { get; set; }
        public String FieldDataType { get; set; }
        public String FieldDefaultValue { get; set; }
        public Boolean AllowAlertPlaceholders { get; set; }
    }
}