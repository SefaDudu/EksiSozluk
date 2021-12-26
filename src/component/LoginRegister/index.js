import React, { Component } from 'react'
import  './regis.css'
import $ from 'jquery'
class User extends Component {
  componentDidMount(){
    $(".info-item .btn").click(function () {
      $(".container").toggleClass("log-in");
    });
    $(".container-form .btn").click(function () {
      $(".container").addClass("active");
    });
    
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
            <input name="Username" placeholder="Username" type="text" />
            <input name="Password" placeholder="Password" type="Password" />
            <div className="btn">Giriş Yap</div>
          </div>
        </div>
      </div>
      <div className="form-item sign-up">
        <div className="table">
          <div className="table-cell">
            <input name="Username" placeholder="Username" type="text" />
            <input name="email" placeholder="Email" type="text" />
            <input name="phonenumber" placeholder="Telefon Numarası" type="phone" />
            <input name="datetime" placeholder="Doğum Tarihi" type="date" />
            <input name="Password" placeholder="Password" type="Password" />
            <div className="btn">Kayıt Ol</div>
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