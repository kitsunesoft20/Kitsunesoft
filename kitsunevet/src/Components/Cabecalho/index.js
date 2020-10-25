
import React from 'react';
import './cabecalho.css';
import logo from './Kitsunelogo.png';

export default function Cabecalho() {
    return(

        <div className="menu">
            <div className="submenu">
                <img src={logo} width="20%" height="20%" alt="NotFound"/>
                <div className="itensmenu">
                    <h4>Home</h4>
                    <div className="sep"> </div>
                    <h4>Cadastre seu Pet</h4>
                    <div className="sep"> </div>
                    <h4> Login </h4>
                    <div className="sep"> </div>
                    <h4> Cadastrar </h4>
                </div>
            </div>
        </div>

    );

}