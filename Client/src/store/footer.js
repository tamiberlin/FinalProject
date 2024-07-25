import React from 'react';
import { Link } from "react-router-dom";
import {  FaFacebook, FaTwitter, FaInstagram, FaYoutube } from 'react-icons/fa';

export default function Footer() {
  return (
    <>
      <style>{`
        .footer {
          width: 100%;
          bottom: 0;
          padding: 2rem 0; /* Increased height */
        }

        .footer .container-fluid {
          display: flex;
          justify-content: space-between;
          align-items: center;
        }

        .nav-links {
          display: flex;
          flex-direction: column;
          align-items: flex-end;
          flex: 1;
        }

        .nav-links ul {
          display: flex;
          flex-wrap: wrap;
          justify-content: flex-end;
        }

        .social-icons {
          display: flex;
          justify-content: flex-end;
          align-items: center;
          margin-top: 1rem;
        }

        .social-icons a {
          color: #000;
          font-size: 1.5rem;
          margin: 0 0.5rem;
        }

        .social-icons a:hover {
          color: #007bff;
        }

        @media (max-width: 576px) {
          .footer .container-fluid {
            flex-direction: column;
            align-items: center;
          }

          .nav-links ul {
            justify-content: center;
          }

          .social-icons {
            justify-content: center;
          }
        }
      `}</style>
      <footer className="bg-light text-dark footer">
        <div className="container-fluid">
          <div>
            <h5>GlobalTravel</h5>
            <small>© All rights reserved</small>
          </div>
          <div className="nav-links">
            <ul className="list-unstyled mb-2">
              <li className="nav-item">
                <Link className="nav-link" to="/home">Home</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/organizedTours">Organized Tours</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/flights">Flights</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/housing">Housing</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/attractions">Attractions</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/showCart">Cart</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/login">Login</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/selfOrgenizedTours">Tours</Link>
              </li>
            </ul>
            <div className="social-icons">
              <a href="https://facebook.com" className="mx-1">
                <FaFacebook />
              </a>
              <a href="https://twitter.com" className="mx-1">
                <FaTwitter />
              </a>
              <a href="https://instagram.com" className="mx-1">
                <FaInstagram />
              </a>
              <a href="https://youtube.com" className="mx-1">
                <FaYoutube />
              </a>
            </div>
          </div>
        </div>
      </footer>
    </>
  );
}
