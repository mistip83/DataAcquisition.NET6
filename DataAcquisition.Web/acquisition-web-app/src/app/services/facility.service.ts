import { ServerConfig } from './serverConfig';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FacilityDto } from '../models/facilityDto';

@Injectable({ providedIn: 'root' })
export class FacilityService {
  constructor(
    private httpClient: HttpClient,
    private serverConfig: ServerConfig
  ) {}

  getFacilityList(): Observable<FacilityDto[]> {
    return this.httpClient.get<FacilityDto[]>(
      this.serverConfig.REST_API_SERVER_URL + 'facility/facility-list'
    );
  }

  addFacility(facility: FacilityDto): Observable<FacilityDto> {
    return this.httpClient.post<FacilityDto>(
      this.serverConfig.REST_API_SERVER_URL + 'facility/add-facility',
      JSON.stringify(facility),
      this.serverConfig.httpOptions
    );
  }
}
