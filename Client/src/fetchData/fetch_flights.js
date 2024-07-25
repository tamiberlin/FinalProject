import React from "react";
import axios from 'axios';
async function fetchFlights (){
    try {
      const response = await axios.get('http://localhost:5135/api/flights'); // Replace with your actual API endpoint
      return response.data;
      // Process the fetched flights data as needed
      
    } catch (error) {
      console.error('Error fetching flights:', error);
      return [];
    }
  };
export default fetchFlights;