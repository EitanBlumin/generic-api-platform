
namespace Serene.GenericAPIPlatform {
    export class ApiTypeForm extends Serenity.PrefixedContext {
        static formKey = 'GenericAPIPlatform.ApiType';
    }

    export interface ApiTypeForm {
        ApiName: Serenity.StringEditor;
        ApiIcon: Serenity.StringEditor;
        Enabled: Serenity.BooleanEditor;
        TargetUri: Serenity.StringEditor;
        Payload: Serenity.StringEditor;
        Method: Serenity.StringEditor;
        AltTargetUri: Serenity.StringEditor;
        AltPayload: Serenity.StringEditor;
        AltMethod: Serenity.StringEditor;
        AutoCloseSupported: Serenity.BooleanEditor;
    }

    [,
        ['ApiName', () => Serenity.StringEditor],
        ['ApiIcon', () => Serenity.StringEditor],
        ['Enabled', () => Serenity.BooleanEditor],
        ['TargetUri', () => Serenity.StringEditor],
        ['Payload', () => Serenity.StringEditor],
        ['Method', () => Serenity.StringEditor],
        ['AltTargetUri', () => Serenity.StringEditor],
        ['AltPayload', () => Serenity.StringEditor],
        ['AltMethod', () => Serenity.StringEditor],
        ['AutoCloseSupported', () => Serenity.BooleanEditor]
    ].forEach(x => Object.defineProperty(ApiTypeForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}