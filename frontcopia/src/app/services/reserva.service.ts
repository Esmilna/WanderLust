import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../envirotnment/environment';

@Injectable({
  providedIn: 'root'
})
export class ReservaService {

  myApUrl = environment.myApUrl
  myApiUrl = 'api/Reserva/';
  
  constructor(private http: HttpClient) { }

  guardarReserva(Reserva: any): Observable<any>{
    return this.http.post<any>(this.myApUrl + this.myApiUrl, Reserva);
  }

  ObtenerReservas(){
    return this.http.get(this.myApUrl + this.myApiUrl)
  }

 /* ActualizarReserva(id: number, reserva: any): Observable<any>{
    console.log("Por aqui andamos")
    return this.http.patch<any>(this.myApUrl + this.myApiUrl + id, reserva);
   }*/

   ActualizarReserva(reserva: any): Observable<any>{
    console.log("Por aqui andamos")
    return this.http.patch<any>(this.myApUrl + this.myApiUrl, reserva);
   }
}
