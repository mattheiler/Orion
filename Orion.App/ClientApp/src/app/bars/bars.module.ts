import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { BarsRoutingModule } from "./bars-routing.module";

import { BarListComponent } from "./bar-list";
import { BarComponent } from "./bar";

import { BarService } from "./shared";

@NgModule({
  declarations: [BarListComponent, BarComponent],
  imports: [CommonModule, BarsRoutingModule],
  providers: [BarService]
})
export class BarsModule {
}
