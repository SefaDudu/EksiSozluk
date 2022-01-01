import React, { Component } from 'react'
import 'bootstrap/dist/css/bootstrap.min.css';
import './main.css';
import { contains } from 'jquery';

export default class Main extends Component {
  render() {
    return (



      <header>
        <div className="border"></div>   {/*top-border*/}

        <div id="nav">
          <div class="logosearchbutt">   {/*logo - search - login/register buttons*/}
            <a href="#"><img src={'logo.png'} id="logo" /></a>
            <form class="searchb">
              <input type={"text"} placeholder="başlık, #entry, @yazar" name="search" />
              <img src={"srcb.png"} />



            </form>
            <div class="loginregister">
              <a href="#">register</a>
              <a href="#">login</a>
            </div>
          </div>
          <ul>
            <li><a href="#">gündem</a></li>
            <li><a href="#">debe</a></li>
            <li><a href="#">sorunsallar</a></li>
            <li><a href="#">#spor</a></li>
            <li><a href="#">#ilişkiler</a></li>
            <li><a href="#">#siyaset</a></li>
            <li><a href="#" id="nokta">...</a></li>
          </ul>

        </div>

      </header> 

      

    )
  }
}
