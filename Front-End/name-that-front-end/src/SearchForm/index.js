import React, { Component } from "react";


class SearchForm extends Component {
  constructor(props) {
    super();
    this.state = {
      title: ""
    };
    this.handleChange = this.handleChange.bind(this);
    
  }

  handleChange = e => {
    // es6 computed properties [e.currentTarget.name]
    this.setState({title: e.target.value});
  };


  render() {
    return (
      <div>
        <form>
            <label>
                Title:
            </label>
            <input type="text" value={this.state.title} onChange={this.handleChange} /> 
        </form>
        <button onClick={this.handleChange}>
          Search
        </button>
      </div>
    );
  }
}

export default SearchForm;