
import React from 'react';

import Home from './Pages/Home';
import Cadastrar from './Pages/Cadastrar';
import NotFound from './Pages/NotFound';

import { BrowserRouter, Switch, Route } from 'react-router-dom'

export default function Routes() {

    return(

    <BrowserRouter>
        <Switch>
          <Route path="/" exact={true} component={Home} />
          <Route path="/cadastrar" component={Cadastrar} />
          <Route path="*" component={NotFound} />
        </Switch>
    </BrowserRouter>

    )
}