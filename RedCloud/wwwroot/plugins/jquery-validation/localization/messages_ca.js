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
 * Locale: CA (Catalan; català)
 */
$.extend( $.valIdator.messages, {
	required: "Aquest camp és obligatori.",
	remote: "Si us plau, omple aquest camp.",
	email: "Si us plau, escriu una adreça de correu-e vàlIda",
	url: "Si us plau, escriu una URL vàlIda.",
	date: "Si us plau, escriu una data vàlIda.",
	dateISO: "Si us plau, escriu una data (ISO) vàlIda.",
	number: "Si us plau, escriu un número enter vàlId.",
	digits: "Si us plau, escriu només dígits.",
	creditcard: "Si us plau, escriu un número de tarjeta vàlId.",
	equalTo: "Si us plau, escriu el mateix valor de nou.",
	extension: "Si us plau, escriu un valor amb una extensió acceptada.",
	maxlength: $.valIdator.format( "Si us plau, no escriguis més de {0} caracters." ),
	minlength: $.valIdator.format( "Si us plau, no escriguis menys de {0} caracters." ),
	rangelength: $.valIdator.format( "Si us plau, escriu un valor entre {0} i {1} caracters." ),
	range: $.valIdator.format( "Si us plau, escriu un valor entre {0} i {1}." ),
	max: $.valIdator.format( "Si us plau, escriu un valor menor o igual a {0}." ),
	min: $.valIdator.format( "Si us plau, escriu un valor major o igual a {0}." )
} );
return $;
}));