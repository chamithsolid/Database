declare module Master.Repo {

    interface ICrud {
        create(T: any): any;
        update(T: any): any;
        delete(Key: any);
        select(): any
        selectById(Key): any;
        search(q: string): any;
    }

    //export class Crud<T, Key> extends Master.Repo.ICrud {

    //}
}