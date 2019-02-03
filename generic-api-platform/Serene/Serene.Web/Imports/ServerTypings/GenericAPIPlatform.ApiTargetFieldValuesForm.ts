
namespace Serene.GenericAPIPlatform {
    export class ApiTargetFieldValuesForm extends Serenity.PrefixedContext {
        static formKey = 'GenericAPIPlatform.ApiTargetFieldValues';
    }

    export interface ApiTargetFieldValuesForm {
        TargetId: Serenity.IntegerEditor;
        FieldName: Serenity.StringEditor;
        FieldValue: Serenity.StringEditor;
    }

    [,
        ['TargetId', () => Serenity.IntegerEditor],
        ['FieldName', () => Serenity.StringEditor],
        ['FieldValue', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(ApiTargetFieldValuesForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}