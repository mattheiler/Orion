import { BrowserModule } from "@angular/platform-browser";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { MatListModule, MatSidenavModule, MatToolbarModule } from "@angular/material";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";

const material: any[] = [MatListModule, MatSidenavModule, MatToolbarModule];

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, BrowserAnimationsModule, HttpClientModule, AppRoutingModule, ...material],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
