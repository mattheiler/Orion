import { Component } from "@angular/core";

import { FooService } from "../shared";

@Component({
  selector: "app-foo-list",
  templateUrl: "./foo-list.component.html",
  styleUrls: ["./foo-list.component.scss"]
})
export class FooListComponent {

  constructor(private readonly foos: FooService) {}

  public data = this.foos.getPage().subscribe();

}
