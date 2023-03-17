import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Modal from '@mui/material/Modal';
import Container from '@mui/material/Container';

import { IFruit } from 'TypeFruit';
import { useState } from 'react';

const ModalAction = ({
  fruit,
}: /* open,
  setOpen, */
{
  fruit: IFruit;
  /* open: boolean;
  setOpen: (type: boolean) => void; */
}) => {
  const style = {
    position: 'absolute' as 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    width: 400,
    bgcolor: 'background.paper',
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'space-between',
    height: 'auto',
  };
  const [open, setOpen] = useState(false);
  const [result, setResult] = useState(0);

  const handleClose = () => setOpen(false);
  const handleOpen = () => setOpen(true);

  return (
    <div>
      <Button onClick={handleOpen} variant="contained" color="success">
        Ação
      </Button>
      <Modal open={open} onClose={handleClose}>
        <Box sx={style}>
          <div>
            <Typography variant="h6" component="h2">
              Nome
            </Typography>
            <input type="text" readOnly value={fruit.name} />
            <Typography variant="h6" component="h2">
              Valor
            </Typography>
            <input type="text" readOnly value={fruit.value} />
            <Typography variant="h6" component="h2">
              Taxa
            </Typography>
            <input type="text" readOnly value={fruit.tax} />

            <Typography variant="h6" component="h2">
              Resultado
            </Typography>
            <input type="text" readOnly value={result} />
          </div>

          <Container
            sx={{
              marginTop: '30px',
              display: 'flex',
              width: '100%',
              justifyContent: 'space-between',
            }}
          >
            <Button
              onClick={() => setResult(fruit.value / fruit.tax)}
              variant="contained"
              color="secondary"
            >
              Dividir
            </Button>
            <Button
              onClick={() => setResult(fruit.value * fruit.tax)}
              variant="contained"
              color="error"
            >
              Multiplicar
            </Button>
          </Container>
        </Box>
      </Modal>
    </div>
  );
};

export default ModalAction;
