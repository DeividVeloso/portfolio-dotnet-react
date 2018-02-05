import React, { PropTypes } from "react";
import TextInput from "../../common/text-input";

const ClientForm = ({
  client,
  onSave,
  onChange,
  saving,
  errors
}) => {
  return (
    <form>
      <h1>Cadastro Cliente</h1>
      <TextInput
        name="socialCode"
        label="CPF"
        value={client.socialCode}
        onChange={onChange}
        error={errors.title}
      />
      <TextInput
        name="fullName"
        label="Nome Completo"
        value={client.fullName}
        onChange={onChange}
        error={errors.fullName}
      />
      <TextInput
        name="email"
        label="E-mail"
        value={client.email}
        onChange={onChange}
        error={errors.email}
      />
      <TextInput
        name="telephone"
        label="Telefone"
        value={client.telephone}
        onChange={onChange}
        error={errors.telephone}
      />
      <input
        type="submit"
        disabled={saving}
        value={saving ? "Salvando..." : "Salvar"}
        className="btn btn-primary"
        onClick={onSave}
      />
    </form>
  );
};

ClientForm.propTypes = {
  client: PropTypes.object.isRequired,
  onSave: PropTypes.func.isRequired,
  onChange: PropTypes.func.isRequired,
  saving: PropTypes.bool,
  errors: PropTypes.object
};

export default ClientForm;
