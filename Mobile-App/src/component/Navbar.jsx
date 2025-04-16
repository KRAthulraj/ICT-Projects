import { AppBar, Box, Toolbar, Typography, Button } from "@mui/material";
import { Link } from "react-router-dom";

function Navbar() {
  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar
        position="static"
        sx={{
          backgroundColor: "#4F46E5", // Elegant indigo background
          boxShadow: "0px 4px 10px rgba(0, 0, 0, 0.2)", // Optional shadow for elevation
        }}
      >
        <Toolbar>
          <Typography
            variant="h6"
            component="div"
            sx={{
              flexGrow: 1,
              fontWeight: "bold",
              textTransform: "uppercase",
            }}
          >
            Mobile App
          </Typography>
          {/* Navigation Links */}
          <Link to="/login" style={{ textDecoration: "none", color: "white" }}>
            <Button color="inherit">Login</Button>
          </Link>
          <Link to="/signup" style={{ textDecoration: "none", color: "white" }}>
            <Button color="inherit">Sign Up</Button>
          </Link>
          <Link to="/addmovie" style={{ textDecoration: "none", color: "white" }}>
            <Button color="inherit">Add Movie</Button>
          </Link>
          <Link to="/home" style={{ textDecoration: "none", color: "white" }}>
            <Button color="inherit">Dashboard</Button>
          </Link>
        </Toolbar>
      </AppBar>
    </Box>
  );
}

export default Navbar;
