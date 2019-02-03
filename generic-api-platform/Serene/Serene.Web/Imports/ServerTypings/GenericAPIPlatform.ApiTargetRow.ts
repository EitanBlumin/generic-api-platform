
namespace Serene.GenericAPIPlatform {
    export interface ApiTargetRow {
        Id?: number;
        ApiTypeId?: number;
        TargetName?: string;
        TargetDescription?: string;
        Enabled?: boolean;
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

    export namespace ApiTargetRow {
        export const idProperty = 'Id';
        export const nameProperty = 'TargetName';
        export const localTextPrefix = 'GenericAPIPlatform.ApiTarget';

        export namespace Fields {
            export declare const Id;
            export declare const ApiTypeId;
            export declare const TargetName;
            export declare const TargetDescription;
            export declare const Enabled;
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
            'TargetName',
            'TargetDescription',
            'Enabled',
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