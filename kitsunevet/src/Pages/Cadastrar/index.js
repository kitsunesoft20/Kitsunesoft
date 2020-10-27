
import React, { useState } from 'react';
import './cadastrar.css';

import KitsuneVetApi from '../../services/KitsuneVetApi';

const api = new KitsuneVetApi();

export default function Cadastrar()  {

    const [Nome, setNome] = useState('')
    const [Sexo, setSexo] = useState('')
    const [Nascimento, setNascimento] = useState('')
    const [Email, setEmail] = useState('')
    const [Telefone, setTelefone] = useState('')
    const [Cpf, setCpf] = useState('')
    const [Rg, setRg] = useState('')
    const [Endereco, setEndereco] = useState('')
    const [Complemento, setComplemento] = useState('')
    const [Cep, setCep] = useState('')
    const [Senha, setSenha] = useState('')


    const SalvarClick = async () => {
        const response = await 
            api.CadastrarCliente({
                Nome: Nome,
                Sexo: Sexo,
                Nascimento: Nascimento,
                Email: Email,
                Telefone: Telefone,
                Cpf: Cpf,
                Rg: Rg,
                Endereço: Endereco,
                Complemento: Complemento,
                Cep: Cep,
                Senha: Senha
            });

            alert('Funfou');

        }

    return (
        <body>
    
            <div class="inicio">

                <div class="fera">

                    <div class="container4">
                        <img src="../Cadastrar/imagens/detalhes.png" width="300px" height="300px" />
                    </div>

                    <div class="container3">

                        <div class="box4"> 
                            {'{'} Cadastro {'}'}
                        </div>

                        <div class="elsa">

                            <div class="dsformularios">
                                <h4> Nome: </h4>
                                <h4> Email: </h4>
                                <h4> Rg: </h4>
                                <h4> Cpf: </h4>
                                <h4> Senha: </h4>
                                <h4> Telefone: </h4>
                                <h4> Endereço: </h4>
                                <h4> Complemento: </h4>
                                <h4> Cep: </h4>
                                <h4> Data de Nascimento: </h4>
                                <h4> Sexo: </h4>
                            </div>

                            <form action="/action_page.php" class="formularios">
                        
                                <input type="text" name="Nome"
                                    value={Nome}
                                    onChange ={x => setNome(x.target.value)}
                                />
                        
                                <input type="text" name="email"
                                    value={Email}
                                    onChange ={x => setEmail(x.target.value)}
                                />

                                <input type="text" name="rg" 
                                    value={Rg}
                                    onChange ={x => setRg(x.target.value)}
                                />
                        
                                <input type="fnumber" name="cpf" 
                                    value={Cpf}
                                    onChange ={x => setCpf(x.target.value)}
                                />
                        
                                <input type="password" name="senha" 
                                    value={Senha}
                                    onChange ={x => setSenha(x.target.value)}
                                />
                       
                                <input type="text" name="telefone" 
                                    value={Telefone}
                                    onChange ={x => setTelefone(x.target.value)}
                                />
                        
                                <input type="text" name="endereco" 
                                    value={Endereco}
                                    onChange ={x => setEndereco(x.target.value)}
                                />

                                <input type="text" name="complemento" 
                                    value={Complemento}
                                    onChange ={x => setComplemento(x.target.value)}
                                />

                                <input type="text" name="cep" 
                                    value={Cep}
                                    onChange ={x => setCep(x.target.value)}
                                />

                                <input type="date" name="datanasc" 
                                    value={Nascimento}
                                    onChange ={x => setNascimento(x.target.value)}
                                />

                                <select name="Sexo" placeholder="Sexo">
                                    <option value="" disabled selected> </option>
                                    <option value="feminino"> Feminino </option>
                                    <option value="masculino"> Masculino </option>
                                    <option value="Prefiro não dizer"> Prefiro não informar </option>
                                    <option value="Outro"> Outro </option>
                                </select>

                            </form>
                                                    
                        </div>

                        <div class="ana">
                            <button onClick={SalvarClick}> Cadastrar </button>
                        </div>

                    </div> 
            
                    <div class="container5">
                        <img src="../Cadastrar/imagens/familia.png" width="300px" height="300px" />
                    </div>

                </div>

            </div>
    
        </body>
    );

}