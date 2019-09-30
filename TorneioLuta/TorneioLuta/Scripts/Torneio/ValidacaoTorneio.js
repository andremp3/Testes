$("#btn-Iniciar").click(function () {

    var NumeroParticipantes = 20;
    var numberOfChecked = $('input:checkbox:checked').length;

    if (numberOfChecked != NumeroParticipantes) {
        alert("É obrigatório selecionar " + NumeroParticipantes + " lutadores!");
        return false;
    }
});
