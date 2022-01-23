import {ReactNode} from "react";
import {AuthAction, AuthActionenum, AuthState} from "./AuthTypes";
import {SetAuthAction} from "./AuthTypes";

const initialState:AuthState={
    isAuth:false,
}
export default function authReducer(state=initialState, action:SetAuthAction):AuthState
{
    switch (action.type){
        case AuthActionenum.SET_AUTH:
            return {...state, isAuth:action.payload}
        default:
            return state;
    }
}