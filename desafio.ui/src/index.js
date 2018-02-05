import React from "react";
import ReactDOM from "react-dom";
import App from "./app";

import promise from "redux-promise";
import thunk from "redux-thunk";

import { applyMiddleware, createStore } from "redux";
import { Provider } from "react-redux";

import configureStore from "./store/config-store";
import { loadClientsSuccess } from "./actions/client-actions";
import { HashRouter } from "react-router-dom";

const store = configureStore();
store.dispatch(loadClientsSuccess());

ReactDOM.render(
  <Provider store={store}>
    <HashRouter>
      <App />
    </HashRouter>
  </Provider>,
  document.getElementById("app")
);
