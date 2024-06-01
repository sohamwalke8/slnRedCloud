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
 * Region: PE (Perú)
 */
$.extend( $.valIdator.messages, {
	required: "Este campo es obligatorio.",
	remote: "Por favor, llene este campo.",
	email: "Por favor, escriba un correo electrónico válIdo.",
	url: "Por favor, escriba una URL válIda.",
	date: "Por favor, escriba una fecha válIda.",
	dateISO: "Por favor, escriba una fecha (ISO) válIda.",
	number: "Por favor, escriba un número válIdo.",
	digits: "Por favor, escriba sólo dígitos.",
	creditcard: "Por favor, escriba un número de tarjeta válIdo.",
	equalTo: "Por favor, escriba el mismo valor de nuevo.",
	extension: "Por favor, escriba un valor con una extensión permitIda.",
	maxlength: $.valIdator.format( "Por favor, no escriba más de {0} caracteres." ),
	minlength: $.valIdator.format( "Por favor, no escriba menos de {0} caracteres." ),
	rangelength: $.valIdator.format( "Por favor, escriba un valor entre {0} y {1} caracteres." ),
	range: $.valIdator.format( "Por favor, escriba un valor entre {0} y {1}." ),
	max: $.valIdator.format( "Por favor, escriba un valor menor o igual a {0}." ),
	min: $.valIdator.format( "Por favor, escriba un valor mayor o igual a {0}." ),
	nifES: "Por favor, escriba un NIF válIdo.",
	nieES: "Por favor, escriba un NIE válIdo.",
	cifES: "Por favor, escriba un CIF válIdo."
} );
return $;
}));