import React from 'react';
import {Link} from 'react-router-dom';

import './home.css';
import Cabecalho from '../../Components/Cabecalho';
import Rodape from '../../Components/Rodape';

import exames from './imagens/exames.png';
import cirurgia from './imagens/cirurgia.png';
import vacina from './imagens/vacina.png';
import banhotosa from './imagens/banhotosa.png';
import hospedagem from './imagens/hospedagem.png';

export default function Home()  {
    return (
    <body>

    <div classNameName="inicio">

        <Cabecalho />

        <div className="servicos">

            <div className="titservicos"> O que a Kitsune Vet faz </div>

            <div className="imgservicos">

                <div className="subbox"> 
                    <img src={hospedagem} width="120px" height="120px" alt="NotFound"/>
                    <div className="minibox"> <h3>Hospedagem</h3> </div>
                    <div className="A"><button type="button">Agendar</button></div>
                </div>

                <div className="subbox"> 
                    <img src={vacina} width="120px" height="120px" alt="NotFound"/>
                    <div className="minibox"> <h3>Vacinas</h3> </div>
                    <div className="A"> <Link to="/agendamentovacina"> <button type="button">Agendar</button> </Link> </div>
                </div>

                <div className="subbox"> 
                    <img src={cirurgia} width="120px" height="120px" alt="NotFound"/>
                    <div className="minibox"> <h3>Cirurgia</h3> </div>
                    <div className="A"> <button type="button">Agendar</button> </div>
                </div>

                <div className="subbox">
                    <img src={exames} width="120px" height="120px" alt="NotFound"/>
                    <div className="minibox"> <h3>Exames</h3> </div>
                    <div className="A"> <button type="button">Agendar</button> </div>
                </div>

                <div className="subbox">
                    <img src={banhotosa} width="120px" height="120px" alt="NotFound"/>
                    <div className="minibox"> <h3>Banho e Tosa</h3></div>
                    <div className="A"> <button type="button">Agendar</button> </div>
                </div>

            </div>

        </div>
    
    </div>

    <Rodape />

    </body>

    );

}