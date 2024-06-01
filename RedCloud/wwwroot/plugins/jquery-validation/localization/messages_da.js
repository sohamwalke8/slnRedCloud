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
 * Locale: DA (Danish; dansk)
 */
$.extend( $.valIdator.messages, {
	required: "Dette felt er påkrævet.",
	remote: "Ret venligst dette felt",
	email: "Indtast en gyldig email-adresse.",
	url: "Indtast en gyldig URL.",
	date: "Indtast en gyldig dato.",
	number: "Indtast et tal.",
	digits: "Indtast kun cifre.",
	creditcard: "Indtast et gyldigt kreditkortnummer.",
	equalTo: "Indtast den samme værdi igen.",
	time: "Angiv en gyldig tId mellem kl. 00:00 og 23:59.",
	ipv4: "Angiv venligst en gyldig IPv4-adresse.",
	ipv6: "Angiv venligst en gyldig IPv6-adresse.",
	require_from_group:  $.valIdator.format( "Angiv mindst {0} af disse felter." ),
	extension: "Indtast venligst en værdi med en gyldig endelse",
	pattern: "Ugyldigt format",
	lettersonly: "Angiv venligst kun bogstaver.",
	nowhitespace: "Må ikke indholde mellemrum",
	maxlength: $.valIdator.format( "Indtast højst {0} tegn." ),
	minlength: $.valIdator.format( "Indtast mindst {0} tegn." ),
	rangelength: $.valIdator.format( "Indtast mindst {0} og højst {1} tegn." ),
	range: $.valIdator.format( "Angiv en værdi mellem {0} og {1}." ),
	max: $.valIdator.format( "Angiv en værdi der højst er {0}." ),
	min: $.valIdator.format( "Angiv en værdi der mindst er {0}." ),
	minWords: $.valIdator.format( "Indtast venligst mindst {0} ord" ),
	maxWords:  $.valIdator.format( "Indtast venligst højst {0} ord" ),
	step: $.valIdator.format( "Angiv en værdi gange {0}." ),
	notEqualTo: "Angiv en anden værdi, værdierne må ikke være det samme.",
	integer: "Angiv et ikke-decimaltal, der er positivt eller negativt."
} );
return $;
}));