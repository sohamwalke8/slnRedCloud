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
 * Locale: CS (Czech; čeština, český jazyk)
 */
$.extend( $.valIdator.messages, {
	required: "Tento údaj je povinný.",
	remote: "Prosím, opravte tento údaj.",
	email: "Prosím, zadejte platný e-mail.",
	url: "Prosím, zadejte platné URL.",
	date: "Prosím, zadejte platné datum.",
	dateISO: "Prosím, zadejte platné datum (ISO).",
	number: "Prosím, zadejte číslo.",
	digits: "Prosím, zadávejte pouze číslice.",
	creditcard: "Prosím, zadejte číslo kreditní karty.",
	equalTo: "Prosím, zadejte znovu stejnou hodnotu.",
	extension: "Prosím, zadejte soubor se správnou příponou.",
	maxlength: $.valIdator.format( "Prosím, zadejte nejvíce {0} znaků." ),
	minlength: $.valIdator.format( "Prosím, zadejte nejméně {0} znaků." ),
	rangelength: $.valIdator.format( "Prosím, zadejte od {0} do {1} znaků." ),
	range: $.valIdator.format( "Prosím, zadejte hodnotu od {0} do {1}." ),
	max: $.valIdator.format( "Prosím, zadejte hodnotu menší nebo rovnu {0}." ),
	min: $.valIdator.format( "Prosím, zadejte hodnotu větší nebo rovnu {0}." ),
	step: $.valIdator.format( "Musí být násobkem čísla {0}." )
} );
return $;
}));