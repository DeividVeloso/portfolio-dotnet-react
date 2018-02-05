import axios from "axios";
import { CLIENT_LISTED, CLIENT_CREATED } from "../actions-types";

const URL = "http://localhost:1062/api";

export const loadClientsSuccess = () => {
  return axios.get(`${URL}/client`).then(resp => {
    console.log("clients", resp.data);
    return {
      type: CLIENT_LISTED,
      payload: resp
    };
  });
};

export const createClientSuccess = () => {
  return { type: CLIENT_CREATED, payload: null };
};

export const saveClient = client => dispatch =>
  new Promise((resolve, reject) => {
    fetch(`${URL}/client`, {
      method: "post",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json"
      },
      body: JSON.stringify(client)
    })
      .then(res => res.json())
      .then(res => {
        if (res && res.errors) {
          reject(res.errors);
        }
        dispatch(createClientSuccess());
        dispatch(loadClientsSuccess());
        resolve();
      })
      .catch(error => reject(error));
  });

export const updateClient = client => dispatch =>
  new Promise((resolve, reject) => {
    fetch(`${URL}/client/${client.id}`, {
      method: "put",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json"
      },
      body: JSON.stringify(client)
    })
      .then(res => res.json())
      .then(res => {
        if (res && res.errors) {
          reject(res.errors);
        }
        dispatch(loadClientsSuccess());
        resolve();
      })
      .catch(error => reject(error));
  });

export const removeClient = id => dispatch =>
  new Promise((resolve, reject) => {
    fetch(`${URL}/client/${id}`, {
      method: "delete",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json"
      },
      body: JSON.stringify(id)
    })
      .then(res => res.json())
      .then(res => {
        resolve(res);
      })
      .catch(error => reject(error));
  });
