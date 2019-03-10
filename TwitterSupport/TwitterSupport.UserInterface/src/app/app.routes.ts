import { Routes } from '@angular/router';
import { LayoutComponent } from './shared/layout/layout.component';

export const routes: Routes = [
    {
        children: [
            { path: '', pathMatch: 'full', redirectTo: 'twitter-support' },
            { path: 'twitter-support', loadChildren: './twitter-support/twitter-support.module#TwitterSupportModule' }
        ],
        component: LayoutComponent,
        path: ''
    },

    { path: '**', redirectTo: '' }
];
