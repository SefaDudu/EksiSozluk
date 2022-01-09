import React, { Component } from 'react'
import { Routes, Route, Link } from "react-router-dom"
import axios from 'axios'
import './regis.css'
import $ from 'jquery'
import Main from '../Main'

class User extends Component {
  componentDidMount() {
    $('#login').on('click', function () {
      let loginURL="https://localhost:44372/api/login"
      axios.post(loginURL, {Username:$('#user').val(),
       Password:$('#pass').val()

      
      }
        
      )
      .then(response => {
        console.log(response)
        console.log(response.data);
        const USER_TOKEN = response.data.access_token;
        console.log('userresponse ' + response.data.access_token); 
        
        window.location.replace("/")
      })   
      .catch(function (error) {
        console.log(error);
        
      });
      
    })
    $(".info-item .btn").on('click', function () {
      $(".container").toggleClass("log-in")
      
    })
    $(".container-form .btn").on('click', function () {
      $(".container").addClass("active")
    })
    $('#register').on('click', function () {
      let baseURL="https://localhost:44372/api/register"  
      axios.post(baseURL, {Username:$('#username').val(),
      Email:$('#email').val(),
      Password:$('#password').val(),
      Phone:$('#phone').val(),
      BirthDay:$('#birthday').val()
      }
        
      )
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
    })

  }
  render() {
    return (
      <>
        <div className="container">
          <div className="box">
          </div>
          <div className="container-forms">
            <div className="container-info">
              <div className="info-item">
                <div className="table">
                  <div className="table-cell">
                    <p>Have an account?</p>
                    <div className="btn">Log in</div>
                  </div>
                </div>
              </div>
              <div className="info-item">
                <div className="table">
                  <div className="table-cell">
                    <p>Don't have an account? </p>
                    <div className="btn">Sign up</div>
                  </div>
                </div>
              </div>
            </div>
            <div className="container-form">
              <div className="form-item log-in">
                <div className="table">
                  <div className="table-cell">
                    <input name="Username" placeholder="Username" type="text" id='user'/>
                    <input name="Password" placeholder="Password" type="Password" id='pass' />
                    <div className="btn"id='login'>Giriş Yap</div>
                  </div>
                </div>
              </div>
              <div className="form-item sign-up">
                <div className="table">
                  <div className="table-cell">
                    <input name="Username" placeholder="Username" type="text" id='username' />
                    <input name="email" placeholder="Email" type="text" id='email' />
                    <input name="phonenumber" placeholder="Telefon Numarası" type="phone" id='phone' />
                    <input name="datetime" placeholder="Doğum Tarihi" type="date" id='birthdate' />
                    <input name="Password" placeholder="Password" type="Password" />
                    <div className="btn"id='register'>Kayıt Ol</div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </>
    )
  }
}
export default User;