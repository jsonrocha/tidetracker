import React, { Component } from 'react';
import './App.css';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import Search from './Components/Search';
import Results from './Components/Results';
import Home from './Components/Home'

class App extends Component {
  render() {
    return (
        <div className="body">
        <Router>
          <Switch>
            <Route path="" component={Home} />
            <Route path="/Search" component={Search}/>
            <Route path="/Results" component={Results}/>
          </Switch>
        </Router>
        </div>
    );
  }
}

export default App;
