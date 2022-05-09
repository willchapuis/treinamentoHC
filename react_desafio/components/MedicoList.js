import React, {Component} from 'react';

class MedicoList extends Component{
    state ={
        medicos: [],
        novoItem:null
    }

    componentDidMount(){
        const dados = fetch('https://telepephc2.famema.br:6868/api/especialidades')
            .then(response => response.json())
            .then(data => {
                this.setState({
                    medicos:data
                })
            })
    }

    handleChanged = (e) => {
        this.setState({
            novoItem: e.target.value
        })
    }

    handleSubmit = (e)=>{
        this.setState({
            medicos: [...this.state.medicos, this.state.novoItem]
        })
    }

    render(){
        // console.log(this.state.medicos);
        return(
            <>
                <ul>
                    {this.state.medicos.map(medico => <li key={medico.id}>{medico.nome}</li>)}
                </ul>
                <input type="text" onChange={this.handleChanged}></input>
                <button type="submit" onClick={this.handleSubmit}>Gravar</button>
            </>
        )
    }
}

export default MedicoList;