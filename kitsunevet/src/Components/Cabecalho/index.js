
import React from 'react';
import './cabecalho.css';
import logo from './Kitsunelogo.png';
import { Link } from 'react-router-dom';
import { useState } from 'react';

export default function Cabecalho() {
    
    const [logado, setLogado] = useState(false)

    return(

        <div className="menu">
            <div className="submenu">
                <Link to="/"> <img src={logo} width="35%" height="35%" alt="NotFound"/> </Link>
                
                {logado === false && (

                    <div className="itensmenu">

                        <Link to="/" > <h4>Home</h4> </Link>
                        <div className="sep" > </div>

                        <Link to="/cadastroPet"> <h4>Cadastre seu Pet</h4> </Link>
                        <div className="sep"> </div>
                    
                        <Link to="/login" > <h4> Login </h4> </Link>
                        <div className="sep"> </div>

                        <Link to="/cadastro"> <h4> Cadastrar </h4> </Link>

                    </div>
                )}

                {logado === true && (

                    <div className="itensmenu">

                        <Link to="/" > <h4>Home</h4> </Link>
                        <div className="sep" > </div>

                        <Link to="/cadastroPet"> <h4>Cadastre seu Pet</h4> </Link>
                        <div className="sep"> </div>
                    
                        <h4> Fulano </h4>

                    </div>
                )}
                    
            </div>
        </div>

    );

}