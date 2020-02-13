export class WeatherForecast {
         id :number;
         dateTime:Date;
         temperatureC :number;
         temperatureF:number;
         summary:string 
         
         /**
          *
          */
         constructor(id:number,datetime:Date,tempC:number,TempF:number,summary:string) {
             this.id=id;
             this.dateTime=datetime;
             this.temperatureC=tempC;
             this.temperatureF=TempF;
             this.summary=summary;
                         
         }
}
