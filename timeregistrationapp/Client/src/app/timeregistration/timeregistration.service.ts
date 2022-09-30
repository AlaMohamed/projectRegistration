import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import TimeRegistration from '../models/timeregistration';


const routes = {
    list: () => 'http://localhost:5000/api/timeregistation',
    single: (id:number) => 'http://localhost:5000/api/timeregistation/'+id,
    create: () => 'http://localhost:5000/api/timeregistation',
    update: (id:number) => 'http://localhost:5000/api/timeregistation/' + id,
    delete: (id:number) => 'http://localhost:5000/api/timeregistation/' + id
}


@Injectable({
  providedIn: 'root',
})
export class TimeRegistrationService {

/**
 *
 */
constructor(private client:HttpClient) {    
}


getRegistrations(){
    return this.client.get(routes.list());
}

getSingleRegistration(id:number){
    return this.client.get(routes.single(id))
}

createTimeregistration(dto:TimeRegistration){
    return this.client.post(routes.create(), dto)
}

updateTimeregistration(id:number, dto:TimeRegistration){
    return this.client.put(routes.update(id),dto)
}

deleteTimeregistration(id: number){
    return this.client.delete(routes.delete(id))
}
}