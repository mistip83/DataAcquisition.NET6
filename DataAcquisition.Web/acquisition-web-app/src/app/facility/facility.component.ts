import { Component, OnInit } from '@angular/core';
import { FacilityDto } from '../models/facilityDto';
import { FacilityService } from '../services/facility.service';

@Component({
  selector: 'app-facility',
  templateUrl: './facility.component.html',
  styleUrls: ['./facility.component.css'],
})
export class FacilityComponent implements OnInit {
  facilityList: FacilityDto[] = [];

  constructor(private facilityService: FacilityService) {}

  ngOnInit(): void {
    this.facilityService
      .getFacilityList()
      .subscribe((data) => (this.facilityList = data));
  }
}
