
namespace Serene.GenericAPIPlatform {
    export interface ApiHeadersRow {
        Id?: number;
        ApiTypeId?: number;
        HeaderName?: string;
        HeaderValue?: string;
        AllowPlaceholders?: boolean;
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

    export namespace ApiHeadersRow {
        export const idProperty = 'Id';
        export const nameProperty = 'HeaderName';
        export const localTextPrefix = 'GenericAPIPlatform.ApiHeaders';

        export namespace Fields {
            export declare const Id;
            export declare const ApiTypeId;
            export declare const HeaderName;
            export declare const HeaderValue;
            export declare const AllowPlaceholders;
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
            'HeaderName',
            'HeaderValue',
            'AllowPlaceholders',
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