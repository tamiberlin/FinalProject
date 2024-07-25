import React from "react";
import axios from 'axios';
async function fetchTours (){
    try {
      const response = await axios.get('http://localhost:5135/api/tours'); // Replace with your actual API endpoint
      return response.data;
      // Process the fetched flights data as needed
      
    } catch (error) {
      console.error('Error fetching tours:', error);
      return [];
    }
  };
export default fetchTours;