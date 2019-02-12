import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { BarListComponent } from "./bar-list";
import { BarComponent } from "./bar";

const routes: Routes = [
  {
    path: "",
    pathMatch: "full",
    component: BarListComponent
  },
  {
    path: ":id",
    component: BarComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BarsRoutingModule {
}
