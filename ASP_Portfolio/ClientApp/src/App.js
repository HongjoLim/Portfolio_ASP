import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import {Jobs} from './components/Jobs';
import {Create} from './components/Create';
import {Detail} from './components/Detail';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/jobs' component={Jobs} />
        <Route path='/create' component={Create} />
        <Route path='/detail/:id' component={Detail} />
      </Layout>
    );
  }
}
