import { Component } from "@angular/core";

import { BarService } from '../shared';

@Component({
  selector: "app-bar",
  templateUrl: "./bar.component.html",
  styleUrls: ["./bar.component.scss"]
})
export class BarComponent {

  constructor(private readonly bars: BarService) { }

  public data = this.bars.get(0).subscribe();

}
