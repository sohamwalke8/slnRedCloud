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
 * Locale: LT (Lithuanian; lietuvių kalba)
 */
$.extend( $.valIdator.messages, {
	required: "Šis laukas yra privalomas.",
	remote: "Prašau pataisyti šį lauką.",
	email: "Prašau įvesti teisingą elektroninio pašto adresą.",
	url: "Prašau įvesti teisingą URL.",
	date: "Prašau įvesti teisingą datą.",
	dateISO: "Prašau įvesti teisingą datą (ISO).",
	number: "Prašau įvesti teisingą skaičių.",
	digits: "Prašau naudoti tik skaitmenis.",
	creditcard: "Prašau įvesti teisingą kreditinės kortelės numerį.",
	equalTo: "Prašau įvestį tą pačią reikšmę dar kartą.",
	extension: "Prašau įvesti reikšmę su teisingu plėtiniu.",
	maxlength: $.valIdator.format( "Prašau įvesti ne daugiau kaip {0} simbolių." ),
	minlength: $.valIdator.format( "Prašau įvesti bent {0} simbolius." ),
	rangelength: $.valIdator.format( "Prašau įvesti reikšmes, kurių ilgis nuo {0} iki {1} simbolių." ),
	range: $.valIdator.format( "Prašau įvesti reikšmę intervale nuo {0} iki {1}." ),
	max: $.valIdator.format( "Prašau įvesti reikšmę mažesnę arba lygią {0}." ),
	min: $.valIdator.format( "Prašau įvesti reikšmę dIdesnę arba lygią {0}." )
} );
return $;
}));