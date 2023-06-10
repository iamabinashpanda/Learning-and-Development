import React from 'react';
import './Card.css';

const Card = (props) => {
    const classes = 'card'+' '+ props.className;
    return (
        // <div className={classes}>{props.children}</div>
        React.createElement('div',{className:classes},props.children)
    )
}

export default Card;