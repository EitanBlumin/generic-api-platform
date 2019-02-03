
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiFieldsDialog extends Serenity.EntityDialog<ApiFieldsRow, any> {
        protected getFormKey() { return ApiFieldsForm.formKey; }
        protected getIdProperty() { return ApiFieldsRow.idProperty; }
        protected getLocalTextPrefix() { return ApiFieldsRow.localTextPrefix; }
        protected getNameProperty() { return ApiFieldsRow.nameProperty; }
        protected getService() { return ApiFieldsService.baseUrl; }

        protected form = new ApiFieldsForm(this.idPrefix);

    }
}