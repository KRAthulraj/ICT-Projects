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
      main: "#4F46E5",
    },
    secondary: {
      main: "#1E293B",
    },
  },
  typography: {
    fontFamily: "'Poppins', sans-serif",
    h4: {
      fontWeight: 700,
    },
    body2: {
      fontSize: "0.9rem",
    },
  },
});

function AddMovie() {
  return (
    <ThemeProvider theme={theme}>
      <div
        style={{
          minHeight: "100vh",
          display: "flex",
          alignItems: "center",
          justifyContent: "center",
          background: "linear-gradient(135deg, #E0E7FF, #6366F1)",
        }}
      >
        <Container maxWidth="sm">
          <Box
            style={{
              padding: "40px",
              borderRadius: "20px",
              backdropFilter: "blur(8px)",
              backgroundColor: "rgba(255, 255, 255, 0.8)",
              boxShadow: "0px 10px 30px rgba(0, 0, 0, 0.15)",
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
              ADD MOVIE
            </Typography>
            <TextField
              id="movie-title"
              label="Movie Title"
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
            <TextField
              id="release-year"
              label="Release Year"
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
            <TextField
              id="genre"
              label="Genre"
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
                background: "linear-gradient(135deg, #6366F1, #4F46E5)",
                color: "#FFFFFF",
                fontWeight: "bold",
                boxShadow: "0px 4px 12px rgba(99, 102, 241, 0.5)",
                transition: "transform 0.3s ease",
                "&:hover": {
                  transform: "scale(1.05)",
                  boxShadow: "0px 6px 15px rgba(99, 102, 241, 0.7)",
                },
              }}
            >
              Add Movie
            </Button>
          </Box>
        </Container>
      </div>
    </ThemeProvider>
  );
}

export default AddMovie;
