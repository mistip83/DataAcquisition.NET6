import { Component, OnInit } from '@angular/core';
import { Facility } from '../models/facility';
import { FacilityService } from '../services/facility.service';

@Component({
  selector: 'app-facility',
  templateUrl: './facility.component.html',
  styleUrls: ['./facility.component.css'],
})
export class FacilityComponent implements OnInit {
  facility: Facility[] = [];

  constructor(private _facilityService: FacilityService) {}

  ngOnInit(): void {
    this._facilityService.getFacilityList().subscribe((data) =>(this.facility = data))
  }
}
