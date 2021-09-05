import { IWorkstationName } from "./workstation-name";

export interface IFacilityName {
    facilityName: string; 
    workstations: IWorkstationName[];
}
