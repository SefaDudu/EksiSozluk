import React, { Component } from 'react'
import 'bootstrap/dist/css/bootstrap.min.css';
import './main.css';
import { contains } from 'jquery';

export default class Main extends Component {
  render() {
    return (


      <>
        <div className="bordercontainer1"></div>   {/*top-border*/}
        <div>


          <div id="nav">
            <div className="logosearchbutt">   {/*logo - search - login/register buttons*/}
              <a href="#"><img src={'logo.png'} id="logo" /></a>
              <form className="searchb">
                <input type={"text"} placeholder="başlık, #entry, @yazar" name="search" />
                <img src={"srcb.png"} />



              </form>
              <div className="loginregister">
                <a href="#">register</a>
                <a href="#">login</a>
              </div>
            </div>
            <ul>
              <li><a href="#" id="g">gündem</a></li>
              <li><a href="#">debe</a></li>
              <li><a href="#">sorunsallar</a></li>
              <li><a href="#">#spor</a></li>
              <li><a href="#">#ilişkiler</a></li>
              <li><a href="#">#siyaset</a></li>
              <li><a href="#" id="nokta">...</a></li>
            </ul>

          </div>

        </div>
        <div className="bordercontainer"></div>
        <div className="Containerr">
          {/*sidebar*/}
          <div className="sidebar">

            <div className="baslik">
              <span>gündem</span>
              <img src={"settings.png"} />
            </div>

            <div className="baslikicerik">

              <ul>
                <li><a href="#">Dikkat bu yazı çok uzun bir deneme yazısıdır lorem ipsum dolar sit amet</a><small>20000</small></li>
                <li><a href="#1">x</a><small>200</small></li>
                <li><a href="#2">x</a><small>200</small></li>
                <li><a href="#3">x</a><small>200</small></li>
                <li><a href="#4">x</a><small>200</small></li>
                <li><a href="#5">x</a><small>200</small></li>
              </ul>
            </div>


          </div>

          {/*içerik kısmı*/}
          <div className="contents">
           <h1>içerik kısmı</h1> 
          </div>
        </div>


      </>
    )
  }
}
