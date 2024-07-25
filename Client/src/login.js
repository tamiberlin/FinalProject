import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import {
  MDBBtn,
  MDBContainer,
  MDBCard,
  MDBCardBody,
  MDBCardImage,
  MDBRow,
  MDBCol,
  MDBInput,
  MDBTabsLink,
  // MDBSelect
} from "mdb-react-ui-kit";

function Login() {
  const [username, setUsername] = useState("");
  const [email, setEmail] = useState("");
  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      const response = await axios.get('http://localhost:5135/api/costumer');
      const users = response.data;
      console.log('Fetched users:', users); 

      const user = users.find(
        (user) => user.costumerName == username && user.email == email
      );

      if (user) {
        navigate('/home');
      } else {
        alert('You are not registered, please create an account.');
        navigate('/register');
      }
    } catch (error) {
      console.log('Error fetching users:', error);
    }
  };


  return (
    <center>
      <MDBContainer fluid>
        <MDBRow className="d-flex justify-content-center align-items-center">
          <MDBCol lg="8">
            <MDBCard className="my-5 rounded-3" style={{ maxWidth: "600px" }}>
              <MDBCardImage
                src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/img3.webp"
                className="w-100 rounded-top"
                alt="Sample photo"
              />

              <MDBCardBody className="px-5">
                <form onSubmit={handleSubmit}>
                  <h3 className="mb-4 pb-2 pb-md-0 mb-md-5 px-md-2">
                    welcome to global travel
                  </h3>
                  <MDBInput
                    wrapperClass="mb-4"
                    id="form1"
                    type="text"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    placeholder="user name"
                    required
                  />
                  <MDBInput
                    wrapperClass="mb-4"
                    id="form1"
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    placeholder="email"
                    required
                  />
                  <MDBTabsLink href="./register">
                    new user? regiter now
                  </MDBTabsLink>
                  <MDBBtn
                    type="submit"
                    color="light"
                    rippleColor="dark"
                    className="mb-4"
                  >
                    send
                  </MDBBtn>
                </form>
              </MDBCardBody>
            </MDBCard>
          </MDBCol>
        </MDBRow>
      </MDBContainer>
    </center>
  );
}

export default Login;
