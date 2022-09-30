export default interface TimeRegistration {
    id?:number;
    customer:string;
    contactPerson:string;
    contactPersonNumber:string;
    employee:string;
    registrationTime:Date;
    hours:number;
    description:string;
    comments:string;
}