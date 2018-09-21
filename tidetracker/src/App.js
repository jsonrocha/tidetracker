import React, { Component } from 'react';
import './App.css';
import Select from 'react-select'

const options = [
  { value: 'alabama', label: 'Alabama' },
  { value: 'alaska', label: 'Alaska' },
  { value: 'california', label: 'California' },
  { value: 'connecticut', label: 'Connecticut' },
  { value: 'delaware', label: 'Delaware' },
  { value: 'florida', label: 'Florida' },
  { value: 'georgia', label: 'Georgia' },
  { value: 'hawaii', label: 'Hawaii' },
  { value: 'illinois', label: 'Illinois' },
  { value: 'indiana', label: 'Indiana' },
  { value: 'louisiana', label: 'Louisiana' },
  { value: 'maine', label: 'Maine' },
  { value: 'maryland', label: 'Maryland' },
  { value: 'massachusetts', label: 'Massachusetts' },
  { value: 'michigan', label: 'Michigan' },
  { value: 'minnesota', label: 'Minnesota' },
  { value: 'mississippi', label: 'Mississippi' },
  { value: 'new hampshire', label: 'New Hampshire' },
  { value: 'new jersey', label: 'New Jersey' },
  { value: 'new mexico', label: 'New Mexico' },
  { value: 'new york', label: 'New York' },
  { value: 'north carolina', label: 'North Carolina' },
  { value: 'ohio', label: 'Ohio' },
  { value: 'oregon', label: 'Oregon' },
  { value: 'pennsylvania', label: 'Pennsylvania' },
  { value: 'rhode island', label: 'Rhode Island' },
  { value: 'south carolina', label: 'South Carolina' },
  { value: 'texas', label: 'Texas' },
  { value: 'vermont', label: 'Vermont' },
  { value: 'virginia', label: 'Virginia' },
  { value: 'washington', label: 'Washington' },
  { value: 'west virginia', label: 'West Virginia' },
  { value: 'wisconsin', label: 'Wisconsin' },
  { value: 'wyoming', label: 'Wyoming' },
]

const MyComponent = () => (
  <Select options={options} />
)

class App extends Component {
  render() {
    return (
        <div className="body">
        <header className="App-header">
          <h1 className="App-title"> <span class="glyphicon glyphicon-tint"></span>TIDE TRACKER 2K18 <span class="glyphicon glyphicon-tint"></span></h1>
        </header>
        <div className="container">
        <div className="search">
        <label className="searchlabel">Enter State/Province:</label>
        <MyComponent /><button> <span class="glyphicon glyphicon-search"></span></button>
        </div>
       <label className="disclaimer">* Landlocked/Excluded States: MT, ND, SD, NE, ID, NV, UT, AZ, OK, AR, TN, KY, MO, KS, CO, IA</label>
        </div>
        </div>
    );
  }
}

export default App;
