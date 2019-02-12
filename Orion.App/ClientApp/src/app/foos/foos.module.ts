import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { FoosRoutingModule } from "./foos-routing.module";

import { FooListComponent } from "./foo-list";
import { FooComponent } from "./foo";

import { FooService } from "./shared";

@NgModule({
  declarations: [FooListComponent, FooComponent],
  imports: [CommonModule, FoosRoutingModule],
  providers: [FooService]
})
export class FoosModule {
}
