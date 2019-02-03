
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiTypeGrid extends Serenity.EntityGrid<ApiTypeRow, any> {
        protected getColumnsKey() { return 'GenericAPIPlatform.ApiType'; }
        protected getDialogType() { return ApiTypeDialog; }
        protected getIdProperty() { return ApiTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ApiTypeRow.localTextPrefix; }
        protected getService() { return ApiTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}