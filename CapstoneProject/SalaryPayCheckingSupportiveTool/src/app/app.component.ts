import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { ApiService } from './api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  apiValues: any;

  constructor(private api: ApiService) {
  }

  ngOnInit(){
    this.api.getSystemUsers().subscribe(
      res => {
        this.apiValues = res;
      },
      err => {

      },
      () => {

      }
    )
  }

}
