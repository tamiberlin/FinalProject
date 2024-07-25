import logo from './logo.svg';
// import './App.css';
import Fetch from './Fetch';
import Navigator from './store/navigator';
import Footer from './store/footer';
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
import Register from './register';
import TourDetails from './store/tour_details';
import Tours from './store/selfOrgenizedTours';


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
              <Route exact path="/register" element={<Register/>}/>
              <Route exact path="/tour_details" element={<TourDetails/>} />
              <Route exact path="/selfOrgenizedTours" element={<Tours/>} />
             </Routes>
             <Footer />
          </Provider>
        </BrowserRouter>
        

        {/* <Fetch>fetch</Fetch> */}

      </header>
    </div>
  );
}

export default App;
