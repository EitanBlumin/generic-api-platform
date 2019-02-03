
namespace Serene.GenericAPIPlatform {
    export interface ApiTargetFieldValuesRow {
        Id?: number;
        TargetId?: number;
        FieldName?: string;
        FieldValue?: string;
        TargetApiTypeId?: number;
        TargetTargetName?: string;
        TargetTargetDescription?: string;
        TargetEnabled?: boolean;
    }

    export namespace ApiTargetFieldValuesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'FieldName';
        export const localTextPrefix = 'GenericAPIPlatform.ApiTargetFieldValues';

        export namespace Fields {
            export declare const Id;
            export declare const TargetId;
            export declare const FieldName;
            export declare const FieldValue;
            export declare const TargetApiTypeId;
            export declare const TargetTargetName;
            export declare const TargetTargetDescription;
            export declare const TargetEnabled;
        }

        [
            'Id',
            'TargetId',
            'FieldName',
            'FieldValue',
            'TargetApiTypeId',
            'TargetTargetName',
            'TargetTargetDescription',
            'TargetEnabled'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}