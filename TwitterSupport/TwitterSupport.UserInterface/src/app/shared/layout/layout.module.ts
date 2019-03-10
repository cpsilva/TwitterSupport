import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { LayoutComponent } from './layout.component';
import { BodyComponent } from './body/body.component';

@NgModule({
    declarations: [
        FooterComponent,
        HeaderComponent,
        LayoutComponent,
        BodyComponent
    ],
    imports: [RouterModule]
})
export class LayoutModule { }
