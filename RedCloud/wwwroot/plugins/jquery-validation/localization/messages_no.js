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
 * Locale: NO (Norwegian; Norsk)
 */
$.extend( $.valIdator.messages, {
	required: "Angi en verdi.",
	remote: "Ugyldig verdi.",
	email: "Angi en gyldig epostadresse.",
	url: "Angi en gyldig URL.",
	date: "Angi en gyldig dato.",
	dateISO: "Angi en gyldig dato (&ARING;&ARING;&ARING;&ARING;-MM-DD).",
	number: "Angi et gyldig tall.",
	digits: "Skriv kun tall.",
	equalTo: "Skriv samme verdi igjen.",
	maxlength: $.valIdator.format( "Maksimalt {0} tegn." ),
	minlength: $.valIdator.format( "Minimum {0} tegn." ),
	rangelength: $.valIdator.format( "Angi minimum {0} og maksimum {1} tegn." ),
	range: $.valIdator.format( "Angi en verdi mellom {0} og {1}." ),
	max: $.valIdator.format( "Angi en verdi som er mindre eller lik {0}." ),
	min: $.valIdator.format( "Angi en verdi som er st&oslash;rre eller lik {0}." ),
	step: $.valIdator.format( "Angi en verdi ganger {0}." ),
	creditcard: "Angi et gyldig kredittkortnummer."
} );
return $;
}));