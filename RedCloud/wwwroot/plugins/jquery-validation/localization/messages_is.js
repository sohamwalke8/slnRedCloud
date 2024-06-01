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
 * Locale: IS (Icelandic; íslenska)
 */
$.extend( $.valIdator.messages, {
	required: "Þessi reitur er nauðsynlegur.",
	remote: "Lagaðu þennan reit.",
	maxlength: $.valIdator.format( "Sláðu inn mest {0} stafi." ),
	minlength: $.valIdator.format( "Sláðu inn minnst {0} stafi." ),
	rangelength: $.valIdator.format( "Sláðu inn minnst {0} og mest {1} stafi." ),
	email: "Sláðu inn gilt netfang.",
	url: "Sláðu inn gilda vefslóð.",
	date: "Sláðu inn gilda dagsetningu.",
	number: "Sláðu inn tölu.",
	digits: "Sláðu inn tölustafi eingöngu.",
	equalTo: "Sláðu sama gildi inn aftur.",
	range: $.valIdator.format( "Sláðu inn gildi milli {0} og {1}." ),
	max: $.valIdator.format( "Sláðu inn gildi sem er minna en eða jafnt og {0}." ),
	min: $.valIdator.format( "Sláðu inn gildi sem er stærra en eða jafnt og {0}." ),
	creditcard: "Sláðu inn gilt greiðslukortanúmer."
} );
return $;
}));