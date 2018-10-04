import React, { Component } from 'react';
import GMap from './GMap'

class Locations extends Component {
    constructor(props) {
        super(props);
        this.state = {
          stations: []
        };
      }
      
    componentDidMount() {
        fetch("https://localhost:5001/api/weatherstations/" + this.props.match.params.state)
          .then(resp => resp.json())
          .then(stationsData => {
            console.log(stationsData);
            this.setState({
              stations:stationsData
            });
          });
    
      }

    render() {
        console.log(this.props.match.params.state)
        return (
            <section>
            <div className="background">
            <div className="content">
            <header className="App-header">
        <span className="menu size glyphicon glyphicon-align-justify"></span>
        <span><span className="title"><span className="glyphicon glyphicon-tint"></span>TIDE TRACKER 2K18 <span className="glyphicon glyphicon-tint"></span></span></span>
        </header>
        <div className="container">
        <div className="search">
       {/* ** GOOGLE MAP GOES HERE. MARKER WILL HAVE i KEY ** */}
        <GMap stations={this.state.stations} />
       </div>
        </div>
            </div>
            </div>
          </section>
        );
      }
    }

export default Locations;
