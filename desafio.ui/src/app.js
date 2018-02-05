import "modules/bootstrap/dist/css/bootstrap.min.css";
import "modules/font-awesome/css/font-awesome.min.css";
import '../node_modules/toastr/build/toastr.min.css';

import React from "react";
import Menu from "./components/menu";
import Routes from './routes/routes';

export default props => (
  <div className="container">
    <Menu />
    <Routes />
  </div>
);
