
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiTargetGrid extends Serenity.EntityGrid<ApiTargetRow, any> {
        protected getColumnsKey() { return 'GenericAPIPlatform.ApiTarget'; }
        protected getDialogType() { return ApiTargetDialog; }
        protected getIdProperty() { return ApiTargetRow.idProperty; }
        protected getLocalTextPrefix() { return ApiTargetRow.localTextPrefix; }
        protected getService() { return ApiTargetService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}