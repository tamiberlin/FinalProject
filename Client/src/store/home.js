import {
  MDBCard,
  MDBCardTitle,
  MDBCardText,
  MDBCardOverlay,
  MDBCardImage,
  MDBContainer,
  MDBRow,
  MDBCol,
  MDBCardBody,
} from "mdb-react-ui-kit";

function Home() {
  return (
    <>
      <h1>home page</h1>

       <MDBContainer>
      {/*<MDBRow>
         <MDBCol>  */}
          <a href="./flights" style={{textDecoration: "none"}}>
            <MDBCard>
              <MDBRow className="g-0">
               
                <MDBCol md="8">
                  <MDBCardBody>
                    <MDBCardTitle>Flights</MDBCardTitle>
                    <MDBCardText>
                     find a flight to any destination for the best prices
                    </MDBCardText>
                    <MDBCardText>
                      <small className="text-muted">
                        Last updated 3 mins ago
                      </small>
                    </MDBCardText>
                  </MDBCardBody>
                </MDBCol>
                <MDBCol md="4">
                  <MDBCardImage
                    src="https://i.pinimg.com/564x/74/d2/17/74d21788c5f3e36bf831c96bd2436e3b.jpg"
                    alt="..."
                    fluid
                  />
                </MDBCol>
              </MDBRow>
            </MDBCard>
          </a>
          {/* </MDBCol>
          <MDBCol> */}
          <a href="./attractions" style={{textDecoration: "none"}}>
            <MDBCard>
              <MDBRow className="g-0">
                <MDBCol md="4">
                  <MDBCardImage
                    src="https://i.pinimg.com/564x/9e/5e/88/9e5e88c1ba697098e97e94d512430e66.jpg"
                    alt="..."
                    fluid
                  />
                </MDBCol>
                <MDBCol md="8">
                  <MDBCardBody>
                    <MDBCardTitle>What to do?</MDBCardTitle>
                    <MDBCardText>
                     find the best attractions for your.
                     spend time in any destination for the best prices.
                    </MDBCardText>
                    <MDBCardText>
                      <small className="text-muted">
                        Last updated 10 mins ago
                      </small>
                    </MDBCardText>
                  </MDBCardBody>
                </MDBCol>
              </MDBRow>
            </MDBCard>
          </a>
        {/* </MDBCol>
      </MDBRow> */}
      {/* <MDBRow>
        <MDBCol> */}
          <a href="./housing" style={{textDecoration: "none"}}>
            <MDBCard >
              <MDBRow className="g-0">
               
                <MDBCol md="8">
                  <MDBCardBody>
                    <MDBCardTitle>housing</MDBCardTitle>
                    <MDBCardText>
                      find hotels and houses in any location.
                      best owners.
                      best prices.
                    </MDBCardText>
                    <MDBCardText>
                      <small className="text-muted">
                        Last updated 13 mins ago
                      </small>
                    </MDBCardText>
                  </MDBCardBody>
                </MDBCol>
                <MDBCol md="4">
                  <MDBCardImage
                    src="https://i.pinimg.com/564x/2f/c9/b8/2fc9b85b1bc28125626643566f4d8426.jpg"
                    alt="..."
                    fluid
                  />
                </MDBCol>
              </MDBRow>
            </MDBCard>
          </a>
{/* </MDBCol>
<MDBCol> */}
          <a href="./orgenizedTours" style={{textDecoration: "none"}}>
            <MDBCard>
              <MDBRow className="g-0">
                <MDBCol md="4">
                  <MDBCardImage
                    src="https://i.pinimg.com/564x/3b/6d/fa/3b6dfac3638d607d50e618bc1b3ddd08.jpg"
                    alt="..."
                    fluid
                  />
                </MDBCol>
                <MDBCol md="8">
                  <MDBCardBody>
                    <MDBCardTitle>Orgenized Tours</MDBCardTitle>
                    <MDBCardText>
                      we arranged everithing for you!
                      you just need to pack.
                      best destinations.
                      bedt prices.
                    </MDBCardText>
                    <MDBCardText>
                      <small className="text-muted">
                        Last updated 3 mins ago
                      </small>
                    </MDBCardText>
                  </MDBCardBody>
                </MDBCol>
              </MDBRow>
            </MDBCard>
          </a>
        {/* </MDBCol>
      </MDBRow>*/}
      </MDBContainer> 
    </>
  );
}
export default Home;
