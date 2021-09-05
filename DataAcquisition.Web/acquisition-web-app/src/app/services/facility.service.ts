import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { Facility } from '../models/facility';

@Injectable({
  providedIn: 'root'
})
export class FacilityService {

  private REST_API_SERVER = "https://localhost:44339/api/";

  constructor(private httpClient: HttpClient) { }

  getFacilityList(): Observable<Facility[]>{
    return this.httpClient.get<Facility[]>(this.REST_API_SERVER + 'facility/facility-list');
  }
}