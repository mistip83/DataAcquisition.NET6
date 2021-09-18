import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Facility } from 'src/app/models/facility';

@Component({
  selector: 'app-facility-form',
  templateUrl: './facility-form.component.html',
  styleUrls: ['./facility-form.component.css'],
})
export class FacilityFormComponent implements OnInit {
  facilityForm: FormGroup;
  facility = new Facility();

  constructor() {}

  ngOnInit(): void {
    this.facilityForm = new FormGroup({
      facilityName: new FormControl(),
      address: new FormControl(),
      employees: new FormControl(),
    });
  }

  populateTestData(): void {
    this.facilityForm.patchValue({
      facilityName: 'Jack',
      address: 'Harkness',
      employees: 3
    });
  }

  save() {
    console.log(this.facilityForm);
    console.log('Saved: ' + JSON.stringify(this.facilityForm.value));
  }
}
