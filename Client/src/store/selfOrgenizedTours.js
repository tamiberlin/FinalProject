import React, { useState } from 'react';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';
import styled from 'styled-components';
import fetchDestinations from '../fetchData/fetch_destinations';

const Tours = () => {
  const [checkInDate, setCheckInDate] = useState(null);
  const [checkOutDate, setCheckOutDate] = useState(null);
  const [numPeople, setNumPeople] = useState(1);
  const [destination, setDestination] = useState('');

  const destinations = ['yokyo', 'new york', 'london'];

  const handleCheckInChange = (date) => {
    setCheckInDate(date);
    if (checkOutDate && date >= checkOutDate) {
      setCheckOutDate(null); // Reset checkout date if check-in date is after check-out date
    }
  };

  const handleCheckOutChange = (date) => setCheckOutDate(date);

  const handleNumPeopleChange = (e) => setNumPeople(e.target.value);
  const handleDestinationChange = (e) => setDestination(e.target.value);

  const filterTours = () => {
    // Implement filtering logic based on the input values
    console.log({
      checkInDate,
      checkOutDate,
      numPeople,
      destination,
    });
  };

  const incrementDate = (date, setDate, isCheckIn) => {
    const newDate = new Date(date);
    newDate.setDate(newDate.getDate() + 1);
    if (isCheckIn && checkOutDate && newDate >= checkOutDate) return;
    if (!isCheckIn && checkInDate && newDate <= checkInDate) return;
    setDate(newDate);
  };

  const decrementDate = (date, setDate, isCheckIn) => {
    const newDate = new Date(date);
    newDate.setDate(newDate.getDate() - 1);
    if (isCheckIn && newDate < new Date()) return;
    if (!isCheckIn && checkInDate && newDate <= checkInDate) return;
    setDate(newDate);
  };


  const decrementCheckInDate = () => {
    decrementDate(checkInDate, setCheckInDate, true);
  };
  
  const incrementCheckInDate = () => {
    incrementDate(checkInDate, setCheckInDate, true);
  };
  
  const decrementCheckOutDate = () => {
    decrementDate(checkOutDate, setCheckOutDate, false);
  };
  
  const incrementCheckOutDate = () => {
    incrementDate(checkOutDate, setCheckOutDate, false);
  };


  const styles = {
    container: {
      padding: '20px',
      display: 'flex',
      flexDirection: 'column',
      alignItems: 'flex-start',
    },
    inputsRow: {
      display: 'flex',
      gap: '10px',
      marginBottom: '20px',
    },
    inputGroup: {
      display: 'flex',
      flexDirection: 'column',
    },
    label: {
      marginBottom: '5px',
    },
    inputContainer: {
      display: 'flex',
      alignItems: 'center',
      position: 'relative',
    },
    input: {
      padding: '10px',
      border: '1px solid #ccc',
      borderRadius: '4px',
      fontSize: '16px',
      width: '200px',
      textAlign: 'center',
      paddingLeft: '35px',
      paddingRight: '35px',
    },
    arrowButtonLeft: {
      position: 'absolute',
      left: '5px',
      border: 'none',
      cursor: 'pointer',
      padding: '5px',
      fontSize: '18px',
      backgroundColor: 'transparent',
    },
    arrowButtonRight: {
      position: 'absolute',
      right: '5px',
      border: 'none',
      cursor: 'pointer',
      padding: '5px',
      fontSize: '18px',
      backgroundColor: 'transparent',
    },
    button: {
      padding: '10px 20px',
      backgroundColor: '#007bff',
      color: 'white',
      border: 'none',
      borderRadius: '4px',
      cursor: 'pointer',
    },
    buttonHover: {
      backgroundColor: '#0056b3',
    },
  };

  return (
    <div style={styles.container}>
      <div style={styles.inputsRow}>
         <div style={styles.inputGroup}>
          <label style={styles.label}>Check-in Date:</label>
          <div style={styles.inputContainer}>
         
            <StyledDatePicker
              selected={checkInDate}
              onChange={handleCheckInChange}
              selectsStart
              startDate={checkInDate}
              endDate={checkOutDate}
              placeholderText="Check-in"
              minDate={new Date()}
              customInput={<input style={styles.input} />}
            />
           
          </div>
        </div> 




         <div style={styles.inputGroup}>
          <label style={styles.label}>Check-out Date:</label>
          <div style={styles.inputContainer}>
            
            <StyledDatePicker
              selected={checkOutDate}
              onChange={handleCheckOutChange}
              selectsEnd
              startDate={checkInDate}
              endDate={checkOutDate}
              placeholderText="Check-out"
              minDate={checkInDate || new Date()}
              customInput={<input style={styles.input} />}
            />
           
          </div>
        </div> 



        <div style={styles.inputGroup}>
          <label style={styles.label}>Number of People:</label>
          <input
            type="number"
            value={numPeople}
            onChange={handleNumPeopleChange}
            min="1"
            style={styles.input}
          />
        </div>
        <div style={styles.inputGroup}>
          <label style={styles.label}>Destination:</label>
          <select value={destination} onChange={handleDestinationChange} style={styles.input}>
            <option value="">Select Destination</option>
            {destinations.map((dest, index) => (
              <option key={index} value={dest}>
                {dest}
              </option>
            ))}
          </select>
        </div>
      </div>
      <button
        onClick={filterTours}
        style={{ ...styles.button, ':hover': styles.buttonHover }}
      >
        Filter Tours
      </button>
    </div> 
  );
};

const StyledDatePicker = styled(DatePicker)`
  .react-datepicker__day {
    border-radius: 50%;
    display: inline-block;
    width: 36px;
    height: 36px;
    line-height: 36px;
  }

  .react-datepicker__day--selected, .react-datepicker__day--in-range {
    background-color: #007bff;
    color: white;
  }

  .react-datepicker__day--keyboard-selected {
    background-color: #e0e0e0;
    color: black;
  }

  .react-datepicker__header {
    background-color: #f0f0f0;
    border-bottom: 1px solid #e0e0e0;
  }

  .react-datepicker {
    font-size: 16px;
  }
`;

export default Tours;
