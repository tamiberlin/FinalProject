export const addToCart = (productToAdd,id) => {
    return {
        type: "ADDTOCART",
        productToAdd,
        id
    
    };
};

export const deleteFromCart = (id) => {
    return {
        type: "DELETEFROMCART",
        id
    };
};
