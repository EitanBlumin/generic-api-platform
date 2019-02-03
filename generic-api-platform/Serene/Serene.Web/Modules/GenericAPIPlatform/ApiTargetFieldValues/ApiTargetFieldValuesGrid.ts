
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiTargetFieldValuesGrid extends Serenity.EntityGrid<ApiTargetFieldValuesRow, any> {
        protected getColumnsKey() { return 'GenericAPIPlatform.ApiTargetFieldValues'; }
        protected getDialogType() { return ApiTargetFieldValuesDialog; }
        protected getIdProperty() { return ApiTargetFieldValuesRow.idProperty; }
        protected getLocalTextPrefix() { return ApiTargetFieldValuesRow.localTextPrefix; }
        protected getService() { return ApiTargetFieldValuesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}