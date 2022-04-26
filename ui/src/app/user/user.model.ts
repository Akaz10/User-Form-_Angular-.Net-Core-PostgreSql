export interface IUser {
    id?: number;
    name?: string;
    surname?: string;
    mail?: string;
    bDay?: Date;
    gender?: string;
}

export class User implements IUser {

}


