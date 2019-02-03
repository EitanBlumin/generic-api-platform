
namespace Serene.GenericAPIPlatform {

    @Serenity.Decorators.registerClass()
    export class ApiHeadersGrid extends Serenity.EntityGrid<ApiHeadersRow, any> {
        protected getColumnsKey() { return 'GenericAPIPlatform.ApiHeaders'; }
        protected getDialogType() { return ApiHeadersDialog; }
        protected getIdProperty() { return ApiHeadersRow.idProperty; }
        protected getLocalTextPrefix() { return ApiHeadersRow.localTextPrefix; }
        protected getService() { return ApiHeadersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}