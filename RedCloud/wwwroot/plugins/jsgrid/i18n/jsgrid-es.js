(function(jsGrId) {

    jsGrId.locales.es = {
        grId: {
            noDataContent: "No encontrado",
            deleteConfirm: "¿Está seguro?",
            pagerFormat: "Paginas: {first} {prev} {pages} {next} {last} &nbsp;&nbsp; {pageIndex} de {pageCount}",
            pagePrevText: "Anterior",
            pageNextText: "Siguiente",
            pageFirstText: "Primero",
            pageLastText: "Ultimo",
            loadMessage: "Por favor, espere...",
            invalIdMessage: "¡Datos no válIdos!"
        },

        loadIndicator: {
            message: "Cargando..."
        },

        fields: {
            control: {
                searchModeButtonTooltip: "Cambiar a búsqueda",
                insertModeButtonTooltip: "Cambiar a inserción",
                editButtonTooltip: "Editar",
                deleteButtonTooltip: "Suprimir",
                searchButtonTooltip: "Buscar",
                clearFilterButtonTooltip: "Borrar filtro",
                insertButtonTooltip: "Insertar",
                updateButtonTooltip: "Actualizar",
                cancelEditButtonTooltip: "Cancelar edición"
            }
        },

        valIdators: {
            required: { message: "Campo requerIdo" },
            rangeLength: { message: "La longitud del valor está fuera del intervalo definIdo" },
            minLength: { message: "La longitud del valor es demasiado corta" },
            maxLength: { message: "La longitud del valor es demasiado larga" },
            pattern: { message: "El valor no se ajusta al patrón definIdo" },
            range: { message: "Valor fuera del rango definIdo" },
            min: { message: "Valor demasiado bajo" },
            max: { message: "Valor demasiado alto" }
        }
    };

}(jsGrId, jQuery));
