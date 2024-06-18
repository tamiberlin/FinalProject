const cart = [

]
export const cartReducer = (state = cart, action) => {
    switch (action.type) {
        case ("ADDTOCART"):
            const filteredCart = cart.filter((item)=>(item.id == action.id))
            if(filteredCart.length ==0){
                cart.push(action.productToAdd)
            {console.log(cart)}
            }return state

        case ("DELETEFROMCART"):
             state = state.filter((i) => ((i.id != action.id) )) 
             {console.log(state)}
             return state
    }
    return state
}