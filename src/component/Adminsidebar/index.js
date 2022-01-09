import React, { Component } from 'react'
import './adminsidebar.css'
export default class Admin extends Component {
    render() {
        return (
            <>
            <div className="bordercontainer1"></div> 
                <div className="Admin">

                    <div className="adminsidebar">
                        <span><img src={"eksipanel.png"} id="logopanel" /></span>
                        <ul className="panellist">
                            <li><a href="#">Tüm Yorumlar</a></li>
                            <li><a href="#1">Kara Liste</a></li>
                            <li><a href="#2">x</a></li>
                            <li><a href="#3">x</a></li>
                            <li><a href="#4">x</a></li>
                            <li><a href="#5">x</a></li>
                        </ul>
                    </div>
                </div>
                <div className="AdminTopside">
                    <div className="row" id="Admintopright">
                    <span>Sefa Dudu</span>
                    <span><img src={"user.png"} id="adminuserlogo" /></span>
                        
                    </div>
                </div>
            </>
        )
    }
}
