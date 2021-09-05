import { IFacilityName } from "./facility-name";

export interface IOrganization {
    companyName: string;
    facilities: IFacilityName[];
}
