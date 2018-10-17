

import React, { Component } from 'react';

export class TestData extends Component {
  displayName = TestData.name

  constructor(props) {
    super(props);
    this.state = { users: [], loading: true };
   
    fetch('api/FinancialData/StockDataPull')
      .then(response => response.json())
      .then(data => {
        this.setState({ users: data, loading: false });
      });
  }

  static renderUsersTable(users) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>

          </tr>
        </thead>
        <tbody>
          {users.map(user =>
            <tr key={user.id}>
              <td>{user.id}</td>
              <td>{user.name}</td>
              <td>{user.email}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : TestData.renderUsersTable(this.state.users);

    return (
      <div>
        <h1>Fantasy Users Information</h1>
        <p>Current Leaderboard</p>
        {contents}
      </div>
    );
  }
}
