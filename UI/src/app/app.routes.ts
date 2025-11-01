import { Routes } from '@angular/router';
import { HomeComponent } from '../Pages/Components/public/home/home';

export const routes: Routes = [
    {
         path: '',
    component: HomeComponent, // 👈 This is your landing page
    title: 'Landing Page'
    },
     {
    path: 'public',
    loadChildren: () => import('../public/public.module').then(m => m.PublicModule)
  },

  {
    path: '**',
    redirectTo: ''
  }
];
