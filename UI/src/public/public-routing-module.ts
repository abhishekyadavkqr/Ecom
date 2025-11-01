import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HomeComponent } from '../Pages/Components/public/home/home';

const routes=[{ 
    path: 'h',
    component: HomeComponent, // ✅ required to fix NG04014
  }];




@NgModule({
  declarations: [],
  imports: [
    CommonModule,
     RouterModule.forChild(routes)
  ]
})
export class PublicRoutingModule { }
