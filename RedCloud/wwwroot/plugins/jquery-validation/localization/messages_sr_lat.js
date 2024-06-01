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
 * Locale: SR (Serbian - Latin alphabet; srpski jezik - latinica)
 */
$.extend( $.valIdator.messages, {
	required: "Polje je obavezno.",
	remote: "Sredite ovo polje.",
	email: "Unesite ispravnu e-mail adresu",
	url: "Unesite ispravan URL.",
	date: "Unesite ispravan datum.",
	dateISO: "Unesite ispravan datum (ISO).",
	number: "Unesite ispravan broj.",
	digits: "Unesite samo cifre.",
	creditcard: "Unesite ispravan broj kreditne kartice.",
	equalTo: "Unesite istu vrednost ponovo.",
	extension: "Unesite vrednost sa odgovarajućom ekstenzijom.",
	maxlength: $.valIdator.format( "Unesite manje od {0} karaktera." ),
	minlength: $.valIdator.format( "Unesite barem {0} karaktera." ),
	rangelength: $.valIdator.format( "Unesite vrednost dugačku između {0} i {1} karaktera." ),
	range: $.valIdator.format( "Unesite vrednost između {0} i {1}." ),
	max: $.valIdator.format( "Unesite vrednost manju ili jednaku {0}." ),
	min: $.valIdator.format( "Unesite vrednost veću ili jednaku {0}." ),
	step: $.valIdator.format( "Unesite vrednost koja je umnožak broja {0}." )
} );
return $;
}));