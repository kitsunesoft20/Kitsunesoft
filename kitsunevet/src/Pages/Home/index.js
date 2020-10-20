
import React from 'react';
import './index.css';

export default function Home()  {
    return (
        <div className="inicio">

            <div className="menu">

                <div className="subcontainer">
                    <div className="lista">
                        <h4> Login </h4>
                        <div className="sep"> </div>
                        <h4> Cadastrar </h4>
                        <div className="sep"> </div>
                        <h4>Hospedagem</h4>
                        <div className="sep"> </div>
                        <h4> Cadastrar Pet </h4>
                        <div className="sep"> </div>
                        <h4> Exames </h4>
                        <div className="sep"> </div>
                        <h4> Vacinas </h4>
                    </div>
                
            </div>
    
        </div>
        
        <div className="container3">
            <br><br>
        <div className="box4"> <p>O que a Kitsune Vet faz</p> </div>
            <br></br>

        <div className="box5"> 
            <div className="subbox"> 
                <div className="minibox"> <img src="../Home/imagens/soninho.png" width="120px" height="120px"> </img> </div>
                <div className="minibox2"> <h3>Hospedagem</h3> </div>
                <div className="A"><button type="button">Agendar</button>
             </div>
            </div>

            <div className="subbox"> 
                <div className="minibox"> <img src="../Home/imagens/medico.png" width="120px" height="120px"> </img> </div>
                <div className="minibox2"> <h3>Vacinas</h3> </div>

                <div className="A">
                    <button type="button">Agendar</button>
              </div>
             </div>

            <div className="subbox"> 
                <div className="minibox"> <img src="../Home/imagens/como-funciona-creche-doghero.png"width="120px" height="120px"> </img> </div>
                <div className="minibox2"> <h3>Cirurgia</h3> </div>
                <div className="A">
                 <button type="button">Agendar</button>
              </div>
            </div>

            <div className="subbox">
                <div className="minibox"> <img src="../Home/imagens/alimentação.png"width="120px" height="120px"> </img> </div>
                <div className="minibox2"> <h3>Exames</h3> </div>
                <div className="A">
                    <button type="button">Agendar</button>
            </div>
            </div>

            <div className="subbox">
                <div className="minibox"> <img src="../Home/imagens/passeio.png" width="120px" height="120px"> </img> </div>
                <div className="minibox2"> <h3>Banho e Tosa</h3></div>
                <div className="A">
                    <button type="button">Agendar</button>
                </div>
            </div>

        </div>

        </div>
      
    <div className="rodape">

        <div className='minicontainer5'>

            <div className="box8">
        
            </div>

            <div className="box9">
                <div className="minibox">
                    <p> Serviços</p>
                    <p> Privacidade</p>
                    <p> Ajuda</p>
                    <p> Kitsune</p>
                  
                </div>

                <div className="minibox10">
                    <p>© 2020 Kitsunesoft BR</p>
                    
                </div>
            </div>

        </div>

    </div>
    );

}