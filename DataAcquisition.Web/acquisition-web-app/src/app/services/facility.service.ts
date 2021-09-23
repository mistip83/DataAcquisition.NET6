import { ServerConfig } from './serverConfig';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FacilityDto } from '../models/facilityDto';

@Injectable({
  providedIn: 'root',
})
export class FacilityService {
  constructor(
    private httpClient: HttpClient,
    private serverConfig: ServerConfig
  ) {}

  // Http Options
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  };

  getFacilityList(): Observable<FacilityDto[]> {
    return this.httpClient.get<FacilityDto[]>(
      this.serverConfig.REST_API_SERVER_URL + 'facility/facility-list'
    );
  }

  addFacility(facility: FacilityDto): Observable<FacilityDto> {
    return this.httpClient.post<FacilityDto>(
      this.serverConfig.REST_API_SERVER_URL + 'facility/add-facility',
      JSON.stringify(facility),
      this.httpOptions
    );
  }
}
