import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OfertarComponent } from './pages/ofertar/ofertar.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { VehiculosComponent } from './components/vehiculos/vehiculos.component';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { CatalogComponent } from './pages/catalog/catalog.component';
import { ContactComponent } from './pages/contact/contact.component';
import { GalleryComponent } from './pages/gallery/gallery.component';
import { HomeComponent } from './pages/home/home.component';
import { NewsComponent } from './pages/news/news.component';
import { OfferComponent } from './pages/offer/offer.component';
import { StoreComponent } from './pages/store/store.component';
import { TravelComponent } from './pages/travel/travel.component';


import {HttpClientModule} from '@angular/common/http';
import { DetalleCatalogoComponent } from './pages/detalle-catalogo/detalle-catalogo.component';

@NgModule({
  declarations: [
    AppComponent,
    OfertarComponent,
    NavbarComponent,
    VehiculosComponent,
    AboutUsComponent,
    CatalogComponent,
    ContactComponent,
    GalleryComponent,
    HomeComponent,
    NewsComponent,
    OfferComponent,
    StoreComponent,
    TravelComponent,
    DetalleCatalogoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
