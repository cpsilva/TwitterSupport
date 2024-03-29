import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ConverterService } from './converter.service';
import { environment } from '../../../environments/environment';

@Injectable({ providedIn: 'root' })
export class HttpService {
  filmsApi = 'https://copadosfilmes.azurewebsites.net/api/filmes';

  constructor(
    private http: HttpClient,
    private converterService: ConverterService) { }

  get<T>(service: string, data?: any) {
    let url = environment.serviceUrl + service;

    if (data) {
      if (data !== Object(data)) {
        url += '/' + data;
      } else {
        url += '?' + this.converterService.objectToQueryString(data);
      }
    }

    return this.http.get<T>(url);
  }

  put<T>(service: string, data?: any) {
    const url = environment.serviceUrl + service;

    return this.http.put<T>(url, data);
  }

  post<T>(service: string, data?: any) {
    const url = environment.serviceUrl + service;

    return this.http.post<T>(url, data);
  }

  delete(service: string, data?: any) {
    const url = environment.serviceUrl + service + '/' + data;

    return this.http.delete(url);
  }
}
