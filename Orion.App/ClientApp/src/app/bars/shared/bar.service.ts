import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";

import { Bar } from "./bar";

@Injectable({ providedIn: "root" })
export class BarService {

  constructor(private readonly http: HttpClient) { }

  public get(id: number) {
    return this.http.get<Bar>(`/api/bars/${id}`);
  }

  public getPage(args: { pageIndex?: number, pageSize?: number, sortProperty?: string, sortDirection?: "asc" | "desc" } = {}) {

    const params = new HttpParams()
      .set("pageIndex", (args.pageIndex || 0).toString())
      .set("pageSize", (args.pageSize || 20).toString())
      .set("sortProperty", args.sortProperty || "Id")
      .set("sortDirection", args.sortDirection || "asc");

    return this.http.get<Bar[]>("/api/bars", { params });
  }

}
