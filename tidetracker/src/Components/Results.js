import React, { Component } from 'react';

class Results extends Component {
    constructor(props) {
      super(props)
    
      this.state = {
          name:'',
          water_level:'',
          water_temperature:'',
          wind:'',
          air_pressure:'',
          visibility:'',
          high_low:'',
          currents:'',
      }
    }
    
    componentDidMount () {
        const stationId = "8726724"
        const _url = "https://tidesandcurrents.noaa.gov/api/datagetter?begin_date=20130808 15:00&end_date=20130808 15:06&station=" + stationId + "&product=water_temperature&units=english&time_zone=gmt&application=ports_screen&format=json"
        fetch(_url).then(resp => resp.json())
        .then(newTidesData => {
            console.log(newTidesData)
            this.setState({
                name:newTidesData.metadata.name,
                water_level: newTidesData.metadata.name
            })
        })
    }

    render() {
        return (
            <div>
                <h1>Results</h1>
                <h1>{this.state.name}</h1>
            </div>
        );
    }
}

export default Results;
