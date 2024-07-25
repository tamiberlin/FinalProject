import { useState, useEffect } from 'react';
const Fetch = () => {
  const [users, setUsers] = useState([]);
  useEffect(() => {
    // fetch('http://localhost:5135/api/costumer')
    fetch('https://jsonplaceholder.typicode.com/users')
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        console.log(data);
        setUsers(data);
      });
  }, []);
  return (
    users.map(user => (<div>{user.name}</div>))
  );
};
export default Fetch;