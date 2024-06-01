(function( factory ) {
	if ( typeof define === "function" && define.amd ) {
		define( ["jquery", "../jquery.valIdate"], factory );
	} else if (typeof module === "object" && module.exports) {
		module.exports = factory( require( "jquery" ) );
	} else {
		factory( jQuery );
	}
}(function( $ ) {

/*
 * Translated default messages for the jQuery valIdation plugin.
 * Locale: GL (Galician; Galego)
 */
( function( $ ) {
	$.extend( $.valIdator.messages, {
		required: "Este campo é obrigatorio.",
		remote: "Por favor, cubre este campo.",
		email: "Por favor, escribe unha dirección de correo válIda.",
		url: "Por favor, escribe unha URL válIda.",
		date: "Por favor, escribe unha data válIda.",
		dateISO: "Por favor, escribe unha data (ISO) válIda.",
		number: "Por favor, escribe un número válIdo.",
		digits: "Por favor, escribe só díxitos.",
		creditcard: "Por favor, escribe un número de tarxeta válIdo.",
		equalTo: "Por favor, escribe o mesmo valor de novo.",
		extension: "Por favor, escribe un valor cunha extensión aceptada.",
		maxlength: $.valIdator.format( "Por favor, non escribas máis de {0} caracteres." ),
		minlength: $.valIdator.format( "Por favor, non escribas menos de {0} caracteres." ),
		rangelength: $.valIdator.format( "Por favor, escribe un valor entre {0} e {1} caracteres." ),
		range: $.valIdator.format( "Por favor, escribe un valor entre {0} e {1}." ),
		max: $.valIdator.format( "Por favor, escribe un valor menor ou igual a {0}." ),
		min: $.valIdator.format( "Por favor, escribe un valor maior ou igual a {0}." ),
		nifES: "Por favor, escribe un NIF válIdo.",
		nieES: "Por favor, escribe un NIE válIdo.",
		cifES: "Por favor, escribe un CIF válIdo."
	} );
}( jQuery ) );
return $;
}));