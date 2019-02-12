import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { FooListComponent } from "./foo-list";
import { FooComponent } from "./foo";

const routes: Routes = [
  {
    path: "",
    pathMatch: "full",
    component: FooListComponent
  },
  {
    path: ":id",
    component: FooComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FoosRoutingModule {
}
