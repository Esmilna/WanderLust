import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../envirotnment/environment';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class CatalogoService {

  myApUrl = environment.myApUrl
  myApiUrl = 'api/Viaje/';

  constructor(private http: HttpClient) { }

  ObtenerCatalogos(){
    return this.http.get(this.myApUrl + this.myApiUrl)
  }

  ObtenerCatalogoPorId(Id: number): Observable<any>{
    return this.http.get(this.myApUrl + this.myApiUrl + Id);
  }

  ObtenerListaCatalogoPorId(Id: number): Observable<any>{
    return this.http.get(this.myApUrl + this.myApiUrl +"All/" +Id);
  }

  guardarReserva(viaje: any): Observable<any>{
    return this.http.post<any>(this.myApUrl + this.myApiUrl, viaje);
  }

  EliminarViaje(id: number): Observable<any>{  
    return this.http.delete<any>(this.myApUrl + this.myApiUrl + id);   
  }
  
}
