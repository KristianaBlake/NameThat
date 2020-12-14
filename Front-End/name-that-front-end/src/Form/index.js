import React, { Component } from "react";


class Form extends React.Component {
  constructor(props) {
    super();
    this.handleChange = this.handleChange.bind(this);
    this.state = {
      title: ""
    };
  }

  handleChange = e => {
    // es6 computed properties [e.currentTarget.name]
    this.setState({title: e.target.value});
  };

  render() {
    return (
        <div>
            <form onSubmit={this.handleSubmit}>
                <label>
                    Name:
                <input type="text" value={this.state.title} onChange={this.handleChange} />
                </label>
                <input type="submit" value="Submit" />
            </form>

        </div>
      
    );
  }
}

export default AdminAddCourse;