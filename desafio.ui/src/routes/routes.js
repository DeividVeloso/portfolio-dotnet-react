import React from "react";
import { Switch, Route } from "react-router-dom";

import Client from "../components/client/index";
import ClientManage from "../components/client/client-manager/index";
import About from "../components/about/index";

export default props => (
  <Switch>
    <Route exact path="/" component={Client} />
    <Route exact path="/cliente" component={ClientManage} />
    <Route exact path="/cliente/:id" component={ClientManage} />
    <Route path="/clientes" component={Client} />
    <Route path="/sobre" component={About} />
  </Switch>
);
