import { useState, useEffect } from 'react';
const Fetch = () => {
  const [costumers, setCostumers] = useState([]);
  useEffect(() => {
    fetch('http://localhost:5135/api/costumer')
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        console.log(data);
        setCostumers(data);
      });
  }, []);
  return (
    costumers.map(costumer => (<div>{costumer.costumerName}</div>))
  );
};
export default Fetch;