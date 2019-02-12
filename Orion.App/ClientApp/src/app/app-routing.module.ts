import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

const routes: Routes = [
  {
    path: "foos",
    loadChildren: "./foos/foos.module#FoosModule"
  },
  {
    path: "bars",
    loadChildren: "./bars/bars.module#BarsModule"
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
