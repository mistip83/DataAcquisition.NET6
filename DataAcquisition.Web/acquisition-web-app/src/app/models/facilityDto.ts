import { IWorkstationName } from '../interfaces/workstation-name';

export class FacilityDto {

    constructor(
      public facilityId = 0,
      public facilityName = '',
      public address?: string,
      public employees = 0,
      public workstations: IWorkstationName[] = []) { }
  }
