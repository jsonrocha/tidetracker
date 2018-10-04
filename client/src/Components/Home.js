import React, { Component } from 'react';
import Select from 'react-select';
import { Link } from 'react-router-dom';

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

class Home extends Component {
    state= {
        selectedOption: {},
    }
    handleChange = (selectedOption) => {
        this.setState({ selectedOption });
        console.log('Option selected:', selectedOption.label);
    }
    render() {
        const { selectedOption } = this.state
        
            const Dropdown = () => (
                <Select options={options} value={selectedOption} onChange={this.handleChange} />
                    )
        return (
            <div className="background">
            <div className="content">
            <header className="App-header">
            <Link to="/"><span className="menu size glyphicon glyphicon-home"></span></Link>
        <span><span className="title"><span className="glyphicon glyphicon-tint"></span>TIDE TRACKER 2K18 <span className="glyphicon glyphicon-tint"></span></span></span>
        </header>
        <div className="container">
        <div className="search">
        <label className="searchlabel">Enter State/Province:</label>
        <Dropdown /><Link className="plain" to={"/locations/"+this.state.selectedOption.label}><button><span className="glyphicon glyphicon-search"></span></button></Link>
        </div>
       <label className="disclaimer">* Landlocked/Excluded States: MT, ND, SD, NE, ID, NV, UT, AZ, OK, AR, TN, KY, MO, KS, CO, IA</label>
        </div>
            </div>
            </div>
        );
    }
}

export default Home;