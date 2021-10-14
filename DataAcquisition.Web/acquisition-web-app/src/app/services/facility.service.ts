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

  getFacilityInfo(id: number): Observable<FacilityDto> {
    return this.httpClient.get<FacilityDto>(
      this.serverConfig.REST_API_SERVER_URL + 'facility/' + id
    );
  }

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

  editFacility(facility: FacilityDto): Observable<FacilityDto> {
    return this.httpClient.put<FacilityDto>(
      this.serverConfig.REST_API_SERVER_URL + 'facility/edit-facility',
      JSON.stringify(facility),
      this.serverConfig.httpOptions
    )
  }
}
