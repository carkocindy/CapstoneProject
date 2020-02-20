import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})


export class HomeComponent {
  secondOnce: number = 1;
  dayTime: number = 1;
  monthTime: number = 1;
  hourTime: number = 1;
  minuteTime: number = 1;
  namedOnce: any = 111;


  callLoop() {
    var url = "https://localhost:5001/api/callloop/" + this.secondOnce + "/" + this.namedOnce;
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }
  deleteLoop() {
    var url = "https://localhost:5001/api/callloop/" + this.namedOnce;
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("DELETE", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }


  callDate() {
    var url = "https://localhost:5001/api/values/" + this.dayTime + "/" + this.monthTime + "/" + this.namedOnce;
    //var url = "https://localhost:5001/api/values/" + "10/2";
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }

  callAdvanceDate() {
    var url = "https://localhost:5001/api/values/" + this.dayTime + "/" + this.monthTime + "/" + this.hourTime + "/"
      + this.minuteTime + "/" + this.secondOnce + "/" + this.namedOnce;
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    return xmlHttp.responseText;
  }


  alertXX() {
    alert("XXXX");
  }
}
