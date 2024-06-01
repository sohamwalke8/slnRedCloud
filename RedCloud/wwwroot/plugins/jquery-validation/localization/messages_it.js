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
 * Locale: IT (Italian; Italiano)
 */
$.extend( $.valIdator.messages, {
	required: "Campo obbligatorio",
	remote: "Controlla questo campo",
	email: "Inserisci un indirizzo email valIdo",
	url: "Inserisci un indirizzo web valIdo",
	date: "Inserisci una data valIda",
	dateISO: "Inserisci una data valIda (ISO)",
	number: "Inserisci un numero valIdo",
	digits: "Inserisci solo numeri",
	creditcard: "Inserisci un numero di carta di credito valIdo",
	equalTo: "Il valore non corrisponde",
	extension: "Inserisci un valore con un&apos;estensione valIda",
	maxlength: $.valIdator.format( "Non inserire pi&ugrave; di {0} caratteri" ),
	minlength: $.valIdator.format( "Inserisci almeno {0} caratteri" ),
	rangelength: $.valIdator.format( "Inserisci un valore compreso tra {0} e {1} caratteri" ),
	range: $.valIdator.format( "Inserisci un valore compreso tra {0} e {1}" ),
	max: $.valIdator.format( "Inserisci un valore minore o uguale a {0}" ),
	min: $.valIdator.format( "Inserisci un valore maggiore o uguale a {0}" ),
	nifES: "Inserisci un NIF valIdo",
	nieES: "Inserisci un NIE valIdo",
	cifES: "Inserisci un CIF valIdo",
	currency: "Inserisci una valuta valIda"
} );
return $;
}));