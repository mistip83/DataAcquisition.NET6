import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { IFacility } from '../interfaces/models/facility';

@Injectable({
  providedIn: 'root'
})
export class FacilityService {

  private REST_API_SERVER = "https://localhost:44339/api/";

  constructor(private httpClient: HttpClient) { }

  getFacilityList(): Observable<IFacility>{
    return this.httpClient.get<IFacility>(this.REST_API_SERVER + 'facility/facility-list');
  }
}