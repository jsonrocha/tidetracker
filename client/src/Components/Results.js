import React, { Component } from "react";
import { Link } from "react-router-dom";
import Locations from "./Locations";

class Results extends Component {
  constructor(props) {
    super(props);

    this.state = {
      water_level: { data: [{}] },
      water_temperature: { data: [{}] },
      air_temperature: { data: [{}] },
      air_pressure: { data: [{}] },
      wind: { data: [{}] },
      stations: {}
    };
  }

  componentDidMount() {
    const stationId = this.props.match.params.station;
    const products = [
      "water_temperature",
      "water_level",
      "air_temperature",
      "air_pressure",
      "wind"
    ];

    products.forEach(product => {
      fetch(
        `https://tidesandcurrents.noaa.gov/api/datagetter?datum=MLLW&date=latest&station=${stationId}&product=${product}&units=english&time_zone=lst&&format=json`
      )
        .then(resp => resp.json())
        .then(json => {
          console.log(json);
          this.setState({
            [product]: json
          });
        });
    });

    fetch("https://localhost:5001/api/weatherresults/" + stationId)
      .then(resp => resp.json())
      .then(stationsData => {
        console.log(stationsData);
        this.setState({
          stations: stationsData
        });
      });
  }

  render() {
    return (
      <div className="background">
        <div className="content2">
          <header className="App-header">
            <Link to={`/locations/${this.state.stations.state}`}>
              <span
                title="Back"
                className="menu size glyphicon glyphicon-circle-arrow-left"
              />
            </Link>
            <span className="tidetracker">
              <span className="glyphicon glyphicon-tint" />
              TIDE TRACKER
              <span className="glyphicon glyphicon-tint" />
            </span>
            <span className="menu2">Back</span>
          </header>
          <div className="container">
            <div className="resultstext">
              <h2>Station ID: {this.props.match.params.station}</h2>
              <h2>
                {this.state.stations.nickname} Station,{" "}
                {this.state.stations.state}
              </h2>
            </div>
            <div className="results">
              <table>
                <thead>
                  <tr>
                    <th scope="col" colSpan="1">
                      DATA
                    </th>
                    <th scope="col" colSpan="1">
                      VALUE
                    </th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>
                      <strong className="book-title">Water Temperature</strong>
                    </td>
                    <td className="item-price">
                      {this.state.water_temperature.data[0].v}
                      °F
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <strong className="book-title">Water Level</strong>
                    </td>
                    <td className="item-price">
                      {(this.state.water_level.data[0].v * 1).toFixed(2)} ft.
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <strong className="book-title">Air Temperature</strong>
                    </td>
                    <td className="item-price">
                      {this.state.air_temperature.data[0].v}
                      °F{" "}
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <strong className="book-title">Air Pressure</strong>
                    </td>
                    <td className="item-price">
                      {this.state.air_pressure.data[0].v} millibars
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <strong className="book-title">Winds</strong>
                    </td>
                    <td className="item-price">
                      {this.state.wind.data[0].s} knots from{" "}
                      {this.state.wind.data[0].dr}
                    </td>
                  </tr>
                </tbody>
                <tfoot />
              </table>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Results;
