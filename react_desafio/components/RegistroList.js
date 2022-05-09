import axios from 'axios';
import React, {Component} from 'react';
import RegistroItem from './RegistroItem';

class RegistroList extends Component{
    state ={
        registros: [],
        idItem:null
    }

    componentDidMount(){
        this.atualizaRegistros();
    }

    atualizaRegistros(){
        axios.get('http://127.0.0.1:8000/api/ControleVeiculosEntradaListView')
        .then(response => {
            this.setState({
                registros:response.data
            })
            console.log(this.state.registros);
        })
    }

    handleSubmit = (e) => {
        const placaRegistro = document.getElementById('placa').value;
        const dataRegistro = document.getElementById('data').value;
        const data = new FormData();
        data.append('placa', placaRegistro);
        // data.append('hora_entrada', '2022-05-05T10:15:00Z');
        data.append('hora_entrada', dataRegistro);

        axios.post('http://127.0.0.1:8000/api/ControleVeiculosEntradaView', data)
            .then(() => {
                this.atualizaRegistros();
                // console.log(dataRegistro);
                // console.log(Date.parse(dataRegistro));
                // console.log(new Date(Date.parse(dataRegistro)));
            })
    }

    handleDelete = (item) => {axios.delete(`http://127.0.0.1:8000/api/ControleVeiculosEntradaView/${item.id}`)
            .then(() => {
                this.atualizaRegistros();
            })
    }

    handleUpdate = (item) => {
        const placaRegistro = document.getElementById('placa').value;
        const dataRegistro = document.getElementById('data').value;
        const data = new FormData();
        data.append('placa', placaRegistro);
        // data.append('hora_entrada', '2022-05-05T10:15:00Z');
        data.append('hora_entrada', dataRegistro);

        axios.put(`http://127.0.0.1:8000/api/ControleVeiculosEntradaView/${item.id}`, data)
            .then(() => {
                this.atualizaRegistros();
            })
    }

    handleLoad = (item) => {
        document.getElementById('placa').value = item.placa;
        document.getElementById('data').value = item.hora_entrada.split('T')[0];
    }

    render(){
        return (
            <>
                <h1>Registros</h1>
                <ul>
                    {this.state.registros.map(reg =>
                        <RegistroItem
                            key={reg.id}
                            placa={reg.placa}
                            onLoad={()=>this.handleLoad(reg)}
                            onDelete={()=>this.handleDelete(reg)}
                            onUpdate={()=>this.handleUpdate(reg)}
                        />
                    )}
                </ul>

                <label>Placa: </label>
                <input type="text" id="placa"></input>
                <br/>
                <label>Data: </label>
                <input type="date" id='data'></input>

                <button type="submit" onClick={this.handleSubmit} id="salvar">Novo</button>
            </>
        )
    }
}

export default RegistroList;