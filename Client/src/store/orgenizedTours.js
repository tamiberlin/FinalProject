import React from 'react';
import { Navigate, useNavigate } from 'react-router-dom';
import {
    MDBCard,
    MDBCardImage,
    MDBCardBody,
    MDBCardTitle,
    MDBCardText,
    MDBRow,
    MDBCol,
    MDBContainer
  } from 'mdb-react-ui-kit';
import { GiAerialSignal } from 'react-icons/gi';
  
function OrgenizedTours(){
    const navigate = useNavigate();
    const handleCardClick = (navigate) => (event) => {
        // event.preventDefault();
        navigate('/tour_details'); 
    };
    return(
        <>
        <h1 style={{padding: 30, fontFamily:GiAerialSignal}}>
            orgenized tours - Discover the world
        </h1>
        <MDBContainer>
    <MDBRow className='row-cols-1 row-cols-md-2 g-4'>
      <MDBCol>
        <MDBCard onClick={handleCardClick(navigate)}>
          <MDBCardImage
            src='	https://i.pinimg.com/564x/6e/b9/b7/6eb9b7b9b665b02ca9b0625182e64fd4.jpg'
            alt='...'
            position='top'
          />
          <MDBCardBody>
            <MDBCardTitle>Card title</MDBCardTitle>
            <MDBCardText>
              This is a longer card with supporting text below as a natural lead-in to additional content.
              This content is a little bit longer.
            </MDBCardText>
          </MDBCardBody>
        </MDBCard>
      </MDBCol>
      <MDBCol>
        <MDBCard onClick={handleCardClick}>
          <MDBCardImage
            src='https://mdbootstrap.com/img/new/standard/city/042.webp'
            alt='...'
            position='top'
          />
          <MDBCardBody>
            <MDBCardTitle>Card title</MDBCardTitle>
            <MDBCardText>
              This is a longer card with supporting text below as a natural lead-in to additional content.
              This content is a little bit longer.
            </MDBCardText>
          </MDBCardBody>
        </MDBCard>
      </MDBCol>
      <MDBCol>
        <MDBCard onClick={handleCardClick}>
          <MDBCardImage
            src='https://mdbootstrap.com/img/new/standard/city/043.webp'
            alt='...'
            position='top'
          />
          <MDBCardBody>
            <MDBCardTitle>Card title</MDBCardTitle>
            <MDBCardText>
              This is a longer card with supporting text below as a natural lead-in to additional content.
              This content is a little bit longer.
            </MDBCardText>
          </MDBCardBody>
        </MDBCard>
      </MDBCol>
      <MDBCol>
        <MDBCard onClick={handleCardClick(navigate)}>
          <MDBCardImage
            src='https://mdbootstrap.com/img/new/standard/city/044.webp'
            alt='...'
            position='top'
          />
          <MDBCardBody>
            <MDBCardTitle>Card title</MDBCardTitle>
            <MDBCardText>
              This is a longer card with supporting text below as a natural lead-in to additional content.
              This content is a little bit longer.
            </MDBCardText>
          </MDBCardBody>
        </MDBCard>
      </MDBCol>
    </MDBRow>
    </MDBContainer>
        </>
    );
}
export default OrgenizedTours;