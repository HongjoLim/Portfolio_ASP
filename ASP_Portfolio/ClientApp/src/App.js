import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import {Jobs} from './components/Jobs';
import {CreateJob} from './components/CreateJob';
import {JobDetail} from './components/JobDetail';
import {Projects} from './components/Projects';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/jobs' component={Jobs} />
        <Route path='/createJob' component={CreateJob} />
        <Route path='/jobDetail/:id' component={JobDetail} />
        <Route path='/projects' component={Projects} />
      </Layout>
    );
  }
}
