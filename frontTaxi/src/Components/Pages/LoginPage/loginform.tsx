import React from 'react';
import { Form, Input, Button, Checkbox } from 'antd';
import {rules} from "../../../rules/validationrules";
const LoginForm = () => {
    return (
        <div className="mb-md-5 mt-md-4 pb-5">
            <Form>
                <h2 className="fw-bold mb-2 text-uppercase">Login</h2>
                <p className="text-white-50 mb-5">Please enter your Email and password!</p>

                <div className="form-outline form-white mb-4">
                    <Form.Item
                        label="Email"
                        name="username"
                        rules={[
                            rules.required('Please input your Email!')
                        ]}
                    >
                        <input type="email" id="typeEmailX" className="form-control form-control-lg"/>
                    </Form.Item>
                </div>

                <div className="form-outline form-white mb-4">
                    <Form.Item
                        label="Password"
                        name="password"
                        rules={[
                            rules.required('enter your password')
                        ]}
                    >
                        <input type="password" id="typePasswordX"
                               className="form-control form-control-lg"/>
                    </Form.Item>
                </div>

                <p className="small mb-5 pb-lg-2"><a className="text-white-50" href="#!">Forgot
                    password?</a></p>



                <Form.Item>
                    <Button className='btn btn-secondary' htmlType="submit"> Войти </Button>
                </Form.Item>
                {/*<button className="btn btn-outline-light btn-lg px-5" type="submit">Login</button>*/}

                <div className="d-flex justify-content-center text-center mt-4 pt-1">
                    <a href="#!" className="text-white"><i className="fab fa-facebook-f fa-lg"></i></a>
                    <a href="#!" className="text-white"><i
                        className="fab fa-twitter fa-lg mx-4 px-2"></i></a>
                    <a href="#!" className="text-white"><i className="fab fa-google fa-lg"></i></a>
                </div>
            </Form>


        </div>
    );
};

export default LoginForm;
