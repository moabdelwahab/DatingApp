import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WeatherForecast } from './weatherForecast';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {

  values:WeatherForecast[];

  constructor(private httpclient:HttpClient) { }

  getValues(){
    this.httpclient.get<WeatherForecast[]>("https://localhost:5001/WeatherForecast/").subscribe(
      (data:WeatherForecast[])=>this.values=data
      ,
    error=>{
      console.log("error");
    });
  }
  ngOnInit() {
    this.getValues();
  }

}
