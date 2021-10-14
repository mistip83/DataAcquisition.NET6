import { HomeComponent } from './home/home.component';
import { ExperimentComponent } from './experiment/experiment.component';
import { DeviceComponent } from './device/device.component';
import { WorkstationComponent } from './workstation/workstation.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { FacilityComponent } from './facility/facility.component';
import { FacilityFormComponent } from './facility/facility-form/facility-form.component';
import { OrganizationComponent } from './organization/organization.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full'},
  { path: 'home', component: HomeComponent },
  { path: 'organization', component: OrganizationComponent },
  { path: 'facility', component: FacilityComponent },
  { path: 'facility-form', component: FacilityFormComponent },
  { path: 'facility/:id', component: FacilityFormComponent },
  { path: 'workstation', component: WorkstationComponent },
  { path: 'device', component: DeviceComponent },
  { path: 'experiment', component: ExperimentComponent },
  { path: 'about', component: AboutComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
