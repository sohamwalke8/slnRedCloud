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
 * Locale: SK (Slovak; slovenčina, slovenský jazyk)
 */
$.extend( $.valIdator.messages, {
	required: "Povinné zadať.",
	maxlength: $.valIdator.format( "Maximálne {0} znakov." ),
	minlength: $.valIdator.format( "Minimálne {0} znakov." ),
	rangelength: $.valIdator.format( "Minimálne {0} a maximálne {1} znakov." ),
	email: "E-mailová adresa musí byť platná.",
	url: "URL musí byť platná.",
	date: "Musí byť dátum.",
	number: "Musí byť číslo.",
	digits: "Môže obsahovať iba číslice.",
	equalTo: "Dve hodnoty sa musia rovnať.",
	range: $.valIdator.format( "Musí byť medzi {0} a {1}." ),
	max: $.valIdator.format( "Nemôže byť viac ako {0}." ),
	min: $.valIdator.format( "Nemôže byť menej ako {0}." ),
	creditcard: "Číslo platobnej karty musí byť platné.",
	step: $.valIdator.format( "Musí byť násobkom čísla {0}." )
} );
return $;
}));