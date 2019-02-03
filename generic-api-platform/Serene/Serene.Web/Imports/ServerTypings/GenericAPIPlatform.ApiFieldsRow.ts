
namespace Serene.GenericAPIPlatform {
    export interface ApiFieldsRow {
        Id?: number;
        ApiTypeId?: number;
        FieldName?: string;
        FieldLabel?: string;
        FieldDataType?: string;
        FieldDefaultValue?: string;
        AllowAlertPlaceholders?: boolean;
        ApiTypeApiName?: string;
        ApiTypeApiIcon?: string;
        ApiTypeEnabled?: boolean;
        ApiTypeTargetUri?: string;
        ApiTypePayload?: string;
        ApiTypeMethod?: string;
        ApiTypeAltTargetUri?: string;
        ApiTypeAltPayload?: string;
        ApiTypeAltMethod?: string;
        ApiTypeAutoCloseSupported?: boolean;
    }

    export namespace ApiFieldsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'FieldName';
        export const localTextPrefix = 'GenericAPIPlatform.ApiFields';

        export namespace Fields {
            export declare const Id;
            export declare const ApiTypeId;
            export declare const FieldName;
            export declare const FieldLabel;
            export declare const FieldDataType;
            export declare const FieldDefaultValue;
            export declare const AllowAlertPlaceholders;
            export declare const ApiTypeApiName;
            export declare const ApiTypeApiIcon;
            export declare const ApiTypeEnabled;
            export declare const ApiTypeTargetUri;
            export declare const ApiTypePayload;
            export declare const ApiTypeMethod;
            export declare const ApiTypeAltTargetUri;
            export declare const ApiTypeAltPayload;
            export declare const ApiTypeAltMethod;
            export declare const ApiTypeAutoCloseSupported;
        }

        [
            'Id',
            'ApiTypeId',
            'FieldName',
            'FieldLabel',
            'FieldDataType',
            'FieldDefaultValue',
            'AllowAlertPlaceholders',
            'ApiTypeApiName',
            'ApiTypeApiIcon',
            'ApiTypeEnabled',
            'ApiTypeTargetUri',
            'ApiTypePayload',
            'ApiTypeMethod',
            'ApiTypeAltTargetUri',
            'ApiTypeAltPayload',
            'ApiTypeAltMethod',
            'ApiTypeAutoCloseSupported'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}