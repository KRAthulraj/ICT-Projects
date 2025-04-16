


import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import './App.css';
import Login from './component/Login';
import SignUp from './component/SignUp';
import Navbar from './component/Navbar';
import AddMovie from './component/AddMovies';
import Home from './component/dashboard';

function App() {


  return (
    <Router> {/* Wrap everything in BrowserRouter */}
      <>
        <Navbar />
        <Routes>
          <Route path="/login" element={<Login />} />
          <Route path="/signup" element={<SignUp />} /> 
          <Route path="/addmovie" element={<AddMovie />} /> {/* Added SignUp route */}
          <Route path="/home" element={<Home />} /> {/* Added SignUp route */}
        </Routes>
      </>
    </Router>
  );
}

export default App;
