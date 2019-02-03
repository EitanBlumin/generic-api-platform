
namespace Serene.GenericAPIPlatform.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("GenericAPIPlatform.ApiTarget")]
    [BasedOnRow(typeof(Entities.ApiTargetRow), CheckNames = true)]
    public class ApiTargetForm
    {
        public Int32 ApiTypeId { get; set; }
        public String TargetName { get; set; }
        public String TargetDescription { get; set; }
        public Boolean Enabled { get; set; }
    }
}