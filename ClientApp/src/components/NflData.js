

import React, { Component } from 'react';

export class NflData extends Component {
  displayName = NflData.name

  constructor(props) {
    super(props);
    this.state = { players: [], loading: true };
   
    fetch('api/NflData/ProjectionData')
      .then(response => response.json())
      .then(data => {
        this.setState({ players: data, loading: false });
      });
  }

  static renderUsersTable(players) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>NAME</th>
            <th>POS</th>
            <th>SALARY($)</th>
            <th>POINTS(ppr)</th>
          </tr>
        </thead>
        <tbody>
          {players.map(player =>
            <tr key={player.name}>
              <td>{player.name}</td>
              <td>{player.pos.toUpperCase()}</td>
              <td>{player.sal}</td>
              <td>{player.pts}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : NflData.renderUsersTable(this.state.players);

    return (
      <div>
        <h1>Week 8 NFL Projections</h1>
        {contents}
      </div>
    );
  }
}
