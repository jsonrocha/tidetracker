import React, { Component } from 'react';

class Results extends Component {
    constructor(props) {
      super(props)
    
      this.state = {
          name:'',
          water_level:'',
          water_temperature:'',
          wind:'',
          air_temperature:'',
          air_pressure:'',
          visibility:'',
          high_low:'',
          currents:'',
      }
    }
    
    componentDidMount () {
        const stationId = "8726724"
        const products = ['water_temperature', 'water_level', 'air_temperature']
        products.forEach((product) => {
            fetch(`https://tidesandcurrents.noaa.gov/api/datagetter?datum=NAVD&date=latest&station=${stationId}&product=${product}&units=english&time_zone=lst&&format=json`)
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
            <div>
                {/* <h1>{this.state.air_temperature.data}</h1> */}
                <h1>{this.state.water_temperature.data}</h1>
            </div>
        );
    }
}

export default Results;
