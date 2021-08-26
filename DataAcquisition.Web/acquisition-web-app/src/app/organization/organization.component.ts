import { Organization } from './../models/organization.model';
import { Component, OnInit } from '@angular/core';
import { OrganizationService } from '../services/organization.service';

@Component({
  selector: 'app-organization',
  templateUrl: './organization.component.html',
  styleUrls: ['./organization.component.css'],
})
export class OrganizationComponent implements OnInit {
  organization: Organization;

  constructor(private _organizationService: OrganizationService) {}

  ngOnInit(): void {
    this._organizationService
      .getOrganizationLayout()
      .subscribe((data) => (this.organization = data));
  }
}
