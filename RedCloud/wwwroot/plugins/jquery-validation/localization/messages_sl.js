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
 * Language: SL (Slovenian; slovenski jezik)
 */
$.extend( $.valIdator.messages, {
	required: "To polje je obvezno.",
	remote: "Prosimo popravite to polje.",
	email: "Prosimo vnesite veljaven email naslov.",
	url: "Prosimo vnesite veljaven URL naslov.",
	date: "Prosimo vnesite veljaven datum.",
	dateISO: "Prosimo vnesite veljaven ISO datum.",
	number: "Prosimo vnesite veljavno število.",
	digits: "Prosimo vnesite samo števila.",
	creditcard: "Prosimo vnesite veljavno številko kreditne kartice.",
	equalTo: "Prosimo ponovno vnesite vrednost.",
	extension: "Prosimo vnesite vrednost z veljavno končnico.",
	maxlength: $.valIdator.format( "Prosimo vnesite največ {0} znakov." ),
	minlength: $.valIdator.format( "Prosimo vnesite najmanj {0} znakov." ),
	rangelength: $.valIdator.format( "Prosimo vnesite najmanj {0} in največ {1} znakov." ),
	range: $.valIdator.format( "Prosimo vnesite vrednost med {0} in {1}." ),
	max: $.valIdator.format( "Prosimo vnesite vrednost manjše ali enako {0}." ),
	min: $.valIdator.format( "Prosimo vnesite vrednost večje ali enako {0}." )
} );
return $;
}));