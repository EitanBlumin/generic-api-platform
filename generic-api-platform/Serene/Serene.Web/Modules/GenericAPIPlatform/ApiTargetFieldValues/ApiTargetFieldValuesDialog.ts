
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiTargetFieldValuesDialog extends Serenity.EntityDialog<ApiTargetFieldValuesRow, any> {
        protected getFormKey() { return ApiTargetFieldValuesForm.formKey; }
        protected getIdProperty() { return ApiTargetFieldValuesRow.idProperty; }
        protected getLocalTextPrefix() { return ApiTargetFieldValuesRow.localTextPrefix; }
        protected getNameProperty() { return ApiTargetFieldValuesRow.nameProperty; }
        protected getService() { return ApiTargetFieldValuesService.baseUrl; }

        protected form = new ApiTargetFieldValuesForm(this.idPrefix);

    }
}