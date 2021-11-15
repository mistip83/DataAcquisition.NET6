import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { FacilityDto } from 'src/app/models/facilityDto';
import { FacilityService } from 'src/app/services/facility.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-facility-form',
  templateUrl: './facility-form.component.html',
  styleUrls: ['./facility-form.component.css'],
})
export class FacilityFormComponent implements OnInit {
  facilityForm: FormGroup;
  facility = new FacilityDto();
  id: number;
  isAddMode: boolean;
  header: string;

  constructor(
    private facilityService: FacilityService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.isAddMode = !this.id;

    // Create form group with form inputs
    this.facilityForm = new FormGroup({
      facilityName: new FormControl(),
      address: new FormControl(),
      employees: new FormControl(),
    });

    // Change header
    if (this.isAddMode) {
      this.header = 'Add New Facility';
    } else {
      this.header = 'Edit Facility';
      // Get facility info for edit mode
      this.getFacilityInfo();
    }
  }

  getFacilityInfo() {
    this.facilityService
      .getFacilityInfo(this.id)
      .subscribe((x) => this.facilityForm.patchValue(x));
  }

  // Run when save button is hit
  onSubmit() {
    if (this.isAddMode) {
      this.addFacility();
    } else {
      this.editFacility();
    }
  }

  addFacility() {
    this.facilityService
      .addFacility(this.facilityForm.value)
      .subscribe((res: FacilityDto) => this.router.navigate(['facility']));
  }

  editFacility() {
    this.facilityService
      .editFacility(this.id, this.facilityForm.value)
      .subscribe((res: FacilityDto) => this.router.navigate(['facility']));
  }
}
