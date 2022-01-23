export  interface AuthState{
    isAuth:boolean;
}
export enum AuthActionenum{
    SET_AUTH='SET_AUTH'
}
export interface SetAuthAction {
    type:AuthActionenum.SET_AUTH;
    payload:boolean
}

export type AuthAction=AuthState|SetAuthAction;