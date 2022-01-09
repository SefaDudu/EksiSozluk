import React, { Component } from 'react'
import Navbar from '../navbar/index'
import './profile.css'

export default class Profile extends Component {
    render() {
        return (
            <>
                <Navbar />
                <div className='contentss'>
                    <div className='username'>
                        <h2>Sefa Dudu</h2>
                        <h6>@sefaccc</h6>
                    </div>
                    <div className='kullaniciicerik'>
                        <ul>
                            <li><a href="#">entry'ler</a></li>
                            <li><a href="#">favoriler</a></li>
                            <li><a href="#">görseller</a></li>
                        </ul>
                    </div>
                    <h3 className='infotitle'>entry'ler (719)</h3>
                    <div className="konucontainer" id='profilekonu'>
                        <h3 className='konubaslik'>bir insanın bütün aşklarının platonik kalması</h3>
                        <p className='konuicerigi'>hayata çaylak kalmak, sevgililerin yanındaki üçüncü kişi olmak sevgilisi olanları kıskanmak, ilişki nasıl bir şeydir merak etmek ve de en önemlisi gerçekten yalnız olmak gibi sonuçları vardır.</p>
                        <div className='row'>
                            <h5 style={{ "marginRight": 50, "marginLeft": 270 }}>21.03.2008  17:59</h5>
                            <h4>Sefa Dudu</h4>
                            <h4 className='konumenu'>...</h4>
                        </div>
                    </div>
                </div>
            </>
        )
    }
}
