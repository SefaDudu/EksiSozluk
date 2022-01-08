import React, { Component } from 'react'
import './reportuser.css'
import Navbar from '../navbar/index'
export default class Report extends Component {
    render() {
        return (
            <>
                <Navbar />
                <div className='contentss'>
                    <div className='row'>
                        <img src={"user.png"} id='userimage' />
                        <div className='column'>
                        <h4>Sefa Dudu</h4>
                        <h7>@sefaccc</h7>
                        </div>
                    </div>
                    <form id="survey-form">
                        <div className="row">
                            <label  for="name">E Posta Adresiniz</label>
                            <input type="email" id="email" className="input-field"/>
                        </div>

                        <div className="row">
                            <label for="text">Konu</label>
                            <input type="text" id="text" className="input-field"  />
                        </div>
                        <div className="row">
                            <label for="text">Açıklama</label>
                           <textarea name="aciklama" id="aciklama" cols="30" rows="10"></textarea>
                        </div>
                        <div className='row'>
                        <button className='sikayetbutton'>Şikayet Et</button>
                        </div>
                    </form>
                </div>
            </>
        )
    }
}
