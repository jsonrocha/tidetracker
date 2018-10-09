import React, { Component } from "react";
import { Map, InfoWindow, Marker, GoogleApiWrapper } from "google-maps-react";
import { Link } from "react-router-dom";
import { BrowserRouter as Router } from "react-router-dom";

const style = {
  height: "100%",
  width: "100%",
  position: "relative",
  margin: "0px 0px 0px 0px"
};

let bounds;
class GMap extends Component {
  state = {
    showingInfoWindow: false,
    activeMarker: {},
    selectedPlace: {}
  };

  componentDidMount() {}

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
    const points = this.props.stations.map(station => {
      return { lat: station.lat, lng: station.long };
    });
    console.log({ points });
    bounds = new this.props.google.maps.LatLngBounds();
    for (var i = 0; i < points.length; i++) {
      bounds.extend(points[i]);
    }
    console.log({ bounds });

    const lat = this.props.stations.reduce((acc, item) => {return acc+item.lat},0) /this.props.stations.length;
    const lng = this.props.stations.reduce((acc, item) => {return acc+item.long},0) /this.props.stations.length;
    const pos = {
      lat, lng
    }
    console.log({pos})
    return (
      <div className="mapcontainer">
        <Map
          onClick={this.onMapClicked}
          style={style}
          google={this.props.google}
          mapTypeControl={false}
          initialCenter={pos}
          bounds={bounds}
          zoom={5}
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
                <Link
                  to={{
                    pathname: "/results/" + this.state.selectedPlace.Id,
                    state: {
                      selectedPlace: this.state.selectedPlace
                    }
                  }}
                >
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
