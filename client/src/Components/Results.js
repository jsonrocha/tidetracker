import React, { Component } from 'react';

class Results extends Component {
    constructor(props) {
      super(props)
    
      this.state = {
          name:'',
          water_level:{data:[{}]},
          water_temperature:{data:[{}]},
          air_temperature:{data:[{}]},
          air_pressure:{data:[{}]},
          visibility:'',
          high_low:'',
          currents:'',
          wind:{data:[{}]},

      }
    }
    
    componentDidMount () {
        const stationId = this.props.match.params.station
        const products = ['water_temperature', 'water_level', 'air_temperature', 'air_pressure', 'wind']
        products.forEach((product) => {
            fetch(`https://tidesandcurrents.noaa.gov/api/datagetter?datum=MLLW&date=latest&station=${stationId}&product=${product}&units=english&time_zone=lst&&format=json`)
                .then(resp => resp.json())
                .then(json =>{
                    console.log(json)
                    this.setState({
                        [product]:json,
                    })
                })
        })
    }

    render() {
        return (
            <div className="background">
            <div className="content">
            <header className="App-header">
        <span className="menu size glyphicon glyphicon-home"></span>
        <span><span className="title"><span className="glyphicon glyphicon-tint"></span>TIDE TRACKER 2K18 <span className="glyphicon glyphicon-tint"></span></span></span>
        </header>
        <div className="container">
        <div className="results">
        <h1>Water Temperature: {this.state.water_temperature.data[0].v}°</h1>
        <h1>Water Level: {(this.state.water_level.data[0].v * 1).toFixed(2)}</h1>
        <h1>Air Temperature: {this.state.air_temperature.data[0].v}°</h1>
        <h1>Air Pressure: {this.state.air_pressure.data[0].v} millibars</h1>
        <h1>Wind: {this.state.wind.data[0].s} knots from {this.state.wind.data[0].dr}</h1>
        </div>
        </div>
            </div>
            </div>
        );
    }
}

export default Results;
