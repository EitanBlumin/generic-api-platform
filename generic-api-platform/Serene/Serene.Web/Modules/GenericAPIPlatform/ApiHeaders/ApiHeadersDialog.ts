
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiHeadersDialog extends Serenity.EntityDialog<ApiHeadersRow, any> {
        protected getFormKey() { return ApiHeadersForm.formKey; }
        protected getIdProperty() { return ApiHeadersRow.idProperty; }
        protected getLocalTextPrefix() { return ApiHeadersRow.localTextPrefix; }
        protected getNameProperty() { return ApiHeadersRow.nameProperty; }
        protected getService() { return ApiHeadersService.baseUrl; }

        protected form = new ApiHeadersForm(this.idPrefix);

    }
}