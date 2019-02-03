
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiTypeDialog extends Serenity.EntityDialog<ApiTypeRow, any> {
        protected getFormKey() { return ApiTypeForm.formKey; }
        protected getIdProperty() { return ApiTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ApiTypeRow.localTextPrefix; }
        protected getNameProperty() { return ApiTypeRow.nameProperty; }
        protected getService() { return ApiTypeService.baseUrl; }

        protected form = new ApiTypeForm(this.idPrefix);

    }
}