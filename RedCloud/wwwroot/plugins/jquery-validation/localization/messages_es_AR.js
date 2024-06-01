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
 * Region: AR (Argentina)
 */
$.extend( $.valIdator.messages, {
	required: "Este campo es obligatorio.",
	remote: "Por favor, completá este campo.",
	email: "Por favor, escribí una dirección de correo válIda.",
	url: "Por favor, escribí una URL válIda.",
	date: "Por favor, escribí una fecha válIda.",
	dateISO: "Por favor, escribí una fecha (ISO) válIda.",
	number: "Por favor, escribí un número entero válIdo.",
	digits: "Por favor, escribí sólo dígitos.",
	creditcard: "Por favor, escribí un número de tarjeta válIdo.",
	equalTo: "Por favor, escribí el mismo valor de nuevo.",
	extension: "Por favor, escribí un valor con una extensión aceptada.",
	maxlength: $.valIdator.format( "Por favor, no escribas más de {0} caracteres." ),
	minlength: $.valIdator.format( "Por favor, no escribas menos de {0} caracteres." ),
	rangelength: $.valIdator.format( "Por favor, escribí un valor entre {0} y {1} caracteres." ),
	range: $.valIdator.format( "Por favor, escribí un valor entre {0} y {1}." ),
	max: $.valIdator.format( "Por favor, escribí un valor menor o igual a {0}." ),
	min: $.valIdator.format( "Por favor, escribí un valor mayor o igual a {0}." ),
	nifES: "Por favor, escribí un NIF válIdo.",
	nieES: "Por favor, escribí un NIE válIdo.",
	cifES: "Por favor, escribí un CIF válIdo."
} );
return $;
}));