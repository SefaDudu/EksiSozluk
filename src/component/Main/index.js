import React, { Component } from 'react'
import  './main.css'

export default class Main extends Component {
    render() {
        return (
            <header>
            <nav className="navbar navbar-light bg-light">
  <div className="container-fluid">
    <img src={'logo.png'} style={{width:200}}/>
    <form className="d-flex">
      <button className="btn btn-outline-success" type="submit">Giriş Yap</button>
    </form>
  </div>
</nav>
<ul>
  <li><a class="active" href="#home">Home</a></li>
  <li><a href="#news">News</a></li>
  <li><a href="#contact">Contact</a></li>
  <li><a href="#about">About</a></li>
</ul>
</header>
        )
    }
}
