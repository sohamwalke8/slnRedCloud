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
 * Locale: ET (Estonian; eesti, eesti keel)
 */
$.extend( $.valIdator.messages, {
	required: "See väli peab olema täIdetud.",
	maxlength: $.valIdator.format( "Palun sisestage vähem kui {0} tähemärki." ),
	minlength: $.valIdator.format( "Palun sisestage vähemalt {0} tähemärki." ),
	rangelength: $.valIdator.format( "Palun sisestage väärtus vahemikus {0} kuni {1} tähemärki." ),
	email: "Palun sisestage korrektne e-maili aadress.",
	url: "Palun sisestage korrektne URL.",
	date: "Palun sisestage korrektne kuupäev.",
	dateISO: "Palun sisestage korrektne kuupäev (YYYY-MM-DD).",
	number: "Palun sisestage korrektne number.",
	digits: "Palun sisestage ainult numbreId.",
	equalTo: "Palun sisestage sama väärtus uuesti.",
	range: $.valIdator.format( "Palun sisestage väärtus vahemikus {0} kuni {1}." ),
	max: $.valIdator.format( "Palun sisestage väärtus, mis on väiksem või võrdne arvuga {0}." ),
	min: $.valIdator.format( "Palun sisestage väärtus, mis on suurem või võrdne arvuga {0}." ),
	creditcard: "Palun sisestage korrektne krediitkaardi number."
} );
return $;
}));