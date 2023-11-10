import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VehiculosComponent } from './components/vehiculos/vehiculos.component';
import { OfertarComponent } from './pages/ofertar/ofertar.component';
import { HomeComponent } from './pages/home/home.component';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { CatalogComponent } from './pages/catalog/catalog.component';
import { ContactComponent } from './pages/contact/contact.component';
import { GalleryComponent } from './pages/gallery/gallery.component';
import { NewsComponent } from './pages/news/news.component';
import { OfferComponent } from './pages/offer/offer.component';
import { StoreComponent } from './pages/store/store.component';
import { TravelComponent } from './pages/travel/travel.component';
import { DetalleCatalogoComponent } from './pages/detalle-catalogo/detalle-catalogo.component';

const routes: Routes = [
  {path:'inicio', component:VehiculosComponent},
  {path:'ofertar', component: OfertarComponent},

  {path:'about', component:AboutUsComponent},
  {path:'catalog', component:CatalogComponent},
  {path:'contact', component:ContactComponent},
  {path:'gallery', component:GalleryComponent},
  {path:'home', component:HomeComponent},
  {path:'news', component:NewsComponent},
  {path:'offer', component:OfferComponent},
  {path:'store', component:StoreComponent},
  {path:'travel', component:TravelComponent},

  //
  {path:'detalleCatalogoComponent/:id', component:DetalleCatalogoComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
