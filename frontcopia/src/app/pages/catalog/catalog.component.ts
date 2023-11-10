import { Component } from '@angular/core';
import { CatalogoService } from 'src/app/services/catalogo.service';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent {

  ListaCatalogo: any[] = []; 
 
  constructor(private CatalogoService : CatalogoService) {

    this.CatalogoService.ObtenerCatalogos().subscribe((data: any)=>{
      console.log("Datos del servicio",data)
      this.ListaCatalogo =  data
    })
   
    
  }
}
