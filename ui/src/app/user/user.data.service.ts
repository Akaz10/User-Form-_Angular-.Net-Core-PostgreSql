import { Injectable } from '@angular/core';
import {
    ActivatedRouteSnapshot,
    Resolve,
    RouterStateSnapshot,
} from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, from, Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class UserDataService {
    url = 'https://localhost:44348/api/Test/SaveUser'
    constructor(private httpClient: HttpClient) {}

    saveUser(data:any){
        return this.httpClient.post(this.url,data)
    }
}
