import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { OrganizationComponent } from './organization/organization.component';
import { WorkstationComponent } from './workstation/workstation.component';
import { DeviceComponent } from './device/device.component';
import { AboutComponent } from './about/about.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatExpansionModule } from '@angular/material/expansion';
import { FacilityComponent } from './facility/facility.component';
import { FacilityFormComponent } from './facility/facility-form/facility-form.component';
import { ExperimentComponent } from './experiment/experiment.component';

@NgModule({
  declarations: [	
    AppComponent,
    OrganizationComponent,
    FacilityComponent,
    WorkstationComponent,
    DeviceComponent,
    AboutComponent,
      FacilityComponent,
      FacilityFormComponent,
      ExperimentComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    MatProgressSpinnerModule,
    MatExpansionModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
