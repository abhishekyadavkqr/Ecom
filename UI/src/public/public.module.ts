import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// ✅ Import your standalone Home component
import { HomeComponent } from '../Pages/Components/public/home/home'; // adjust this path as needed
import { PublicRoutingModule } from './public-routing-module';

@NgModule({
  imports: [
    CommonModule,
    PublicRoutingModule,
    HomeComponent // ✅ since it's standalone, you can import directly
  ]
})
export class PublicModule {}
