import React, {Component} from 'react';
import logo from './assets/aleatorio.jpg';

class Cabecalho extends Component{
    render(){
        return(
            <>
                <span><strong>Osvaldo Nascimento</strong></span>
                <br/>
                <span>Idade:46</span>
                <br/>
                <img src={logo}/>
            </>
        )
    }
}

export default Cabecalho;