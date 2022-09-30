import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TimeregistrationComponent } from './timeregistration/timeregistration.component';

const routes: Routes = [
  {path: 'registration', component: TimeregistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
