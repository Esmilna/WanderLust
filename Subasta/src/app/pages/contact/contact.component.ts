import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent {
  
  datosContacto: any = {};;
  ngOnInit() { 
      this.datosContacto.nombre = '';
      this.datosContacto.email = '';
      this.datosContacto.Mensaje = null;      
   }


  sendEmail() {
    const subject = this.datosContacto.nombre;
    const body = this.datosContacto.Mensaje;
    window.location.href = `mailto:recipient@example.com?subject=${subject}&body=${body}`;
  }
  
}
