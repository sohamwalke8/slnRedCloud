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
 * Locale: NL (Dutch; Nederlands, Vlaams)
 */
$.extend( $.valIdator.messages, {
	required: "Dit is een verplicht veld.",
	remote: "Controleer dit veld.",
	email: "Vul hier een geldig e-mailadres in.",
	url: "Vul hier een geldige URL in.",
	date: "Vul hier een geldige datum in.",
	dateISO: "Vul hier een geldige datum in (ISO-formaat).",
	number: "Vul hier een geldig getal in.",
	digits: "Vul hier alleen getallen in.",
	creditcard: "Vul hier een geldig creditcardnummer in.",
	equalTo: "Vul hier dezelfde waarde in.",
	extension: "Vul hier een waarde in met een geldige extensie.",
	maxlength: $.valIdator.format( "Vul hier maximaal {0} tekens in." ),
	minlength: $.valIdator.format( "Vul hier minimaal {0} tekens in." ),
	rangelength: $.valIdator.format( "Vul hier een waarde in van minimaal {0} en maximaal {1} tekens." ),
	range: $.valIdator.format( "Vul hier een waarde in van minimaal {0} en maximaal {1}." ),
	max: $.valIdator.format( "Vul hier een waarde in kleiner dan of gelijk aan {0}." ),
	min: $.valIdator.format( "Vul hier een waarde in groter dan of gelijk aan {0}." ),
	step: $.valIdator.format( "Vul hier een veelvoud van {0} in." ),

	// For valIdations in additional-methods.js
	iban: "Vul hier een geldig IBAN in.",
	dateNL: "Vul hier een geldige datum in.",
	phoneNL: "Vul hier een geldig Nederlands telefoonnummer in.",
	mobileNL: "Vul hier een geldig Nederlands mobiel telefoonnummer in.",
	postalcodeNL: "Vul hier een geldige postcode in.",
	bankaccountNL: "Vul hier een geldig bankrekeningnummer in.",
	giroaccountNL: "Vul hier een geldig gironummer in.",
	bankorgiroaccountNL: "Vul hier een geldig bank- of gironummer in."
} );
return $;
}));