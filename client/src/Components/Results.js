import React, { Component } from "react";
import { Link } from 'react-router-dom'

class Results extends Component {
  constructor(props) {
    super(props);

    this.state = {
      name: "",
      water_level: { data: [{}] },
      water_temperature: { data: [{}] },
      air_temperature: { data: [{}] },
      air_pressure: { data: [{}] },
      visibility: "",
      high_low: "",
      currents: "",
      wind: { data: [{}] }
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
  }

  render() {
    return (
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
