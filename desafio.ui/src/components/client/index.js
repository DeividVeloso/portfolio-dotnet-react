import React from "react";

import PageHeader from "../page-header";

import ClientList from "./client-list/index";

export default props => (
  <div>
    <PageHeader name="Clientes" small="Cadastro" />
    <ClientList />
  </div>
);
