
namespace Serene.GenericAPIPlatform {
    export class ApiHeadersForm extends Serenity.PrefixedContext {
        static formKey = 'GenericAPIPlatform.ApiHeaders';
    }

    export interface ApiHeadersForm {
        ApiTypeId: Serenity.IntegerEditor;
        HeaderName: Serenity.StringEditor;
        HeaderValue: Serenity.StringEditor;
        AllowPlaceholders: Serenity.BooleanEditor;
    }

    [,
        ['ApiTypeId', () => Serenity.IntegerEditor],
        ['HeaderName', () => Serenity.StringEditor],
        ['HeaderValue', () => Serenity.StringEditor],
        ['AllowPlaceholders', () => Serenity.BooleanEditor]
    ].forEach(x => Object.defineProperty(ApiHeadersForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}