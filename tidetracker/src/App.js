import React, { Component } from 'react';
import './App.css';

class App extends Component {
  render() {
    return (
        <div className="body">
        <header className="App-header">
          <h1 className="App-title"> <span class="glyphicon glyphicon-tint"></span>TIDE TRACKER 2K18 <span class="glyphicon glyphicon-tint"></span></h1>
        </header>
        <div className="container">
        <div className="search">
        <label>Enter State/Province:</label>
        <input type="text"></input><button> <span class="glyphicon glyphicon-search"></span></button>
        </div>
       <label className="disclaimer">* Landlocked/Excluded States: MT, ND, SD, NE, ID, NV, UT, AZ, OK, AR, TN, KY, MO, KS, CO, IA</label>
        </div>
        </div>
    );
  }
}

export default App;
