import React, { Component } from "react";
import Select from "react-select";
import { Link } from "react-router-dom";

const options = [
  { value: "alabama", label: "Alabama" },
  { value: "alaska", label: "Alaska" },
  { value: "california", label: "California" },
  { value: "connecticut", label: "Connecticut" },
  { value: "delaware", label: "Delaware" },
  { value: "florida", label: "Florida" },
  { value: "georgia", label: "Georgia" },
  { value: "hawaii", label: "Hawaii" },
  { value: "louisiana", label: "Louisiana" },
  { value: "maine", label: "Maine" },
  { value: "maryland", label: "Maryland" },
  { value: "massachusetts", label: "Massachusetts" },
  { value: "mississippi", label: "Mississippi" },
  { value: "new jersey", label: "New Jersey" },
  { value: "new york", label: "New York" },
  { value: "north carolina", label: "North Carolina" },
  { value: "oregon", label: "Oregon" },
  { value: "pennsylvania", label: "Pennsylvania" },
  { value: "rhode island", label: "Rhode Island" },
  { value: "south carolina", label: "South Carolina" },
  { value: "texas", label: "Texas" },
  { value: "virginia", label: "Virginia" },
  { value: "washington", label: "Washington" }
];

class Home extends Component {
  state = {
    selectedOption: {}
  };
  handleChange = selectedOption => {
    this.setState({ selectedOption });
    console.log("Option selected:", selectedOption.label);
  };
  render() {
    const { selectedOption } = this.state;

    const Dropdown = () => (
      <Select
        options={options}
        value={selectedOption}
        onChange={this.handleChange}
      />
    );
    return (
      <div className="background">
        <div className="content">
          <header className="App-header">
            <Link to="/">
              <span className="menu2 size glyphicon glyphicon-circle-arrow-left" />
            </Link>
            <span className="tidetracker">
            <Link to="/">
              <img src="../images/tidetrackerlogo.png" alt="TIDE-TRACKER" width="339px;" height="57px;"/>
              </Link>
            </span>
            <span className="menu2 size glyphicon glyphicon glyphicon-circle-arrow-left" />
          </header>
          <div className="container">
            <h3 className="welcome1">Find Your Local Weather Station!</h3>
            <h3 className="welcome2">
              Get real-time coastal weather conditions based on your state
            </h3>
            <div className="search">
              <label className="searchlabel">Enter State/Province:</label>
              <Dropdown />
              <Link disabled={!this.state.selectedOption.label}
                className="plain"
                to={"/locations/" + this.state.selectedOption.label}
              >
                <button disabled={!this.state.selectedOption.label}>
                  <span className="glyphicon glyphicon-search" />
                </button>
              </Link>
            </div>
            <label className="disclaimer">
              * Landlocked/Excluded States: AR, AZ, CO, KS, KY, IA, ID, IL, IN, MI, MN,
              MO, MT, ND, NE, NH, NM, NV, OH, OK, SD, TN, UT, VT, WV, WY
            </label>
          </div>
        </div>
      </div>
    );
  }
}

export default Home;
