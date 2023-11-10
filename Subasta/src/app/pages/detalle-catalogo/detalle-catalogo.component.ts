import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { CatalogoService } from 'src/app/services/catalogo.service';
import { ReservaService } from '../../services/reserva.service';
import Swal from 'sweetalert2';



@Component({
  selector: 'app-detalle-catalogo',
  templateUrl: './detalle-catalogo.component.html',
  styleUrls: ['./detalle-catalogo.component.css']
})
export class DetalleCatalogoComponent implements OnInit {
  id?: any;
  datosCatalogo: any[] =[];
  reserva: any = {}; 
  listaReserva: any[] = [];

  constructor(private route: ActivatedRoute, 
              private catalogoService: CatalogoService,
              private ReservaService: ReservaService ) { }

 ngOnInit() {
  this.route.params.subscribe((data:Params)=>{
    this.id = data
    console.log("Id principal", this.id.id)
    this.ObtenerCatalogoPorId()
    this.ObtenerReservas(this.id.id)

    this.reserva.id = 0;
    this.reserva.idViaje = this.id.id;
    this.reserva.inicioFechaReserva = null;
    this.reserva.finFechaReserva = null;
    this.reserva.estadoReserva = '';
    this.reserva.nombreCliente = '';
    this.reserva.cedulaCliente = '';
    this.reserva.telefonoCliente = '';
  }) 
 }

 ObtenerCatalogoPorId(){
  
  this.catalogoService.ObtenerCatalogoPorId(this.id.id).subscribe((data: any)=>{
    console.log("Datos del catalogo por Id", data)
    this.datosCatalogo.push(data)
  })

  console.log("Id", this.id.id)
 }

 GuardarReserva(reserva :any){
  this.ReservaService.guardarReserva(reserva).subscribe((data:any) => {
    console.log("Respuestas del post", data)
    //this.ObtenerReservas()
    //window.location.reload();
    Swal.fire({
      position: 'top-end',
      icon: 'success',
      title: 'Registro Guardado Correctamente',
      showConfirmButton: false,
      timer: 3000
    })
    window.location.reload();
  })
console.log("Reserva", reserva)


 }

 /*ObtenerReservas(){
  this.ReservaService.ObtenerReservas().subscribe((data:any) =>{
    this.listaReserva = data
    console.log("L:ista de reservas", this.listaReserva)
  })
 }*/

 ObtenerReservas(id: number){
  this.ReservaService.ObtenerListaReservaPorId(id).subscribe((data:any) =>{
    this.listaReserva = data
    console.log("L:ista de reservas", this.listaReserva)
  })
 }

 Editar(id: any, reserva: any){

  console.log("Update ID", id)
  console.log("object update", reserva)
  this.ReservaService.ActualizarReserva(reserva).subscribe((data:any)=>{
    console.log("Se esta actualizando")
    if(data != null){
      Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Registro Guardado Correctamente',
        showConfirmButton: false,
        timer: 3000
      })
      window.location.reload();
      return true
    }
    else{
      return false
    }

    
  })  

  //this.ObtenerReservas()
 }

 ObtenerDatos(reserva: any){
  this.reserva = reserva
 }
 Eliminar(id: any){
  console.log(id)
  this.ReservaService.EliminarReserva(id).subscribe((data:any)=>{
    console.log("Eliminado")  
    window.location.reload();
  })
  
 }
 
}
