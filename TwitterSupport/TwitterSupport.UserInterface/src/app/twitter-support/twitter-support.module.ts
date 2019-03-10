import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { TwitterSupportComponent } from './twitter-support.component';
import { TwitterSupportMostMentionsComponent } from './most-mentions/most-mentions.component';
import { TwitterSupportMostRelevantComponent } from './most-relevant/most-relevant.component';

const routes: Routes = [
    {
        children: [
            { path: '', pathMatch: 'full', redirectTo: 'most-relevant' },
            { path: 'most-mentions', component: TwitterSupportMostMentionsComponent },
            { path: 'most-relevant', component: TwitterSupportMostRelevantComponent }
        ],
        component: TwitterSupportComponent,
        path: ''
    }
];

@NgModule({
    declarations: [
        TwitterSupportComponent,
        TwitterSupportMostMentionsComponent,
        TwitterSupportMostRelevantComponent
    ],
    imports: [
        RouterModule.forChild(routes),
        SharedModule
    ]
})
export class TwitterSupportModule { }
