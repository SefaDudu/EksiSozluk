import './App.css';
import User from './component/LoginRegister/';
import Main from './component/Main/'
import Report from './component/Report'
import ReportUser from './component/ReportUser'
import Admin from './component/Admin/'
import { Routes, Route, Link } from "react-router-dom"
import React from 'react';

function App() {
  return (
    <Routes>
      <Route path="/" element={<Main />} />
      <Route path="/login" element={<User />} />
      <Route path="/report" element={<Report/>}></Route>
      <Route path="/reportuser" element={<ReportUser/>}></Route>
      <Route path="/admin" element={<Admin/>}></Route>
    </Routes>
  )
}

export default App;
