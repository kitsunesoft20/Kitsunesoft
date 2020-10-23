
import React from 'react';
import './home.css';
import cabecalho from '../../Components/Cabecalho';

//Import de Imagens abaixo

import exames from './imagens/exames.png';
import cirurgia from './imagens/cirurgia.png';
import vacina from './imagens/vacina.png';
import banhotosa from './imagens/banhotosa.png';
import hospedagem from './imagens/hospedagem.png';

export default function Home()  {
    return (
    <body>

    <div classNameName="inicio">

        <cabecalho/>

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
                    <div className="A"> <button type="button">Agendar</button> </div>
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

    <div className="rodape">
                
        <div className="box9">

            <div className="miniboxrodape">

                <p> Serviços</p>
                <div className="sep"> </div>

                <p> Privacidade</p>
                <div className="sep"> </div>

                <p> Ajuda</p>
                <div className="sep"> </div>

                <p> Kitsune</p>
                  
            </div>

            <div className="copyright">
                <p>© 2020 Kitsunesoft BR</p> 
            </div>

        </div>
    
    </div>

    </body>

    );

}