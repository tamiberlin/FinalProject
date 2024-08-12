import React, { useState, useEffect } from "react";
import fetchFlights from "../fetchData/fetch_flights.js";
import fetchDestinations from "../fetchData/fetch_destinations.js";
// import axios from 'axios';
// import FlightStyle from "../styles/flights_style.js";
import {
  MDBCard,
  MDBBtn,
  MDBContainer,
  MDBCardBody,
  MDBRow,
  MDBCol,
  MDBCardImage,
  MDBIcon,
  MDBRipple,
  MDBInput
} from "mdb-react-ui-kit";
import "../styles/flight_style.css";

function Flights() {
  const [destinations, setDestinations] = useState([]);
  const [filteredDestinations, setFilteredDestinations] = useState([]);
  const [flights, setFlights] = useState([]);
  const [filteredFlights, setFilteredFlights] = useState([]);
  const [search, setSearch] = useState("");
  // Fetch destinations on component mount
  useEffect(() => {
    async function fetchData() {
      try {
        const data = await fetchDestinations();
        setDestinations(data);
        setFilteredDestinations(data);
      } catch (error) {
        console.error("Error fetching destinations:", error);
      }
    }
    fetchData();
  }, []);

  useEffect(() => {
    async function fetchFlightData() {
      try {
        const data = await fetchFlights();
        setFlights(data);
        setFilteredFlights(data);
      } catch (error) {
        console.error("Error fetching flights:", error);
      }
    }
    fetchFlightData();
  }, []);

  function filterByDeparture(event) {
    const query = event.target.value.toLowerCase();
    const filtered = flights.filter((flight) =>
      flight.departureCity.toLowerCase().includes(query) || flight.departureCountry.toLowerCase().includes(query)
    );
    setFilteredFlights(filtered);
  }

  function filterByDestination(event) {
    const query = event.target.value.toLowerCase();
    const filtered = flights.filter((flight) =>
      flight.destinationCity.toLowerCase().includes(query) || flight.destinationCountry.toLowerCase().includes(query)
    );
    setFilteredFlights(filtered);
  }

  function filterByLeavingDate(event) {
    const query = event.target.value.toLowerCase();
    const filtered = flights.filter((flight) =>
      flight.date.toLowerCase().includes(query) || flight.date.toLowerCase().includes(query)
    );
    setFilteredFlights(filtered);
  }

  function handleSearchChange(event) {
    // const value = event.target.value;
    // setSearch(value);
    // const filtered = flights.filter((flight) =>
    //   flight.destinationCode.toLowerCase().includes(value.toLowerCase())
    // );
    // setFilteredFlights(filtered);
  }


  const inputGroupStyle = {
    display: 'flex',
    margin: '20px',
    alignItems: 'center',
    marginBottom: '20px'
  };

  const inputStyle = {
    flex: 1,
    minWidth: '150px',
    marginRight: '10px'
  };

  return (
    <div>
        <div style={inputGroupStyle}>
            <MDBInput
              type="text"
              placeholder="Search departure..."
              name="departure"
              onChange={filterByDeparture}
              defaultValue="Tel-Aviv"
              style={inputStyle}
            />
            <MDBInput
              type="text"
              placeholder="Search destinations..."
              name="destination"
              onChange={filterByDestination}
              style={inputStyle}
            />
            <MDBInput
              type="date"
              placeholder="Check in date"
              name="date"
              onChange={filterByLeavingDate}
              style={inputStyle}
            />
          </div>
      {/* <button type="submit" onClick={filterFlights}>
        search
      </button> */}
      {/* <MDBContainer>
        <ul>
          {filteredDestinations.map((destination) => (
            <li key={destination.id}>
              {destination.cityName}, {destination.countryName}
            </li>
          ))}
        </ul>
      </MDBContainer> */}
      <MDBContainer fluid>
        <MDBRow className="justify-content-center mb-0">
          <MDBCol md="12" xl="10">
            {filteredFlights.length > 0 ? (
              filteredFlights.map((flight) => (
                <MDBCard
                  key={flight.id}
                  className="shadow-0 border rounded-3 mt-5 mb-3"
                >
                  <MDBCardBody>
                    <MDBRow>
                      <MDBCol md="12" lg="3" className="mb-4 mb-lg-0">
                        <MDBRipple
                          rippleColor="light"
                          rippleTag="div"
                          className="bg-image rounded hover-zoom hover-overlay"
                        >
                          <MDBCardImage
                            src="https://i.pinimg.com/564x/f5/08/c9/f508c9658042e5cdca0e93871d013708.jpg"
                            fluid
                            className="w-100"
                          />
                          <a href="#!">
                            <div
                              className="mask"
                              style={{
                                backgroundColor: "rgba(251, 251, 251, 0.15)",
                              }}
                            ></div>
                          </a>
                        </MDBRipple>
                      </MDBCol>
                      <MDBCol md="6">
                        <h5>{flight.company}</h5>
                        <div className="d-flex flex-row">
                          <div className="text-danger mb-1 me-2">
                            <MDBIcon fas icon="star" />
                            <MDBIcon fas icon="star" />
                            <MDBIcon fas icon="star" />
                            <MDBIcon fas icon="star" />
                          </div>
                          <span>310</span>
                        </div>
                        <div className="mt-1 mb-0 text-muted small">
                          <span>Departure: {flight.departureCity + ' ,' +flight.departureCountry}</span>
                          <span className="text-primary"> • </span>
                          <span>Destination: {flight.destinationCity +', '+ flight.destinationCountry}</span>
                          <br />
                        </div>
                        <div className="mb-2 text-muted small">
                          <span>Flight Duration: {flight.date}</span>
                          <br />
                        </div>
                        <p className="text-truncate mb-4 mb-md-0">
                          {flight.price}
                        </p>
                      </MDBCol>
                      <MDBCol
                        md="6"
                        lg="3"
                        className="border-sm-start-none border-start"
                      >
                        <div className="d-flex flex-row align-items-center mb-1">
                          <h4 className="mb-1 me-1">${flight.price}</h4>
                          <span className="text-danger">
                            <s>${flight.price}</s>
                          </span>
                        </div>
                        <div className="d-flex flex-column mt-4">
                          <MDBBtn
                            outline
                            color="primary"
                            size="sm"
                            className="mt-2"
                          >
                            Book Tickets
                          </MDBBtn>
                        </div>
                      </MDBCol>
                    </MDBRow>
                  </MDBCardBody>
                </MDBCard>
              ))
            ) : (
              <p>No flights available</p>
            )}
          </MDBCol>
        </MDBRow>
      </MDBContainer>
    </div>
  );
}

export default Flights;
