import React from "react";
import { useSelector, useDispatch } from "react-redux";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import {
    MDBTable,
    MDBTableBody,
    MDBTableHead,
    MDBCard,
    MDBCardBody,
    MDBCardHeader,
    MDBCol,
    MDBContainer,
    MDBRow,
    MDBListGroup,
    MDBListGroupItem
} from "mdb-react-ui-kit";
// import { deleteFromCart } from "../redux/actions/cartActions.js";
// import { addQty, decreaseQty } from "../redux/actions/cartActions.js";

export default function CartStyle() {
    const cart = useSelector((state) => state.cartReducer)
    const dispatch = useDispatch()
    const [qtyInCart, setQtyInCart] = useState();
    const [qty, setQty] = useState();
    
    return (
        <div>
            <MDBContainer className="py-5">
                <MDBRow>
                    <MDBCol md="8" className="mb-4">
                        <MDBCol >
                            <MDBTable responsive>
                                <MDBTableHead>
                                    <tr>
                                        <th scope="col" className="h5">
                                            Shopping Bag
                                        </th>
                                        <th scope="col"> </th>
                                        <th scope="col">Quantity</th>
                                        <th scope="col">Price</th>
                                        <th scope="col"> hhhhhh </th>
                                    </tr>
                                </MDBTableHead>
                                {cart.map((item) => (<>
                                    <MDBTableBody>
                                        <tr>
                                            <th scope="row">
                                                <div className="d-flex align-items-center">
                                                    <img
                                                        src={item.image1}
                                                        fluid
                                                        className="rounded-3"
                                                        style={{ width: "120px" }}
                                                        alt="Book"
                                                    />
                                                    <div className="flex-column ms-4">
                                                        <p className="mb-2">{item.description}</p>
                                                    </div>
                                                </div>
                                            </th>
                                            <td className="align-middle">
                                                <p className="mb-0" style={{ fontWeight: "500" }}>
                                                    uuuuuu
                                                </p>
                                            </td>
                                            <td className="align-middle">
                                                {/* <div class="d-flex flex-row align-items-center">

                                                    <button onClick={(e) => {
                                                        e.preventDefault();
                                                        if(item.qty >0)
                                                        {dispatch(decreaseQty(item.id));
                                                        setQtyInCart(item.qtyInCart++);}
                                                        else{alert("no more in stock")}
                                                    }}>+</button>

                                                    <p className="mb-0" style={{ fontWeight: "500" }}>{item.qtyInCart}</p>
                                                    <button onClick={(e) => {
                                                        e.preventDefault();
                                                        if(item.qtyInCart >1){
                                                        dispatch(addQty(item.id));
                                                        setQtyInCart(item.qtyInCart--);}
                                                    }}>-</button>
                                                </div> */}
                                            </td>
                                            <td className="align-middle">
                                                <p className="mb-0" style={{ fontWeight: "500" }}>
                                                    {item.price}
                                                </p>
                                            </td>
                                            <td className="align-middle">
                                                {/* <p className="mb-0" style={{ fontWeight: "500" }}>
                                                    <button class="btn btn-white" onClick={(e) => {
                                                        e.preventDefault();
                                                        setQty(item.qty+=item.qtyInCart);
                                                        setQtyInCart(item.qtyInCart=0);
                                                        dispatch(deleteFromCart( item.id));
                                                    }}>🗑</button>
                                                </p> */}
                                            </td>
                                        </tr>
                                    </MDBTableBody>
                                </>))}
                            </MDBTable>
                        </MDBCol>
                    </MDBCol>
                    {/* <MDBCol md="4" className="mb-4">
                        <MDBCard className="mb-4">
                            <MDBCardHeader className="py-3">
                                <h5 className="mb-0">Summary</h5>
                            </MDBCardHeader>
                            <MDBCardBody>
                                <MDBListGroup flush>
                                    <MDBListGroupItem className="d-flex justify-content-between align-items-center border-0 px-0 pb-0">
                                        Products
                                        <span>$53.98</span>
                                    </MDBListGroupItem>
                                    <MDBListGroupItem className="d-flex justify-content-between align-items-center border-0 px-0 pb-0">
                                        Shipping
                                        <span>Gratis</span>
                                    </MDBListGroupItem>
                                    <hr className="my-2"></hr>
                                    <MDBListGroupItem className="d-flex justify-content-between align-items-center border-0 px-0 pb-0">
                                        <div>
                                            <strong>Total amount</strong>
                                            <strong>
                                                <p className="mb-0">(including VAT)</p>
                                            </strong>
                                        </div>
                                        <span>
                                            <strong> total</strong>
                                        </span>
                                    </MDBListGroupItem>
                                </MDBListGroup>
                            </MDBCardBody>
                        </MDBCard>
                    </MDBCol> */}
                </MDBRow>
            </MDBContainer>
           
        </div>
        
    );

}