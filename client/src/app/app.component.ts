import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { fromEvent } from 'rxjs';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private http:HttpClient){}
  ngOnInit(): void {

    this.getUser();
    this.getWeather();
  }


  getUser() {

    this.http.get('https://localhost:5001/api/User').pipe().subscribe((response) => {
      this.user = response;
      console.log('users', this.user);
    }, (error) => {
      console.log(error);
    })
  }
  getWeather() {

    this.http.get('https://localhost:5001/api/WeatherForecast').pipe().subscribe((response) => {
      this.weather = response;
      console.log('weather', this.weather);
    }, (error) => {
      console.log(error);
    })
  }
  title = "behzad";
  user: any;
  weather: any;


}
