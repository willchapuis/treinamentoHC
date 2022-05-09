window.addEventListener('load', start)

var nomeGeral = "Banana"

function start(){
    //window.alert('iniciou page')
    console.log('Ola mundo')
}

function handleEnviar(){
    event.preventDefault()
    var nome = document.getElementById("nome")

    var h1 = document.querySelector("h1")

    //window.alert(nome.value)
    h1.textContent = nomeGeral
    h1.classList.add("Destaque")

    var lista = document.getElementById("lista")

    var novoItem = document.createElement('li')

    novoItem.textContent = nome.value

    lista.appendChild(novoItem)
}