import { Component, OnInit } from "@angular/core";

import { FooService } from '../shared';

@Component({
  selector: "app-foo",
  templateUrl: "./foo.component.html",
  styleUrls: ["./foo.component.scss"]
})
export class FooComponent {

  constructor(private readonly foos: FooService) { }

  public data = this.foos.get(0).subscribe();

}
