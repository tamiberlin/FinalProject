import { combineReducers } from "redux";
import { cartReducer } from "./cartReducer";
import { costumerReducer } from './costumerReducer';

export const allReducers = combineReducers({
    cartReducer : cartReducer
})