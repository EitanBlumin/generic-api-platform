
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiTargetDialog extends Serenity.EntityDialog<ApiTargetRow, any> {
        protected getFormKey() { return ApiTargetForm.formKey; }
        protected getIdProperty() { return ApiTargetRow.idProperty; }
        protected getLocalTextPrefix() { return ApiTargetRow.localTextPrefix; }
        protected getNameProperty() { return ApiTargetRow.nameProperty; }
        protected getService() { return ApiTargetService.baseUrl; }

        protected form = new ApiTargetForm(this.idPrefix);

    }
}