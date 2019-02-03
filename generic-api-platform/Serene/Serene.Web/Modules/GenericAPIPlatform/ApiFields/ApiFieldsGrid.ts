
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiFieldsGrid extends Serenity.EntityGrid<ApiFieldsRow, any> {
        protected getColumnsKey() { return 'GenericAPIPlatform.ApiFields'; }
        protected getDialogType() { return ApiFieldsDialog; }
        protected getIdProperty() { return ApiFieldsRow.idProperty; }
        protected getLocalTextPrefix() { return ApiFieldsRow.localTextPrefix; }
        protected getService() { return ApiFieldsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}