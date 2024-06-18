import React from "react";
import CartStyle from "./cartStyle";
import Payment from './payment';
import { useSelector } from "react-redux";
import { useNavigate } from "react-router";

export default function ShowCart(){
    const cart = useSelector((state) => state.cartReducer)
    const navigate = useNavigate()
    return(
        <>
        <h1>
        Cart
        </h1>
        <CartStyle></CartStyle>
        </>
    )
}