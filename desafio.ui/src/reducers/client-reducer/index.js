import intialState from "../initialState";
import { CLIENT_LISTED, CLIENT_CREATED } from "../../actions/actions-types";

export default (state = intialState.clients, action) => {
  switch (action.type) {
    case "CLIENT_LISTED":
      return { ...state, ...action.payload };

    case "CLIENT_CREATED":
      return { 
        ...state, 
        ...action.payload 
      };

    default:
      return state;
  }
};
