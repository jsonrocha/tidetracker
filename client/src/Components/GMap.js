import React, { Component } from "react";
import { Map, InfoWindow, Marker, GoogleApiWrapper } from "google-maps-react";
import { Link } from "react-router-dom";
import { BrowserRouter as Router } from "react-router-dom";

const style = {
  height: "85%",
  position: "relative",
  margin: "0px 0px 0px 0px"
};

class GMap extends Component {
  state = {
    showingInfoWindow: false,
    activeMarker: {},
    selectedPlace: {}
  };

  onMarkerClick = (props, marker, e) => {
    console.log({ props, marker });
    this.setState({
      selectedPlace: props,
      activeMarker: marker,
      showingInfoWindow: true
    });
  };

  onMapClicked = props => {
    if (this.state.showingInfoWindow) {
      this.setState({
        showingInfoWindow: false,
        activeMarker: null
      });
    }
  };

  render() {
    return (
      <div className="mapcontainer">
        <Map
          onClick={this.onMapClicked}
          style={style}
          google={this.props.google}
          mapTypeControl={false}
          initialCenter={{
            lat: 45.854885,
            lng: -105.081807
          }}
          zoom={4}
        >
          {this.props.stations.map((station, i) => {
            return (
              <Marker
                key={i}
                position={{
                  lat: station.lat,
                  lng: station.long
                }}
                onClick={this.onMarkerClick}
                station={station.nickname}
                Id={station.stationId}
              />
            );
          })}
          <InfoWindow
            marker={this.state.activeMarker}
            visible={this.state.showingInfoWindow}
          >
            <div className="center">
              <Router>
              <Link to={{
                  pathname:"/results/" + this.state.selectedPlace.Id,
                  state:{
                    nickname: "hello"
                  }}}>
                  <h4>View Results for:</h4>
                </Link>
              </Router>
              <Router>
                <Link to={{
                  pathname:"/results/" + this.state.selectedPlace.Id,
                  state:{
                    selectedPlace: this.state.selectedPlace
                  }}}>
                  <span className="glyphicon blue glyphicon-tint" />
                  <span className="stationlink">
                    {" "}
                    {this.state.selectedPlace.station} Station{" "}
                  </span>
                  <span className="glyphicon blue glyphicon-tint" />
                </Link>
              </Router>
            </div>
          </InfoWindow>
        </Map>
      </div>
    );
  }
}

export default GoogleApiWrapper({
  apiKey: "AIzaSyCbt3UlsCkgvu4tAkPhwP8BYMQ_tiHypI8"
})(GMap);
