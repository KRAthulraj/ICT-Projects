import {
  TextField,
  Button,
  Box,
  Typography,
  Container,
  ThemeProvider,
  createTheme,
} from "@mui/material";

const theme = createTheme({
  palette: {
    primary: {
      main: "#4F46E5", // Elegant indigo
    },
    secondary: {
      main: "#1E293B", // Neutral dark tone
    },
  },
  typography: {
    fontFamily: "'Poppins', sans-serif", // Modern and clean font
    h4: {
      fontWeight: 700, // Bold and prominent header
    },
    body2: {
      fontSize: "0.9rem", // Slightly smaller text
    },
  },
});

function SignUp() {
  return (
    <ThemeProvider theme={theme}>
      <div
        style={{
          minHeight: "100vh",
          display: "flex",
          alignItems: "center",
          justifyContent: "center",
          background: "linear-gradient(135deg, #E0E7FF, #6366F1)", // Soft gradient
        }}
      >
        <Container maxWidth="sm">
          <Box
            style={{
              padding: "40px",
              borderRadius: "20px",
              backdropFilter: "blur(8px)", // Frosted glass effect
              backgroundColor: "rgba(255, 255, 255, 0.8)",
              boxShadow: "0px 10px 30px rgba(0, 0, 0, 0.15)", // Soft shadow
              textAlign: "center",
            }}
          >
            <Typography
              variant="h4"
              gutterBottom
              style={{
                color: "#1E293B",
                fontWeight: "bold",
              }}
            >
              SIGN UP
            </Typography>
            {/* Name Field */}
            <TextField
              id="name"
              label="Full Name"
              variant="outlined"
              fullWidth
              margin="normal"
              sx={{
                "& .MuiOutlinedInput-root": {
                  borderRadius: "12px",
                  backgroundColor: "#F3F4F6",
                  transition: "0.3s",
                  "&:hover": {
                    backgroundColor: "#E5E7EB",
                  },
                  "&.Mui-focused .MuiOutlinedInput-notchedOutline": {
                    borderColor: "#4F46E5", // Focused border
                  },
                },
                "& .MuiInputLabel-root.Mui-focused": {
                  color: "#4F46E5", // Focused label color
                },
              }}
            />
            {/* Email Field */}
            <TextField
              id="email"
              label="Email Address"
              variant="outlined"
              fullWidth
              margin="normal"
              sx={{
                "& .MuiOutlinedInput-root": {
                  borderRadius: "12px",
                  backgroundColor: "#F3F4F6",
                  transition: "0.3s",
                  "&:hover": {
                    backgroundColor: "#E5E7EB",
                  },
                  "&.Mui-focused .MuiOutlinedInput-notchedOutline": {
                    borderColor: "#4F46E5", // Focused border
                  },
                },
                "& .MuiInputLabel-root.Mui-focused": {
                  color: "#4F46E5", // Focused label color
                },
              }}
            />
            {/* Password Field */}
            <TextField
              id="password"
              type="password"
              label="Password"
              variant="outlined"
              fullWidth
              margin="normal"
              sx={{
                "& .MuiOutlinedInput-root": {
                  borderRadius: "12px",
                  backgroundColor: "#F3F4F6",
                  transition: "0.3s",
                  "&:hover": {
                    backgroundColor: "#E5E7EB",
                  },
                  "&.Mui-focused .MuiOutlinedInput-notchedOutline": {
                    borderColor: "#4F46E5",
                  },
                },
                "& .MuiInputLabel-root.Mui-focused": {
                  color: "#4F46E5",
                },
              }}
            />
            {/* Confirm Password Field */}
            <TextField
              id="confirm-password"
              type="password"
              label="Confirm Password"
              variant="outlined"
              fullWidth
              margin="normal"
              sx={{
                "& .MuiOutlinedInput-root": {
                  borderRadius: "12px",
                  backgroundColor: "#F3F4F6",
                  transition: "0.3s",
                  "&:hover": {
                    backgroundColor: "#E5E7EB",
                  },
                  "&.Mui-focused .MuiOutlinedInput-notchedOutline": {
                    borderColor: "#4F46E5",
                  },
                },
                "& .MuiInputLabel-root.Mui-focused": {
                  color: "#4F46E5",
                },
              }}
            />
            <Button
              variant="contained"
              sx={{
                marginTop: "20px",
                width: "100%",
                padding: "12px",
                borderRadius: "25px",
                background: "linear-gradient(135deg, #6366F1, #4F46E5)", // Gradient button
                color: "#FFFFFF",
                fontWeight: "bold",
                boxShadow: "0px 4px 12px rgba(99, 102, 241, 0.5)", // Subtle shadow
                transition: "transform 0.3s ease",
                "&:hover": {
                  transform: "scale(1.05)",
                  boxShadow: "0px 6px 15px rgba(99, 102, 241, 0.7)", // Glow effect
                },
              }}
            >
              Sign Up
            </Button>
            <Typography
              variant="body2"
              style={{
                marginTop: "15px",
                color: "#6B7280",
              }}
            >
              Already have an account?{" "}
              <a
                href="#"
                style={{
                  color: "#4F46E5",
                  textDecoration: "underline",
                  fontWeight: "600",
                }}
              >
                Log in here
              </a>
            </Typography>
          </Box>
        </Container>
      </div>
    </ThemeProvider>
  );
}

export default SignUp;
