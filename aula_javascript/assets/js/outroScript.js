function handleIncluir(){
    event.preventDefault()
    var medicamento = document.getElementById("medicamento")
    var preco = document.getElementById("preco")
    var lista = document.getElementById("lista")

    //console.log(item)
    //console.log(item.value)

    //throw new Error("Parou!");

    //window.alert(item.value)

    var novoItem = document.createElement("li")

    novoItem.textContent = medicamento.value + ' - ' + preco.value

    lista.appendChild(novoItem)
}