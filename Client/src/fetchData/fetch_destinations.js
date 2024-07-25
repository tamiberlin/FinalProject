import React from 'react';
import axios from 'axios';

async function fetchDestinations() {
  try {
    const response = await axios.get('http://localhost:5135/api/destinations');
    return response.data;
  } catch (error) {
    console.error('Error fetching destinations:', error);
    return [];
  }
}

// function getCityNames(destinations) {
//     return destinations.map(destination => destination.cityName);
//   }

// export { fetchDestinations, getCityNames };
export default fetchDestinations;