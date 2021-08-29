import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { IOrganization } from '../interfaces/models/organization';

@Injectable({
  providedIn: 'root'
})
export class OrganizationService {

  private REST_API_SERVER = "http://localhost:44339";

  constructor(private httpClient: HttpClient) { }

  getOrganizationLayout(): Observable<IOrganization>{
    return this.httpClient.get<IOrganization>(this.REST_API_SERVER);
  }
}
