import React, { Component } from 'react'
import AdminSidebar from '../Adminsidebar/index'
import './admin.css';
import { contains } from 'jquery';

export default class Main extends Component {
  render() {
    return (
      <>
            <AdminSidebar/>
          {/*admin içerik kısmı*/}
          <div className="admincontent">
          <div class="table">
		<div class="table-header">
			<div class="header__item"><a id="name" class="filter__link" href="#">İsim</a></div>
			<div class="header__item"><a id="wins" class="filter__link filter__link--number" href="#">Konu</a></div>
			<div class="header__item"><a id="draws" class="filter__link filter__link--number" href="#">Yorum</a></div>
			<div class="header__item"><a id="losses" class="filter__link filter__link--number" href="#">Engellenenler</a></div>
			<div class="header__item"><a id="total" class="filter__link filter__link--number" href="#">Şikayetler</a></div>
		</div>
		<div class="table-content">	
			<div class="table-row">		
				<div class="table-data">Sefa</div>
				<div class="table-data">2</div>
				<div class="table-data">0</div>
				<div class="table-data">1</div>
				<div class="table-data">5</div>
			</div>
			<div class="table-row">
				<div class="table-data">Furkan</div>
				<div class="table-data">1</div>
				<div class="table-data">1</div>
				<div class="table-data">2</div>
				<div class="table-data">3</div>
			</div>
			<div class="table-row">
				<div class="table-data">Barış</div>
				<div class="table-data">0</div>
				<div class="table-data">2</div>
				<div class="table-data">2</div>
				<div class="table-data">2</div>
			</div>
			<div class="table-row">
				<div class="table-data">Enes</div>
				<div class="table-data">1</div>
				<div class="table-data">0</div>
				<div class="table-data">0</div>
				<div class="table-data">7</div>
			</div>
		</div>	
	</div>
          </div>
      </>
    )
  }
}
