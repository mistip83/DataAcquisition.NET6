import { ServerConfig } from './serverConfig';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IOrganization } from '../interfaces/organization';

@Injectable({
  providedIn: 'root',
})
export class OrganizationService {
  constructor(
    private httpClient: HttpClient,
    private serverConfig: ServerConfig
  ) {}

  getOrganizationLayout(): Observable<IOrganization> {
    return this.httpClient.get<IOrganization>(
      this.serverConfig.REST_API_SERVER_URL + 'company/organization-layout'
    );
  }
}
