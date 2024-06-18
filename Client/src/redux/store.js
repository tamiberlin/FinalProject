import { createStore } from "redux";
import  {allReducers} from "./reducers/combineReducers";

const store = createStore(
    allReducers
)
store.getState()
export default store