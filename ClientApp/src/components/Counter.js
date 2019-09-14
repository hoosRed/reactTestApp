import React, { Component } from 'react';
import Auth from '/Users/tylerredshaw/Documents/reactFolder/react2/reactApp/ClientApp/src/Auth/Auth.js';

export class Counter extends Component {
  displayName = Counter.name

  constructor(props) {
    super(props);
    this.state = { currentCount: 0 };
    this.incrementCounter = this.incrementCounter.bind(this);
  }

  incrementCounter() {
    this.setState({
      currentCount: this.state.currentCount + 1
    });
  }
    handleLogin() {
        console.log("handleLogin()");
        const auth = new Auth();
        auth.login();
    }

  render() {
    return (
      <div>
        <h1>Counter</h1>

        <p>This is a simple example of a React component.</p>
        <p>Current count: <strong>{this.state.currentCount}</strong></p>
            <button onClick={this.incrementCounter}>Increment</button>

            <button onClick={this.handleLogin}>Login</button>         
      </div>
    );
  }
}
