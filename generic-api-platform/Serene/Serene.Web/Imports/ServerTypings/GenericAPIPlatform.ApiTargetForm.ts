
namespace Serene.GenericAPIPlatform {
    export class ApiTargetForm extends Serenity.PrefixedContext {
        static formKey = 'GenericAPIPlatform.ApiTarget';
    }

    export interface ApiTargetForm {
        ApiTypeId: Serenity.IntegerEditor;
        TargetName: Serenity.StringEditor;
        TargetDescription: Serenity.StringEditor;
        Enabled: Serenity.BooleanEditor;
    }

    [,
        ['ApiTypeId', () => Serenity.IntegerEditor],
        ['TargetName', () => Serenity.StringEditor],
        ['TargetDescription', () => Serenity.StringEditor],
        ['Enabled', () => Serenity.BooleanEditor]
    ].forEach(x => Object.defineProperty(ApiTargetForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}