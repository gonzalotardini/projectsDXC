//Dependencies
import React, { Component } from 'react';
import { connect } from 'react-redux';

//Assets
import '../css/Footer.css';


class Footer extends Component {
    
    render() {       
        return (
            <div className="Footer text-center">
                <p>CopyRigth</p>
            </div>
        );
    }
}

export default connect()(Footer);
