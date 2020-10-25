
import React from 'react';

import Home from './Pages/Home';
import Cadastrar from './Pages/Cadastrar';
import NotFound from './Pages/NotFound';
import vacina from './Pages/Vacina';

import { BrowserRouter, Switch, Route, Router } from 'react-router-dom'

export default function Routes() {

    return(

    <BrowserRouter>
        <Switch>
          <Route path="/" exact={true} component={Home} />
          <Route path="/cadastrar" component={Cadastrar} />
          <Route path="/agendamentohospedagem" component={NotFound} />
          <Route path="/agendamentovacina" component={vacina} />
          <Route path="/agendamentocirurgia" component={NotFound} />
          <Route path="/agendamentoexame" component={NotFound} />
          <Route path="/agendamentobanhoetosa" component={NotFound} />
          <Route path="/acessofuncionario" component={NotFound} />
          <Route path="*" component={NotFound} />
        </Switch>
    </BrowserRouter>

    )
}