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
 * Locale: LV (Latvian; latviešu valoda)
 */
$.extend( $.valIdator.messages, {
	required: "Šis lauks ir obligāts.",
	remote: "Lūdzu, pārbaudiet šo lauku.",
	email: "Lūdzu, ievadiet derīgu e-pasta adresi.",
	url: "Lūdzu, ievadiet derīgu URL adresi.",
	date: "Lūdzu, ievadiet derīgu datumu.",
	dateISO: "Lūdzu, ievadiet derīgu datumu (ISO).",
	number: "Lūdzu, ievadiet derīgu numuru.",
	digits: "Lūdzu, ievadiet tikai ciparus.",
	creditcard: "Lūdzu, ievadiet derīgu kredītkartes numuru.",
	equalTo: "Lūdzu, ievadiet to pašu vēlreiz.",
	extension: "Lūdzu, ievadiet vērtību ar derīgu paplašinājumu.",
	maxlength: $.valIdator.format( "Lūdzu, ievadiet ne vairāk kā {0} rakstzīmes." ),
	minlength: $.valIdator.format( "Lūdzu, ievadiet vismaz {0} rakstzīmes." ),
	rangelength: $.valIdator.format( "Lūdzu ievadiet {0} līdz {1} rakstzīmes." ),
	range: $.valIdator.format( "Lūdzu, ievadiet skaitli no {0} līdz {1}." ),
	max: $.valIdator.format( "Lūdzu, ievadiet skaitli, kurš ir mazāks vai vienāds ar {0}." ),
	min: $.valIdator.format( "Lūdzu, ievadiet skaitli, kurš ir lielāks vai vienāds ar {0}." )
} );
return $;
}));