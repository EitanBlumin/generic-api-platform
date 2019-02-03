
namespace Serene.GenericAPIPlatform {
    export class ApiFieldsForm extends Serenity.PrefixedContext {
        static formKey = 'GenericAPIPlatform.ApiFields';
    }

    export interface ApiFieldsForm {
        ApiTypeId: Serenity.IntegerEditor;
        FieldName: Serenity.StringEditor;
        FieldLabel: Serenity.StringEditor;
        FieldDataType: Serenity.StringEditor;
        FieldDefaultValue: Serenity.StringEditor;
        AllowAlertPlaceholders: Serenity.BooleanEditor;
    }

    [,
        ['ApiTypeId', () => Serenity.IntegerEditor],
        ['FieldName', () => Serenity.StringEditor],
        ['FieldLabel', () => Serenity.StringEditor],
        ['FieldDataType', () => Serenity.StringEditor],
        ['FieldDefaultValue', () => Serenity.StringEditor],
        ['AllowAlertPlaceholders', () => Serenity.BooleanEditor]
    ].forEach(x => Object.defineProperty(ApiFieldsForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}