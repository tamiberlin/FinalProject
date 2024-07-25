import React from 'react'
import { Link } from "react-router-dom";

export default function Navigator() {
  // const navigate = useNavigate();
  return (
    <>
    
      <nav class="navbar navbar-expand-lg navbar-light bg-light navbar sticky-top">
        <div class="container-fluid">
          <Link class="navbar-brand" to="/home" ><img src="https://i.pinimg.com/564x/64/d8/c7/64d8c727ce86ca452c0b2a2a3f7a07a1.jpg" style={{ height: "40px", width: "55px" }} alt = ""></img></Link>
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
              {/* <li class="nav-item">
                <Link class="nav-link active" aria-current="page" to="/home">Home</Link>
              </li> */}
              <li class="nav-item">
                <Link class="nav-link" to="/orgenizedTours" >orgenized Tours</Link>
              </li>
              <li class="nav-item">
                <Link class="nav-link" to="/flights">Flights</Link>
              </li>
              <li class="nav-item">
                <Link class="nav-link" to="/housing" >housing</Link>
              </li>
              <li class="nav-item">
                <Link class="nav-link" to="/attractions" >attractions</Link>
              </li> 
               <li class="nav-item">
                <Link class="nav-link" to="/showCart" >your tours</Link>
              </li>
              <li class="nav-item">
                <Link class="nav-link" to="./login">login</Link>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </>
  )
}
