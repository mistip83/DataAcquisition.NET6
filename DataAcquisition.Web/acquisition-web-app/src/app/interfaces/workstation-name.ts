import { IExperimentName } from "./experiment-name";

export interface IWorkstationName {
    workstationName: string;
    experiments: IExperimentName[];
}
