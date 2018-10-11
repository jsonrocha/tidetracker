import React, { Component } from "react";
import "./App.css";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Results from "./Components/Results";
import Home from "./Components/Home";
import Locations from "./Components/Locations";
import GMap from "./Components/GMap";

class App extends Component {
  render() {
    return (
      <div className="body">
        <Router>
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/locations/:state" exact component={Locations} />
            <Route path="/results/:station" exact component={Results} />
            <Route exact component={GMap} />
          </Switch>
        </Router>
      </div>
    );
  }
}

export default App;
