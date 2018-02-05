import React from "react";
import { Link } from "react-router-dom";

export default props => (
  <nav className="navbar navbar-inverse bg-inverse">
    <div className="container">
      <div className="navbar-header">
        <Link className="navbar-brand" to="/">
          <i className="fa fa-calendar-check-o" /> Clientes
        </Link>
      </div>
      <div className="navbar-collapse collapse">
        <ul className="nav navbar-nav">
          <li><Link to="/clientes">Clientes</Link></li>
          <li><Link to="/sobre">Sobre</Link></li>
        </ul>
      </div>
    </div>
  </nav>
);
