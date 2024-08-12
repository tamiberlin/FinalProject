import React, { useState, useRef, useEffect } from 'react';

const Card = ({ dataImage, header, content }) => {
  const [mouseX, setMouseX] = useState(0);
  const [mouseY, setMouseY] = useState(0);
  const [width, setWidth] = useState(0);
  const [height, setHeight] = useState(0);
  const cardRef = useRef(null);

  useEffect(() => {
    const { offsetWidth, offsetHeight } = cardRef.current;
    setWidth(offsetWidth);
    setHeight(offsetHeight);
  }, []);

  const handleMouseMove = (e) => {
    setMouseX(e.pageX - cardRef.current.offsetLeft - width / 2);
    setMouseY(e.pageY - cardRef.current.offsetTop - height / 2);
  };

  const handleMouseLeave = () => {
    setTimeout(() => {
      setMouseX(0);
      setMouseY(0);
    }, 1000);
  };

  const mousePX = mouseX / width;
  const mousePY = mouseY / height;

  const cardStyle = {
    transform: `rotateY(${mousePX * 15}deg) rotateX(${mousePY * -15}deg)`,
    position: 'relative',
    flex: '0 0 480px', // Wider card width
    width: '400px',
    height: '300px', // Adjusted height for proportion
    backgroundColor: 'white', // Lighter card background color
    overflow: 'hidden',
    borderRadius: '10px',
    transition: 'transform 0.6s cubic-bezier(0.445, 0.05, 0.55, 0.95), box-shadow 0.6s cubic-bezier(0.445, 0.05, 0.55, 0.95)',
  };

  const cardBgTransform = {
    transform: `translateX(${mousePX * -20}px) translateY(${mousePY * -20}px)`,
    opacity: 0.9, // Stronger background image
    position: 'absolute',
    top: '0px',
    left: '0px',
    width: '100%',
    height: '100%',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover', // Fill the entire card background
    transition: 'transform 0.6s cubic-bezier(0.445, 0.05, 0.55, 0.95), opacity 5s cubic-bezier(0.445, 0.05, 0.55, 0.95)',
    pointerEvents: 'none',
  };

  const cardBgImage = {
    backgroundImage: `url(${dataImage})`,
  };

  const cardInfoStyle = {
    padding: '20px',
    position: 'absolute',
    bottom: 0,
    color: 'black',
    transform: 'translateY(40%)',
    transition: 'transform 0.6s cubic-bezier(0.215, 0.61, 0.355, 1)',
  };

  const cardInfoPStyle = {
    opacity: 0,
    textShadow: 'rgba(0, 0, 0, 1) 0 2px 3px',
    transition: 'opacity 0.6s cubic-bezier(0.215, 0.61, 0.355, 1)',
  };

  const cardInfoH1Style = {
    fontFamily: '"Playfair Display"',
    fontSize: '36px',
    fontWeight: 700,
    // textShadow: 'rgba(0, 0, 0, 0.5) 0 10px 10px',
  };

  const cardWrapStyle = {
    margin: '35px', // Adjusted margin for better spacing
    transform: 'perspective(800px)',
    transformStyle: 'preserve-3d',
    cursor: 'pointer',
  };

  const handleMouseEnter = () => {
    const cardInfo = cardRef.current.querySelector('.card-info');
    const cardInfoP = cardInfo.querySelector('p');
    const cardBg = cardRef.current.querySelector('.card-bg');

    cardInfo.style.transform = 'translateY(0)';
    cardInfoP.style.opacity = 1;
    cardBg.style.opacity = 0.8;
  };

  return (
    <div className="card-wrap" style={cardWrapStyle} onMouseMove={handleMouseMove} onMouseEnter={handleMouseEnter} onMouseLeave={handleMouseLeave} ref={cardRef}>
      <div className="card" style={cardStyle}>
        <div className="card-bg" style={{ ...cardBgTransform, ...cardBgImage }}></div>
        <div className="card-info" style={cardInfoStyle}>
          <h1 style={cardInfoH1Style}>{header}</h1>
          <p style={cardInfoPStyle}>{content}</p>
        </div>
      </div>
    </div>
  );
};

export default Card;
