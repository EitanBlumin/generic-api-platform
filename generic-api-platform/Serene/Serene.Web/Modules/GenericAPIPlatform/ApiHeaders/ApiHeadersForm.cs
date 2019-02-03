
namespace Serene.GenericAPIPlatform.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("GenericAPIPlatform.ApiHeaders")]
    [BasedOnRow(typeof(Entities.ApiHeadersRow), CheckNames = true)]
    public class ApiHeadersForm
    {
        public Int32 ApiTypeId { get; set; }
        public String HeaderName { get; set; }
        public String HeaderValue { get; set; }
        public Boolean AllowPlaceholders { get; set; }
    }
}