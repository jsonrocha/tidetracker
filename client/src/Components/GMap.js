import React, { Component } from "react";
import { Map, InfoWindow, Marker, GoogleApiWrapper } from "google-maps-react";
import { Link } from "react-router-dom";
import { BrowserRouter as Router } from "react-router-dom";

const style = {
  width: "60%",
  height: "80%",
  display: "flex",
  padding: "0px 0px 0px 0px"
};

// **BOUNDS ATTEMPT..NEED GOOGLEPROPS**
// var points = [
//     { lat: 42.02, lng: -77.01 },
//     { lat: 42.03, lng: -77.02 },
//     { lat: 41.03, lng: -77.04 },
//     { lat: 42.05, lng: -77.02 }
// ]

// var bounds = new this.props.google.maps.LatLngBounds();
// for (var i = 0; i < points.length; i++) {
//   bounds.extend(points[i]);
// }

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
          initialCenter={{
            lat: 40.854885,
            lng: -98.081807
          }}
          zoom={2.5}
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
                <Link to={"/results/" + this.state.selectedPlace.Id}>
                  <h4>{this.state.selectedPlace.Id}</h4>
                </Link>
              </Router>
              <Router>
                <Link to={"/results/" + this.state.selectedPlace.Id}>
                  <h4>{this.state.selectedPlace.station} Station</h4>
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
