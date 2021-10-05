import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { FacilityDto } from 'src/app/models/facilityDto';
import { FacilityService } from 'src/app/services/facility.service';


@Component({
  selector: 'app-facility-form',
  templateUrl: './facility-form.component.html',
  styleUrls: ['./facility-form.component.css'],
})
export class FacilityFormComponent implements OnInit {
  facilityForm: FormGroup;
  facility = new FacilityDto();

  constructor(private facilityService: FacilityService, private router: Router) {}

  ngOnInit(): void {
    this.facilityForm = new FormGroup({
      facilityName: new FormControl(),
      address: new FormControl(),
      employees: new FormControl(),
    });
  }

  saveFacility() {
    console.log(this.facilityForm);
    this.facilityService.addFacility(this.facilityForm.value);
    console.log('Saved: ' + JSON.stringify(this.facilityForm.value));
  }
}
