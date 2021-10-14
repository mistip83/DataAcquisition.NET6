import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatDividerModule } from '@angular/material/divider';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HomeComponent } from './home/home.component';
import { OrganizationComponent } from './organization/organization.component';
import { WorkstationComponent } from './workstation/workstation.component';
import { DeviceComponent } from './device/device.component';
import { AboutComponent } from './about/about.component';
import { FacilityComponent } from './facility/facility.component';
import { FacilityFormComponent } from './facility/facility-form/facility-form.component';
import { ExperimentComponent } from './experiment/experiment.component';
import { ServerConfig } from './services/serverConfig';

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
    ExperimentComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MatToolbarModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    MatProgressSpinnerModule,
    MatExpansionModule,
    MatSidenavModule,
    MatDividerModule,
    FlexLayoutModule
  ],
  providers: [ServerConfig],
  bootstrap: [AppComponent],
})
export class AppModule {}
