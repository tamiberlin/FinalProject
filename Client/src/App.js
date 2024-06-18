import logo from './logo.svg';
// import './App.css';
import Fetch from './Fetch';
import Navigator from './store/navigator';
import { Provider } from 'react-redux';
import {  Route, Routes, Switch } from 'react-router';
import { BrowserRouter } from 'react-router-dom';
import Home from './store/home';
import Flights from './store/flights';
import store from './redux/store';
import ShowCart from './store/showCart';
import OrgenizedTours from './store/orgenizedTours';
import Housing from './store/housing';
import Attractions from './store/attractions';
import Login from './login';



function App() {
  return (
    <div className="App">
      <header className="App-header">
        <BrowserRouter>
          <Provider store={store}>
             <Navigator />
             <Routes>
              <Route exact path="/" element={<Home />}/>
              <Route exact path="/home" element={<Home />}/>
              <Route exact path="/flights" element={<Flights/>} />
              <Route exact path="/showCart" element={<ShowCart/>} />
              <Route exact path="/orgenizedTours" element={<OrgenizedTours/>} />
              <Route exact path="/housing" element={<Housing/>} />
              <Route exact path="/attractions" element={<Attractions/>} />
              <Route exact path="/login" element={<Login/>}/>
             </Routes>
          </Provider>
        </BrowserRouter>
        {/* <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p> */}

        {/* <Fetch>fetch</Fetch> */}

        {/* <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a> */}

      </header>
    </div>
  );
}

export default App;
