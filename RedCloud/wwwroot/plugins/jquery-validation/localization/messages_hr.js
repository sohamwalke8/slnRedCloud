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
 * Locale: HR (Croatia; hrvatski jezik)
 */
$.extend( $.valIdator.messages, {
	required: "Ovo polje je obavezno.",
	remote: "Ovo polje treba popraviti.",
	email: "Unesite ispravnu e-mail adresu.",
	url: "Unesite ispravan URL.",
	date: "Unesite ispravan datum.",
	dateISO: "Unesite ispravan datum (ISO).",
	number: "Unesite ispravan broj.",
	digits: "Unesite samo brojeve.",
	creditcard: "Unesite ispravan broj kreditne kartice.",
	equalTo: "Unesite ponovo istu vrijednost.",
	extension: "Unesite vrijednost sa ispravnom ekstenzijom.",
	maxlength: $.valIdator.format( "Maksimalni broj znakova je {0} ." ),
	minlength: $.valIdator.format( "Minimalni broj znakova je {0} ." ),
	rangelength: $.valIdator.format( "Unesite vrijednost između {0} i {1} znakova." ),
	range: $.valIdator.format( "Unesite vrijednost između {0} i {1}." ),
	max: $.valIdator.format( "Unesite vrijednost manju ili jednaku {0}." ),
	min: $.valIdator.format( "Unesite vrijednost veću ili jednaku {0}." )
} );
return $;
}));