import React, { Component } from 'react';
import "./Login.css"; 
import { Button, FormGroup, FormControl, ControlLabel } from "react-bootstrap";



export class Login extends Component {
  displayName = Login.name

   constructor(props) {
    super(props);
    this.handleSubmit = this.handleSubmit.bind(this);



    this.state = {
      name: "",
      email: "",
      id: ""
    };
  }
  
  validateForm() {
    return this.state.email.length > 0 && this.state.id.length > 0;
  }

  handleChange = event => {
    this.setState({
      [event.target.id]: event.target.value
    });
  }

  handleSubmit = event => {
    event.preventDefault();
    console.log(this.state.name);
    
    const data = {
    	name: this.state.name,
    	email: this.state.email,
    	id: this.state.id
    };

        
    fetch('/api/FinancialData/Signup', {
      method: 'POST',
      body: JSON.stringify(data),

    });
  }

  render() {
    return (
      <div className="Login">
        <form onSubmit={this.handleSubmit}>
          <FormGroup controlId="name" bsSize="large">
            <ControlLabel>Name</ControlLabel>
            <FormControl
              autoFocus
              type="text"
              value={this.state.name}
              onChange={this.handleChange}
            />
          </FormGroup>  
          <FormGroup controlId="email" bsSize="large">
            <ControlLabel>Email</ControlLabel>
            <FormControl
              type="email"
              value={this.state.email}
              onChange={this.handleChange}
            />
          </FormGroup>
          <FormGroup controlId="id" bsSize="large">
            <ControlLabel>Id</ControlLabel>
            <FormControl
              value={this.state.id}
              onChange={this.handleChange}
              type="number"
            />
          </FormGroup>
          <Button
            block
            bsSize="large"
            disabled={!this.validateForm()}
            type="submit"
          >
            Login
          </Button>
        </form>
      </div>
    );
  }
}
