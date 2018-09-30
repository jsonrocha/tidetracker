import React, { Component } from 'react';
import './App.css';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import Search from './Components/Search';
import Results from './Components/Results';
import Home from './Components/Home';
import Locations from './Components/Locations'

class App extends Component {
  render() {
    return (
        <div className="body">
        <Router>
          <Switch>
            <Route path="/home" component={Home} />
            <Route path="/search" component={Search}/>
            <Route path="/results" component={Results}/>
            <Route path="/locations" component={Locations}/>
          </Switch>
        </Router>
        </div>
    );
  }
}

export default App;