import { Component } from "@angular/core";

import { BarService } from "../shared";

@Component({
  selector: "app-bar-list",
  templateUrl: "./bar-list.component.html",
  styleUrls: ["./bar-list.component.scss"]
})
export class BarListComponent {

  constructor(private readonly bars: BarService) {}

  public data = this.bars.getPage().subscribe();

}
