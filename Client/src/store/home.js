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
import Card from "../styles/homePageCard";
function Home() {
  return (
    <>
     
      <MDBContainer>
        <h1 style={{textAlign: 'center', marginTop: '75px', fontSize: 80, color: '#007bff'}}>
          Welcome to Global Travel!
        </h1>
        <div
          style={{
            padding: "40px 80px",
            display: "flex",
            flexWrap: "wrap",
            justifyContent: "center",
          }}
        >
          <a href="./flights">
          <Card
            dataImage="https://i.pinimg.com/564x/74/d2/17/74d21788c5f3e36bf831c96bd2436e3b.jpg"
            header="Flights"
            content="find a flight to any destination for the best prices"
          /></a>
          <a href="./attractions">
          <Card
            dataImage="https://i.pinimg.com/564x/9e/5e/88/9e5e88c1ba697098e97e94d512430e66.jpg"
            header="Attractions - What to do?"
            content="find the best attractions for your.
                     spend time in any destination for the best prices."
          /></a>
          <a href="./housing">
          <Card
            dataImage="https://i.pinimg.com/564x/2f/c9/b8/2fc9b85b1bc28125626643566f4d8426.jpg"
            header="Housing"
            content="  find hotels and houses in any location.
                      best owners.
                      best prices."
          /></a>
          <a href="./orgenizedTours">
          <Card
            dataImage="https://i.pinimg.com/564x/3b/6d/fa/3b6dfac3638d607d50e618bc1b3ddd08.jpg"
            header="Orgenized Tours"
            content=" we arranged everithing for you!
                      you just need to pack.
                      best destinations.
                      bedt prices."
          /></a>
        </div>
      </MDBContainer>
    </>
  );
}
export default Home;
