import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { IOrganization } from '../interfaces/organization';

@Injectable({
  providedIn: 'root'
})
export class OrganizationService {

  private REST_API_SERVER = "https://localhost:44339/api/";

  constructor(private httpClient: HttpClient) { }

  getOrganizationLayout(): Observable<IOrganization>{
    return this.httpClient.get<IOrganization>(this.REST_API_SERVER + 'company/organization-layout');
  }
}
