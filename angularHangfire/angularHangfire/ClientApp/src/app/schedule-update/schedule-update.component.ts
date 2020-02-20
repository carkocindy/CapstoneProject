import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-schedule-update',
  templateUrl: './schedule-update.component.html',
  styleUrls: ['./schedule-update.component.css']
})
export class ScheduleUpdateComponent implements OnInit {
  secondOnce: number = 1;
  dayTime: number = 1;
  monthTime: number = 1;
  hourTime: number = 1;
  minuteTime: number = 1;
  namedOnce: any = 111;

  callFakeRecurring() {
    var url = "https://localhost:5001/api/callloop/" + this.dayTime + "/" + this.monthTime + "/" + this.hourTime + "/"
      + this.minuteTime + "/" + this.secondOnce + "/" + this.namedOnce;
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }

  callOnce() {
    var url = "https://localhost:5001/api/values/" + this.secondOnce + "/" + this.namedOnce;
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }

  deleteSchedule() {
    var url = "https://localhost:5001/api/values/" + this.namedOnce;
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("DELETE", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }

  constructor() { }

  ngOnInit() {
  }

}
