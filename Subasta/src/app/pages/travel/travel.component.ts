import { Component, OnInit } from '@angular/core';
import { CatalogoService } from 'src/app/services/catalogo.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-travel',
  templateUrl: './travel.component.html',
  styleUrls: ['./travel.component.css']
})
export class TravelComponent {
  viaje: any = {}; 
  ListaCatalogo: any[] = []; 
  
  constructor(private catalogoService: CatalogoService) {
    
  }
  ngOnInit() {
    
    this.ObtenerViajes();
  
      this.viaje.id = 0;
      this.viaje.nombre = null;
      this.viaje.descripcion = null;
      this.viaje.destino = null;
      this.viaje.duracionViaje = '';
      this.viaje.urlImagen = ''
      this.viaje.fecha = '';
      this.viaje.precio = '';
   }

   GuardarReserva(viaje :any){
    this.catalogoService.guardarReserva(viaje).subscribe((data:any) => {
      console.log("Respuestas del post", data)
      //this.ObtenerReservas()
      //window.location.reload();
      Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 3000
      })
      window.location.reload();
    })
  console.log("Reserva", viaje)
  
  
   }
   ObtenerViajes(){
    this.catalogoService.ObtenerCatalogos().subscribe((data: any)=>{
      console.log("Datos del servicio",data)
      this.ListaCatalogo =  data
    })
   }

   ObtenerDatos(viaje: any){
    this.viaje = viaje
   }

   Editar(id: any, viaje: any){
/*
    console.log("Update ID", id)
    console.log("object update", reserva)
    this.ReservaService.ActualizarReserva(reserva).subscribe((data:any)=>{
      console.log("Se esta actualizando")
      if(data != null){
        return true
      }
      else{
        return false
      }
    })  */

   }
   Eliminar(id: any){
    
    this.catalogoService.EliminarViaje(id).subscribe((data:any)=>{
      console.log(data)
      window.location.reload();
    })
   }
}
