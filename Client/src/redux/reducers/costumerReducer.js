const costumers = []
export const costumerReducer = (state = costumers, action) => {
    switch (action.type) {
        case ("ADDNEWCOSTUMER"):
            const filteredCostumers = costumers.filter((c)=>(c.id == action.id))
            if(filteredCostumers.length ==0){
                costumers.push(action.newCostumer)
            {console.log(costumers)}
            }return state

        case ("UPDATECOSTUMER"):
            const costumerToUpdate = state.filter((c)=>c.id == action.id)
            costumerToUpdate = action.newCostumer;
            {console.log(state)}
            return state
    }
    return state
}