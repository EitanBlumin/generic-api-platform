
namespace Serene.GenericAPIPlatform.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("GenericAPIPlatform.ApiType")]
    [BasedOnRow(typeof(Entities.ApiTypeRow), CheckNames = true)]
    public class ApiTypeForm
    {
        public String ApiName { get; set; }
        public String ApiIcon { get; set; }
        public Boolean Enabled { get; set; }
        public String TargetUri { get; set; }
        public String Payload { get; set; }
        public String Method { get; set; }
        public String AltTargetUri { get; set; }
        public String AltPayload { get; set; }
        public String AltMethod { get; set; }
        public Boolean AutoCloseSupported { get; set; }
    }
}