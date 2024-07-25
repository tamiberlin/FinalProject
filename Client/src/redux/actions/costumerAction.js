export const addNewCostumer = (newCostumer) => {
    return {
        type: 'ADDNEWCOSTUMER',
        payload: newCostumer
    }
}

export const updateCostumer = (id, newCostumer) => {
    return {
        type: 'UPDATECOSTUMER',
        payload: { id, newCostumer }
    }
}



