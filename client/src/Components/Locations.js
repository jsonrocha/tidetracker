import React, { Component } from 'react';
import {Map, InfoWindow, Marker, GoogleApiWrapper} from 'google-maps-react'

const style = {
    width: '100%',
    height: '100%',
    padding: '0px 100px 0px 100px',
}

class Locations extends Component {
    render() {
        return (
            <div className="background">
            <div className="content">
            <header className="App-header">
        <span className="menu size glyphicon glyphicon-align-justify"></span>
        <span><span className="title"><span className="glyphicon glyphicon-tint"></span>TIDE TRACKER 2K18 <span className="glyphicon glyphicon-tint"></span></span></span>
        </header>
        <div className="container">
        <div className="search">
        <Map style={style} google={this.props.google} zoom={4}>
         
         <Marker onClick={this.onMarkerClick}
                 name={'Current location'} />
        
         <InfoWindow onClose={this.onInfoWindowClose}>
             <div>
             </div>
         </InfoWindow>
        </Map>
        </div>
        </div>
            </div>
            </div>
        );
      }
    }

export default GoogleApiWrapper({
    apiKey: ("AIzaSyCbt3UlsCkgvu4tAkPhwP8BYMQ_tiHypI8")
})(Locations)
