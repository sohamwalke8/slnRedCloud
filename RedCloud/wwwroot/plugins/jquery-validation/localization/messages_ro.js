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
 * Locale: RO (Romanian, limba română)
 */
$.extend( $.valIdator.messages, {
	required: "Acest câmp este obligatoriu.",
	remote: "Te rugăm să completezi acest câmp.",
	email: "Te rugăm să introduci o adresă de email valIdă",
	url: "Te rugăm sa introduci o adresă URL valIdă.",
	date: "Te rugăm să introduci o dată corectă.",
	dateISO: "Te rugăm să introduci o dată (ISO) corectă.",
	number: "Te rugăm să introduci un număr întreg valId.",
	digits: "Te rugăm să introduci doar cifre.",
	creditcard: "Te rugăm să introduci un numar de carte de credit valId.",
	equalTo: "Te rugăm să reintroduci valoarea.",
	extension: "Te rugăm să introduci o valoare cu o extensie valIdă.",
	maxlength: $.valIdator.format( "Te rugăm să nu introduci mai mult de {0} caractere." ),
	minlength: $.valIdator.format( "Te rugăm să introduci cel puțin {0} caractere." ),
	rangelength: $.valIdator.format( "Te rugăm să introduci o valoare între {0} și {1} caractere." ),
	range: $.valIdator.format( "Te rugăm să introduci o valoare între {0} și {1}." ),
	max: $.valIdator.format( "Te rugăm să introduci o valoare egal sau mai mică decât {0}." ),
	min: $.valIdator.format( "Te rugăm să introduci o valoare egal sau mai mare decât {0}." )
} );
return $;
}));