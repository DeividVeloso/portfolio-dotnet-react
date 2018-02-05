import React from "react";
import IconButton from "../../../components/icon-button";
import { connect } from "react-redux";
import { withRouter } from "react-router-dom";

import { bindActionCreators } from "redux";
import * as actions from "../../../actions/client-actions";

const ClientList = props => {
  const _redirect = () => {
    props.history.push({
      pathname: "/cliente"
    });
  };

  const _redirectUpdate = (id) => {
    props.history.push({
      pathname: `/cliente/${id}`
    });
  };

  const removeClient = socialCode => {
    props.actions
      .removeClient(socialCode)
      .then(resp => props.actions.loadClientsSuccess());
  };
  const renderBody = () => {
    const list = props.clients || [];
    return list.map(item => {
      return (
        <tr key={item.socialCode}>
          <td>
            {item.socialCode}
          </td>
          <td>
            {item.fullName}
          </td>
          <td>
            {item.email}
          </td>
          <td>
            {item.telephone}
          </td>
          <td>
            <IconButton style="warning" icon="pencil" onClick={() => _redirectUpdate(item.id)} />
            <IconButton
              style="danger"
              icon="trash-o"
              onClick={() => removeClient(item.id)}
            />
          </td>
        </tr>
      );
    });
  };
  return (
    <div>
      <table className="table">
        <thead>
          <tr>
            <th>CPF:</th>
            <th>Nome Completo:</th>
            <th>E-mail:</th>
            <th>Contato:</th>
            <th className="tableActions">Ação</th>
          </tr>
        </thead>
        <tbody>{renderBody()}</tbody>
      </table>
      <IconButton style="primary" icon="plus-circle" onClick={_redirect} />
    </div>
  );
};

const mapStateToProps = state => {
  console.log("state", state.clients.data);
  return { clients: state.clients.data };
};

const mapDispatchToProps = dispatch => {
  return {
    actions: bindActionCreators(actions, dispatch)
  };
};
export default connect(mapStateToProps, mapDispatchToProps)(
  withRouter(ClientList)
);
