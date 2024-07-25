import React from 'react';
import { useParams } from 'react-router-dom';
import {
  MDBCard,
  MDBCardBody,
  MDBCardTitle,
  MDBCardText,
  MDBCardImage,
  MDBContainer,
  MDBBtn
} from 'mdb-react-ui-kit';


function TourDetails() {
  return (
    <>
    <MDBContainer>
      <MDBCard className='mb-3' style={{margin: '40px', borderRadius: '25px'}}>
        <MDBCardImage position='top' src='https://mdbootstrap.com/img/new/slides/041.webp' alt='...' style={{borderRadius:'25px'}} />
        <MDBCardBody>
          <MDBCardTitle>Card title</MDBCardTitle>
          <MDBCardText>
            This is a wider card with supporting text below as a natural lead-in to additional content. This
            content is a little bit longer.
          </MDBCardText>
          <MDBCardText>
            <small className='text-muted'>Last updated 3 mins ago</small>
          </MDBCardText>
        </MDBCardBody>
        <MDBBtn  className='mx-2' toggle>
          Book Now
        </MDBBtn>
      </MDBCard>
      </MDBContainer>
    </>

  );
}
export default TourDetails;