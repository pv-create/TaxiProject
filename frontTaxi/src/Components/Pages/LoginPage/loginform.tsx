import React, {FC} from 'react';
import {useState} from "react";
import { useTrail, animated as a } from "react-spring";
import {useSpring} from "react-spring";
import { Button } from 'antd';


const LoginForm:FC = (props:any) => {


    const [greetingStatus, displayGreeting] = useState(false);
    const contentProps = useSpring({
        opacity: greetingStatus ? 1 : 0,
        duration:2000000000000000000000000000000000,
        marginTop: greetingStatus ? 0 : -500
    });

    return (
            <div className="card-body p-5 text-center">
                <div className="button-container">
                    <Button style={{visibility: greetingStatus?'hidden':"visible", borderRadius: '20px'}}  onClick={() => displayGreeting(a => !a)} className="button">
                        да да сюда
                    </Button>

                </div>
                {!greetingStatus ? (
                    <div className="Intro">Нажмите на кнопку</div>
                ) : (
                    <a.div className="mb-md-5 mt-md-4 pb-5-box" style={contentProps}>

                        <h2 className="fw-bold mb-2 text-uppercase">Login</h2>
                        <p className="text-white-50 mb-5">Please enter your login and password!</p>

                        <div className="form-outline form-white mb-4">
                            <input type="email" id="typeEmailX" className="form-control form-control-lg"/>
                            <label className="form-label" htmlFor="typeEmailX">Email</label>
                        </div>

                        <div className="form-outline form-white mb-4">
                            <input type="password" id="typePasswordX"
                                   className="form-control form-control-lg"/>
                            <label className="form-label" htmlFor="typePasswordX">Password</label>
                        </div>

                        <p className="small mb-5 pb-lg-2"><a className="text-white-50" href="#!">Forgot
                            password?</a></p>

                        <button className="btn btn-outline-light btn-lg px-5" type="submit">Login</button>

                        <div className="d-flex justify-content-center text-center mt-4 pt-1">
                            <a href="#!" className="text-white"><i className="fab fa-facebook-f fa-lg"></i></a>
                            <a href="#!" className="text-white"><i
                                className="fab fa-twitter fa-lg mx-4 px-2"></i></a>
                            <a href="#!" className="text-white"><i className="fab fa-google fa-lg"></i></a>
                        </div>

                    </a.div>
                )}
            </div>
    );
};

export default LoginForm;
