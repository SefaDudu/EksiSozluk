import './App.css';
import User from './component/LoginRegister';
import Main from './component/Main'
import { Routes, Route, Link } from "react-router-dom"

function App() {
  return (
    <Routes>
      <Route path="/" element={<Main />} />
      <Route path="login" element={<User />} />
    </Routes>
  )
}

export default App;
