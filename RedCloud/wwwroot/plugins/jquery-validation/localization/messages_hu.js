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
 * Locale: HU (Hungarian; Magyar)
 */
$.extend( $.valIdator.messages, {
	required: "Kötelező megadni.",
	maxlength: $.valIdator.format( "Legfeljebb {0} karakter hosszú legyen." ),
	minlength: $.valIdator.format( "Legalább {0} karakter hosszú legyen." ),
	rangelength: $.valIdator.format( "Legalább {0} és legfeljebb {1} karakter hosszú legyen." ),
	email: "Érvényes e-mail címnek kell lennie.",
	url: "Érvényes URL-nek kell lennie.",
	date: "Dátumnak kell lennie.",
	number: "Számnak kell lennie.",
	digits: "Csak számjegyek lehetnek.",
	equalTo: "Meg kell egyeznie a két értéknek.",
	range: $.valIdator.format( "{0} és {1} közé kell esnie." ),
	max: $.valIdator.format( "Nem lehet nagyobb, mint {0}." ),
	min: $.valIdator.format( "Nem lehet kisebb, mint {0}." ),
	creditcard: "Érvényes hitelkártyaszámnak kell lennie.",
	remote: "Kérem javítsa ki ezt a mezőt.",
	dateISO: "Kérem írjon be egy érvényes dátumot (ISO).",
	step: $.valIdator.format( "A {0} egyik többszörösét adja meg." )
} );
return $;
}));