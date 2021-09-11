import { Component, OnInit, ViewChild } from '@angular/core';
import { IOrganization } from '../interfaces/organization';
import { OrganizationService } from '../services/organization.service';

@Component({
  selector: 'app-organization',
  templateUrl: './organization.component.html',
  styleUrls: ['./organization.component.css'],
})
export class OrganizationComponent implements OnInit {
  organization: IOrganization;

  constructor(private _organizationService: OrganizationService) {}

  ngOnInit(): void {
    this._organizationService
      .getOrganizationLayout()
      .subscribe((data) => (this.organization = data));
  }

  calculateWorkstationCount(): number {
    let wsCount = 0;

    this.organization.facilities.forEach((facility) => {
      wsCount += facility.workstations.length;
    });

    return wsCount;
  }

  calculateExperimentCount(): number {
    let expCount = 0;

    this.organization.facilities.forEach((facility) => {
      facility.workstations.forEach(workstation => {
        expCount += workstation.experiments.length;
      });
    });
    
    return expCount;
  }

  calculateDeviceCount(): number {
    let deviceCount = 0;

    this.organization.facilities.forEach((facility) => {
      facility.workstations.forEach(workstation => {
        deviceCount += workstation.devices.length;
      });
    });
    
    return deviceCount;
  }
}
