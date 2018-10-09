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
      `${process.env.REACT_APP_API_URL.trim()}/api/weatherstations/` +
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
              <span title="Back" className="menu size glyphicon glyphicon-circle-arrow-left" />
              </Link>
              <span className="tidetracker">
              <Link to="/">
              <img src="../images/tidetrackerlogo.png" alt="TIDE-TRACKER" width="339px;" height="57px;"/>
              </Link>
              </span>
              <span className="menu2 size glyphicon glyphicon-circle-arrow-left" />
            </header>
            <div className="container">
              <div className="search">
                <GMap
                  stations={this.state.stations}
                />
              </div>
            </div>
          </div>
        </div>
      </section>
    );
  }
}

export default Locations;
