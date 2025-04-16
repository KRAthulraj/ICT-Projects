import {
  Box,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Typography,
  Paper,
} from "@mui/material";

function MoviesTable() {
  // Hardcoded movie data
  const movies = [
    {
      id: 1,
      name: "Inception",
      description: "A mind-bending thriller by Christopher Nolan.",
      rating: "9.0",
    },
    {
      id: 2,
      name: "The Shawshank Redemption",
      description: "A tale of hope and friendship.",
      rating: "9.3",
    },
    {
      id: 3,
      name: "The Dark Knight",
      description: "A gripping superhero drama.",
      rating: "9.1",
    },
    {
      id: 4,
      name: "Interstellar",
      description: "A journey across space and time.",
      rating: "8.6",
    },
  ];

  return (
    <Box
      sx={{
        padding: 4,
        backgroundColor: "#F3F4F6",
        minHeight: "100vh",
      }}
    >
      <Typography
        variant="h4"
        component="h1"
        sx={{
          textAlign: "center",
          fontWeight: "bold",
          color: "#4F46E5",
          marginBottom: 4,
        }}
      >
        Movies List
      </Typography>
      <TableContainer
        component={Paper}
        sx={{
          boxShadow: "0px 5px 20px rgba(0, 0, 0, 0.1)",
          borderRadius: "12px",
          overflow: "hidden",
        }}
      >
        <Table>
          <TableHead>
            <TableRow
              sx={{
                backgroundColor: "#4F46E5",
              }}
            >
              <TableCell
                sx={{
                  color: "#FFFFFF",
                  fontWeight: "bold",
                  fontSize: "1rem",
                }}
              >
                Movie Title
              </TableCell>
              <TableCell
                sx={{
                  color: "#FFFFFF",
                  fontWeight: "bold",
                  fontSize: "1rem",
                }}
              >
                Description
              </TableCell>
              <TableCell
                sx={{
                  color: "#FFFFFF",
                  fontWeight: "bold",
                  fontSize: "1rem",
                }}
              >
                Rating
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {movies.map((movie) => (
              <TableRow
                key={movie.id}
                sx={{
                  "&:nth-of-type(odd)": {
                    backgroundColor: "#F9FAFB",
                  },
                  "&:nth-of-type(even)": {
                    backgroundColor: "#FFFFFF",
                  },
                  "&:hover": {
                    backgroundColor: "#E0E7FF",
                  },
                }}
              >
                <TableCell
                  sx={{
                    color: "#1E293B",
                    fontWeight: "500",
                    fontSize: "0.95rem",
                  }}
                >
                  {movie.name}
                </TableCell>
                <TableCell
                  sx={{
                    color: "#6B7280",
                    fontSize: "0.9rem",
                  }}
                >
                  {movie.description}
                </TableCell>
                <TableCell
                  sx={{
                    color: "#6366F1",
                    fontWeight: "500",
                    fontSize: "0.9rem",
                  }}
                >
                  {movie.rating}
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </Box>
  );
}

export default MoviesTable;
