import React from 'react';
import ReactDOM from 'react-dom';

import { BrowserRouter, Switch, Route, Link } from 'react-router-dom';

import './index.css';

import App from './App';

import Home from './Pages/Home';
import Cadastrar from './Pages/Cadastrar';

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter>

      <Switch>
        <Route path="/home" component={Home} />
        <Route path="/cadastrar" component={Cadastrar} />
      </Switch>

    </BrowserRouter>
  </React.StrictMode>,
  document.getElementById('root')
);