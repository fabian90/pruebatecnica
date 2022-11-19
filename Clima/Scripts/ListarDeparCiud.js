$("#departamento_id").change(function () {
    $.ajax({
        type: "POST",
        url: "/Pronostico/ListaCiudades?IdDepartamento=" + $(this).val(),

        dataType: "json",
        success: function (items, responseTexr) {
            if (items != "") {
                $("#IdCiudad").empty(); $("#municipio_id").append($("<option />").val("0").text("SELECCIONE UNA CIUDAD"));
            }
            $.each(items, function (i, item) {
                $("#municipio_id").append($("<option></option>").val(this.id).html(this.nombre));
            });
        }
    });
});