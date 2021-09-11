import { IDeviceName } from './device-name';
import { IExperimentName } from "./experiment-name";

export interface IWorkstationName {
    workstationName: string;
    devices: IDeviceName[];
    experiments: IExperimentName[];
}
