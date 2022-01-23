import React, { FC } from 'react';
import './Logincss.css';
import LoginForm from "./loginform";
import {Spring, animated, useTransition} from 'react-spring'
import {useLocation} from "react-router-dom";



const Login:FC = () => {


    return (
        <section className="vh-100 gradient-custom" style={{height:'100%'}}>
            <div className="container py-5 h-100">
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col-12 col-md-8 col-lg-6 col-xl-5">
                        <div className="card bg-dark text-white" style={{borderRadius: "1rem"}}>
                            <LoginForm/>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default Login;
