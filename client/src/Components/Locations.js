import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import {Map, InfoWindow, Marker, GoogleApiWrapper} from 'google-maps-react'

const style = {
    width: '100%',
    height: '100%',
    padding: '0px 100px 0px 100px',
}

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
       <Map 
       style={style}
       google={this.props.google} 
    // center= <===Lat & Long
       zoom={4}>
         
         <Marker onClick={this.onMarkerClick}
                 name={'Current location'} />
        
         <InfoWindow onClose={this.onInfoWindowClose}>
             <div>
             </div>
         </InfoWindow>
        </Map>
            {this.state.stations.map((station, i)=> {
          return (
            <div key={i}>
              <div>
              <ul>
              <Link to={"/results/" + station.stationId}><li>Station ID: {station.stationId}</li></Link >
              <li>{station.nickname} Station</li>
              <li>Latitude: {station.lat}</li>
              <li>Longitude: {station.long}</li>
              </ul>
              </div>
            </div>
          );
        })}
                </div>
        </div>
            </div>
            </div>
          </section>
        );
      }
    }

export default GoogleApiWrapper({
    apiKey: ("AIzaSyCbt3UlsCkgvu4tAkPhwP8BYMQ_tiHypI8")
})(Locations)
