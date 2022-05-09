import axios from 'axios';
import React, {Component} from 'react';
import EspecialidadeItem from './EspecialidadeItem';

class EspecialidadeList extends Component{

    state = {
        especialidades: [],
        novoItem:null
    }

    componentDidMount(){
        this.atualizaEspecialidades();
    }

    atualizaEspecialidades(){
        axios.get('https://telepephc2.famema.br:6868/api/especialidades')
            .then(response => {
                this.setState({
                    especialidades: response.data
                });
                console.log(this.state.especialidades);
            })
    }

    handleSubmit =(e)=>{
        const nomeEspecialidade = document.getElementById('nome').value;

        const data = new FormData();
        data.append('nome', nomeEspecialidade);
        data.append('idLegado', '2');
        data.append('id_ambiente', '2');

        axios.post('https://telepephc2.famema.br:6868/api/especialidades', data)
            .then(() =>{
                this.atualizaEspecialidades();
            })
    }

    handleDelete = (item) =>{
        this.setState({
            especialidades: this.state.especialidades.filter(esp => esp.id!=item.id)
        })
    }

    render(){
        // console.log(this.state.especialidades);
        return(
            <>
                <h1>Especialidades</h1>
                <ul>
                    {this.state.especialidades.map(esp => 
                            <EspecialidadeItem
                                key={esp.id}
                                item={esp.nome}
                                onDelete={()=>this.handleDelete(esp)}
                            />
                        )
                    }
                </ul>
                <input type="text" id="nome"></input>
                <button type="submit" onClick={this.handleSubmit}>Incluir</button>
            </>
        )
    }
}

export default EspecialidadeList;