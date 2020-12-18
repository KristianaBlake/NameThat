import React, { Component } from "react";


class SearchForm extends Component {
  constructor(props) {
    super();
    this.state = {
      title: ""
    };
    this.handleChange = this.handleChange.bind(this);
    this.handleSubmgit = this.handleSubmit.bind(this);
    
  }

  handleChange = e => {
    // es6 computed properties [e.currentTarget.name]
    this.setState({title: e.target.value});
  };

  handleSubmit = e => {
    alert('A title was submitted: ' + this.state.value);
    e.preventDefault();
  }

  render() {
    return (
      <div>
        <form>
            <label>
                Title:
            </label>
            <input type="text" value={this.state.title} onChange={this.handleChangle} /> 
        </form>
        <button onClick={this.handleChange}>
          Search
        </button>
      </div>
    );
  }
}

export default SearchForm;