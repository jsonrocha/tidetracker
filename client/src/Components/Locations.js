import React, { Component } from "react";
import GMap from "./GMap";
import { Link } from "react-router-dom";

class Locations extends Component {
  constructor(props) {
    super(props);
    this.state = {
      stations: []
    };
  }

  componentDidMount() {
    fetch(
      "https://localhost:5001/api/weatherstations/" +
        this.props.match.params.state
    )
      .then(resp => resp.json())
      .then(stationsData => {
        console.log(stationsData);
        this.setState({
          stations: stationsData
        });
      });
  }

  render() {
    console.log(this.props.match.params.state);
    return (
      <section>
        <div className="background">
          <div className="content">
            <header className="App-header">
            <Link to="/">
                <span className="menu size glyphicon glyphicon-home" />
              </Link>
              <span className="tidetracker">
                <span className="glyphicon glyphicon-tint" />
                TIDE TRACKER<span className="glyphicon glyphicon-tint" />
                </span>
                <span></span>
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
