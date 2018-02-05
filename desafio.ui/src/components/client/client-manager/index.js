import React, { PropTypes, Component } from "react";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import * as clientActions from "../../../actions/client-actions";
import ClientForm from "../client-form";
import { withRouter } from "react-router-dom";
import toastr from "toastr";

class ClientManage extends Component {
  constructor(props, context) {
    super(props, context);

    this.state = {
      client: Object.assign({}, props.client),
      errors: {},
      saving: false
    };

    this.updateClientState = this.updateClientState.bind(this);
    this.saveClient = this.saveClient.bind(this);
    this.redirect = this.redirect.bind(this);
  }

  componentWillReceiveProps(nextProps) {
    if (this.props.client.id != nextProps.client.id) {
      console.log("nextProps", nextProps.client);
      this.setState({ client: Object.assign({}, nextProps.client) });
    }
  }

  updateClientState(event) {
    const field = event.target.name;
    let client = Object.assign({}, this.state.client);
    client[field] = event.target.value;
    this.setState({ client: client });
  }

  redirect() {
    console.log("redirect", this.props);
    this.setState({ saving: false });
    toastr.success("Cliente salvo com sucesso");
    this.props.history.push({
      pathname: "/clientes"
    });
  }

  saveClient(event) {
    event.preventDefault();
    this.setState({ saving: true });
    if (this.state.client.id) {
      this.props.actions
        .updateClient(this.state.client)
        .then(resp => {
          this.redirect();
        })
        .catch(error => {
          error.map(item => {
            toastr.error(item.value);
          });
          this.setState({ saving: false });
        });
    } else {
      this.props.actions
        .saveClient(this.state.client)
        .then(resp => {
          this.redirect();
        })
        .catch(error => {
          error.map(item => {
            toastr.error(item.value);
          });
          this.setState({ saving: false });
        });
    }
  }

  render() {
    return (
      <ClientForm
        onSave={this.saveClient}
        onChange={this.updateClientState}
        client={this.state.client}
        errors={this.state.errors}
        saving={this.state.saving}
      />
    );
  }
}

ClientManage.propTypes = {
  actions: PropTypes.object.isRequired
};

const getClientById = (clients, id) => {
  const client = clients.filter(client => client.id == id);
  console.log("client", client);
  if (client.length) return client[0]; //Já que o filter sempre retorna um arrray é só pegar o primeiro item
  return null;
};

const mapStateToProps = (state, ownProps) => {
  console.log("state", state);
  console.log("ownProps", ownProps);
  const id = ownProps.match.params.id; //vem do caminho '/client/:id'
  let client = {
    id: "",
    socialCode: "",
    fullName: "",
    email: "",
    telephone: ""
  };

  if (id) {
    client = getClientById(state.clients.data, id);
  }

  return {
    client: client
  };
};

const mapDispatchToProps = dispatch => {
  return {
    actions: bindActionCreators(clientActions, dispatch)
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(
  withRouter(ClientManage)
);
