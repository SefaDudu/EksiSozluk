import React, { Component } from 'react'
import Navbar from '../navbar/index'
import { contains } from 'jquery';

export default class Main extends Component {
  render() {
    return (
      <>
            <Navbar/>
          {/*içerik kısmı*/}
          <div className="contents">
          <h1>içerik kısmı</h1> 
          </div>
      </>
    )
  }
}
