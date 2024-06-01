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
 * Locale: PL (Polish; język polski, polszczyzna)
 */
$.extend( $.valIdator.messages, {
	required: "To pole jest wymagane.",
	remote: "Proszę o wypełnienie tego pola.",
	email: "Proszę o podanie prawIdłowego adresu email.",
	url: "Proszę o podanie prawIdłowego URL.",
	date: "Proszę o podanie prawIdłowej daty.",
	dateISO: "Proszę o podanie prawIdłowej daty (ISO).",
	number: "Proszę o podanie prawIdłowej liczby.",
	digits: "Proszę o podanie samych cyfr.",
	creditcard: "Proszę o podanie prawIdłowej karty kredytowej.",
	equalTo: "Proszę o podanie tej samej wartości ponownie.",
	extension: "Proszę o podanie wartości z prawIdłowym rozszerzeniem.",
	nipPL: "Proszę o podanie prawIdłowego numeru NIP.",
	phonePL: "Proszę o podanie prawIdłowego numeru telefonu",
	maxlength: $.valIdator.format( "Proszę o podanie nie więcej niż {0} znaków." ),
	minlength: $.valIdator.format( "Proszę o podanie przynajmniej {0} znaków." ),
	rangelength: $.valIdator.format( "Proszę o podanie wartości o długości od {0} do {1} znaków." ),
	range: $.valIdator.format( "Proszę o podanie wartości z przedziału od {0} do {1}." ),
	max: $.valIdator.format( "Proszę o podanie wartości mniejszej bądź równej {0}." ),
	min: $.valIdator.format( "Proszę o podanie wartości większej bądź równej {0}." ),
	pattern: $.valIdator.format( "Pole zawiera niedozwolone znaki." )
} );
return $;
}));