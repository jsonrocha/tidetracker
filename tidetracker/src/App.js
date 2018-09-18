import React, { Component } from 'react';
import './App.css';

class App extends Component {
  render() {
    return (
        <div className="body">
        <header className="App-header">
          <h1 className="App-title">Tide-Tracker v1.0</h1>
        </header>
        <div className="container">
        <div className="search">
        <label>Enter State/Province:</label>
        <input type="text"></input><button>Search</button>
        </div>
       <label className="disclaimer">* Landlocked/Excluded States: MT, ND, SD, NE, ID, NV, UT, AZ, OK, AR, TN, KY, MO, KS, CO, IA</label>
        </div>
        </div>
    );
  }
}

export default App;
