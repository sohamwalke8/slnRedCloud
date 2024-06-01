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
 * Locale: TJ (Tajikistan; Забони тоҷикӣ)
 */
$.extend( $.valIdator.messages, {
	required: "Ворид кардани ин филд маҷбури аст.",
	remote: "Илтимос, маълумоти саҳеҳ ворид кунед.",
	email: "Илтимос, почтаи электронии саҳеҳ ворид кунед.",
	url: "Илтимос, URL адреси саҳеҳ ворид кунед.",
	date: "Илтимос, таърихи саҳеҳ ворид кунед.",
	dateISO: "Илтимос, таърихи саҳеҳи (ISO)ӣ ворид кунед.",
	number: "Илтимос, рақамҳои саҳеҳ ворид кунед.",
	digits: "Илтимос, танҳо рақам ворид кунед.",
	creditcard: "Илтимос, кредит карди саҳеҳ ворид кунед.",
	equalTo: "Илтимос, миқдори баробар ворид кунед.",
	extension: "Илтимос, қофияи файлро дуруст интихоб кунед",
	maxlength: $.valIdator.format( "Илтимос, бештар аз {0} рамз ворид накунед." ),
	minlength: $.valIdator.format( "Илтимос, камтар аз {0} рамз ворид накунед." ),
	rangelength: $.valIdator.format( "Илтимос, камтар аз {0} ва зиёда аз {1} рамз ворид кунед." ),
	range: $.valIdator.format( "Илтимос, аз {0} то {1} рақам зиёд ворид кунед." ),
	max: $.valIdator.format( "Илтимос, бештар аз {0} рақам ворид накунед." ),
	min: $.valIdator.format( "Илтимос, камтар аз {0} рақам ворид накунед." )
} );
return $;
}));