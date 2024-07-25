import React, { useState, useEffect } from 'react';
import fetchFlights from '../fetchData/fetch_flights';
import {
  MDBCard,
  MDBCardBody,
  MDBContainer,
  MDBRow,
  MDBCol,
  MDBCardImage,
  MDBIcon,
  MDBRipple,
  MDBBtn,
} from 'mdb-react-ui-kit';
import "../styles/flight_style.css";

function FlightStyle() {
  const [flights, setFlights] = useState([]);
  const [filteredFlights, setFilteredFlights] = useState([]);

  useEffect(() => {
    async function fetchFlightData() {
      try {
        const data = await fetchFlights();
        setFlights(data);
        setFilteredFlights(data);
        console.log(flights);
      } catch (error) {
        console.error('Error fetching flights:', error);
      }
    }
    fetchFlightData();
  }, []);

  

  return (
    <MDBContainer fluid>
      <MDBRow className="justify-content-center mb-0">
        <MDBCol md="12" xl="10">
          {filteredFlights.length > 0 ? (
            filteredFlights.map((flight) => (
              <MDBCard key={flight.id} className="shadow-0 border rounded-3 mt-5 mb-3">
                <MDBCardBody>
                  <MDBRow>
                    <MDBCol md="12" lg="3" className="mb-4 mb-lg-0">
                      <MDBRipple
                        rippleColor="light"
                        rippleTag="div"
                        className="bg-image rounded hover-zoom hover-overlay"
                      >
                        <MDBCardImage
                          src="https://mdbcdn.b-cdn.net/img/Photos/Horizontal/E-commerce/Products/img%20(4).webp"
                          fluid
                          className="w-100"
                        />
                        <a href="#!">
                          <div
                            className="mask"
                            style={{ backgroundColor: "rgba(251, 251, 251, 0.15)" }}
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
                        <span>Departure: {flight.departureCode}</span>
                        <span className="text-primary"> • </span>
                        <span>Destination: {flight.destinationCode}</span>
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
                      <h6 className="text-success">Free shipping</h6>
                      <div className="d-flex flex-column mt-4">
                        <MDBBtn color="primary" size="sm">
                          Details
                        </MDBBtn>
                        <MDBBtn outline color="primary" size="sm" className="mt-2">
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
  );
}

export default FlightStyle;
