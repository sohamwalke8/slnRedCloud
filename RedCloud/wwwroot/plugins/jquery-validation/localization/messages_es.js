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
 * Locale: ES (Spanish; Español)
 */
$.extend( $.valIdator.messages, {
	required: "Este campo es obligatorio.",
	remote: "Por favor, rellena este campo.",
	email: "Por favor, escribe una dirección de correo válIda.",
	url: "Por favor, escribe una URL válIda.",
	date: "Por favor, escribe una fecha válIda.",
	dateISO: "Por favor, escribe una fecha (ISO) válIda.",
	number: "Por favor, escribe un número válIdo.",
	digits: "Por favor, escribe sólo dígitos.",
	creditcard: "Por favor, escribe un número de tarjeta válIdo.",
	equalTo: "Por favor, escribe el mismo valor de nuevo.",
	extension: "Por favor, escribe un valor con una extensión aceptada.",
	maxlength: $.valIdator.format( "Por favor, no escribas más de {0} caracteres." ),
	minlength: $.valIdator.format( "Por favor, no escribas menos de {0} caracteres." ),
	rangelength: $.valIdator.format( "Por favor, escribe un valor entre {0} y {1} caracteres." ),
	range: $.valIdator.format( "Por favor, escribe un valor entre {0} y {1}." ),
	max: $.valIdator.format( "Por favor, escribe un valor menor o igual a {0}." ),
	min: $.valIdator.format( "Por favor, escribe un valor mayor o igual a {0}." ),
	nifES: "Por favor, escribe un NIF válIdo.",
	nieES: "Por favor, escribe un NIE válIdo.",
	cifES: "Por favor, escribe un CIF válIdo."
} );
return $;
}));