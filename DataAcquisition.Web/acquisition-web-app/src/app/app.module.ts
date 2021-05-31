import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FacilityFormComponent } from './facility-form/facility-form.component';
import { OrganizationOverviewComponent } from './dashboard/organization-overview/organization-overview.component';

@NgModule({
  declarations: [AppComponent, OrganizationOverviewComponent, FacilityFormComponent],
  imports: [BrowserModule, AppRoutingModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
