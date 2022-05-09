import React from 'react';

function RegistroItem({placa, onDelete, onLoad, onUpdate}) {
    return (
        <li>
            {placa}
            <span>      </span>
            <button type="button" onClick={onLoad} id="carregar">Carregar</button>
            <span>      </span>
            <button type="button" onClick={onDelete} id="excluir">Excluir</button>
            <span>      </span>
            <button type="button" onClick={onUpdate} id="editar">Editar</button>
        </li>
    )
}

export default RegistroItem;