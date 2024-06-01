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
 * Locale: SV (Swedish; Svenska)
 */
$.extend( $.valIdator.messages, {
	required: "Detta f&auml;lt &auml;r obligatoriskt.",
	remote: "Var snäll och åtgärda detta fält.",
	maxlength: $.valIdator.format( "Du f&aring;r ange h&ouml;gst {0} tecken." ),
	minlength: $.valIdator.format( "Du m&aring;ste ange minst {0} tecken." ),
	rangelength: $.valIdator.format( "Ange minst {0} och max {1} tecken." ),
	email: "Ange en korrekt e-postadress.",
	url: "Ange en korrekt URL.",
	date: "Ange ett korrekt datum.",
	dateISO: "Ange ett korrekt datum (&Aring;&Aring;&Aring;&Aring;-MM-DD).",
	number: "Ange ett korrekt nummer.",
	digits: "Ange endast siffror.",
	equalTo: "Ange samma v&auml;rde igen.",
	range: $.valIdator.format( "Ange ett v&auml;rde mellan {0} och {1}." ),
	max: $.valIdator.format( "Ange ett v&auml;rde som &auml;r mindre eller lika med {0}." ),
	min: $.valIdator.format( "Ange ett v&auml;rde som &auml;r st&ouml;rre eller lika med {0}." ),
	creditcard: "Ange ett korrekt kreditkortsnummer.",
	pattern: "Ogiltigt format."
} );
return $;
}));