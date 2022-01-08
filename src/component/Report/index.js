import React, { Component } from 'react'
import './report.css'
import Navbar from '../navbar/index'
export default class Report extends Component {
    render() {
        return (
            <>
                <Navbar />
                <div className='contentss'>
                    <div className="konucontainer">
                        <h3 className='konubaslik'>bir insanın bütün aşklarının platonik kalması</h3>
                        <p className='konuicerigi'>hayata çaylak kalmak, sevgililerin yanındaki üçüncü kişi olmak sevgilisi olanları kıskanmak, ilişki nasıl bir şeydir merak etmek ve de en önemlisi gerçekten yalnız olmak gibi sonuçları vardır.</p>
                        <div className='row'>
                        <h5 style={{"marginRight":50,"marginLeft":270}}>21.03.2008  17:59</h5>
                        <h4>Sefa Dudu</h4>
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
