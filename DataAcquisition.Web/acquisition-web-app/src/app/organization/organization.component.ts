import { Component, OnInit } from '@angular/core';
import { IOrganization } from '../interfaces/models/organization';
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
}
