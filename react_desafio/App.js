import React, {Component} from 'react';
import Cabecalho from './Cabecalho';
import EspecialidadeList from './components/EspecialidadeList';
import MedicoList from './components/MedicoList';
import RegistroList from './components/RegistroList';
import './Estilos.css';

class App extends Component{
    render(){
        return(
            <>
                <Cabecalho/>
                {/* <hr></hr>
                <MedicoList/> */}
                <hr></hr>
                {/* <EspecialidadeList/> */}
                <RegistroList/>
            </>
        )
    }
}

export default App;