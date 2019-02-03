
namespace Serene.GenericAPIPlatform {
    export interface ApiTypeRow {
        Id?: number;
        ApiName?: string;
        ApiIcon?: string;
        Enabled?: boolean;
        TargetUri?: string;
        Payload?: string;
        Method?: string;
        AltTargetUri?: string;
        AltPayload?: string;
        AltMethod?: string;
        AutoCloseSupported?: boolean;
    }

    export namespace ApiTypeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ApiName';
        export const localTextPrefix = 'GenericAPIPlatform.ApiType';

        export namespace Fields {
            export declare const Id;
            export declare const ApiName;
            export declare const ApiIcon;
            export declare const Enabled;
            export declare const TargetUri;
            export declare const Payload;
            export declare const Method;
            export declare const AltTargetUri;
            export declare const AltPayload;
            export declare const AltMethod;
            export declare const AutoCloseSupported;
        }

        [
            'Id',
            'ApiName',
            'ApiIcon',
            'Enabled',
            'TargetUri',
            'Payload',
            'Method',
            'AltTargetUri',
            'AltPayload',
            'AltMethod',
            'AutoCloseSupported'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}