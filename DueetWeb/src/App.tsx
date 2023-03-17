//import './App.css';

import { useEffect, useState } from 'react';
import { styled } from '@mui/material/styles';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell, { tableCellClasses } from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { IFruit } from 'TypeFruit';
import ModalAction from './components/ModalAction';

const StyledTableCell = styled(TableCell)(({ theme }) => ({
  [`&.${tableCellClasses.head}`]: {
    backgroundColor: theme.palette.common.black,
    color: theme.palette.common.white,
  },
  [`&.${tableCellClasses.body}`]: {
    fontSize: 14,
  },
}));

function App() {
  const [fruits, setFruits] = useState<IFruit[]>([]);

  useEffect(() => {
    fetch('http://localhost:5228/api/fruit')
      .then((response) => {
        response.json().then((data: IFruit[]) => {
          setFruits(data);
        });
      })
      .catch(() => alert('Erro na rota'));
  }, []);
  return (
    <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            <StyledTableCell>Nome</StyledTableCell>
            <StyledTableCell align="center">Descrição</StyledTableCell>
            <StyledTableCell align="center">Preço(g)</StyledTableCell>
            <StyledTableCell align="center">Taxa</StyledTableCell>
            <StyledTableCell align="center">Ação</StyledTableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {fruits.map((fruit) => (
            <TableRow
              key={fruit.id}
              sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
            >
              <TableCell component="th" scope="row">
                {fruit.name}
              </TableCell>
              <TableCell align="center">{fruit.description}</TableCell>
              <TableCell align="center">{fruit.value}</TableCell>
              <TableCell align="center">{fruit.tax}</TableCell>
              <TableCell align="center">
                <ModalAction
                  fruit={fruit} /* open={open} setOpen={setOpen} */
                />
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

export default App;
