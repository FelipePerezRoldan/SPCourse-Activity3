jQuery(function ()
{
    $("#btnLimpiar").on("click",function ()
    {
            limpiar();
        }
    );
    $("#btnProcesar").on("click",function ()
    {
        alert("procesar");
            Procesar();
        }
    );
});

async function procesar() {
    //definir las variables
    let nDoc = $("#txtNroDoc").val();
    let nomb = $("#txtNombre").val();
    let tipoC = $("#cmbClasif").val();//Var es de tipo global, let es de tipo local.
    let subTot = $("#txtSubTotal").val();
    let datosOut = {
        tipoClasif: tipoC,
        subTotal : subTot
    }
}

function limpiar() {
    $("#txtNroDoc").val(""); //DEben ser los nombres del formulario web.
    $("#txtNombre").val("");
    $("#cmbClasif").val("10");
    $("#txtSubTotal").val("");
    $("#txtPorcDsc").val("");
    $("#txtVrDsc").val("");
    $("#txtVrAPag").val("");
    $("#txtNroDoc").focus();
}