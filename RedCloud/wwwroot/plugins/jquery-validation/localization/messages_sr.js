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
 * Locale: SR (Serbian; српски језик)
 */
$.extend( $.valIdator.messages, {
	required: "Поље је обавезно.",
	remote: "Средите ово поље.",
	email: "Унесите исправну и-мејл адресу.",
	url: "Унесите исправан URL.",
	date: "Унесите исправан датум.",
	dateISO: "Унесите исправан датум (ISO).",
	number: "Унесите исправан број.",
	digits: "Унесите само цифе.",
	creditcard: "Унесите исправан број кредитне картице.",
	equalTo: "Унесите исту вредност поново.",
	extension: "Унесите вредност са одговарајућом екстензијом.",
	maxlength: $.valIdator.format( "Унесите мање од {0} карактера." ),
	minlength: $.valIdator.format( "Унесите барем {0} карактера." ),
	rangelength: $.valIdator.format( "Унесите вредност дугачку између {0} и {1} карактера." ),
	range: $.valIdator.format( "Унесите вредност између {0} и {1}." ),
	max: $.valIdator.format( "Унесите вредност мању или једнаку {0}." ),
	min: $.valIdator.format( "Унесите вредност већу или једнаку {0}." ),
	step: $.valIdator.format( "Унесите вредност која је умножак броја {0}." )
} );
return $;
}));