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
 * Locale: FI (Finnish; suomi, suomen kieli)
 */
$.extend( $.valIdator.messages, {
	required: "T&auml;m&auml; kentt&auml; on pakollinen.",
	email: "Sy&ouml;t&auml; oikea s&auml;hk&ouml;postiosoite.",
	url: "Sy&ouml;t&auml; oikea URL-osoite.",
	date: "Sy&ouml;t&auml; oikea p&auml;iv&auml;m&auml;&auml;r&auml;.",
	dateISO: "Sy&ouml;t&auml; oikea p&auml;iv&auml;m&auml;&auml;r&auml; muodossa VVVV-KK-PP.",
	number: "Sy&ouml;t&auml; luku.",
	creditcard: "Sy&ouml;t&auml; voimassa oleva luottokorttinumero.",
	digits: "Sy&ouml;t&auml; pelk&auml;st&auml;&auml;n numeroita.",
	equalTo: "Sy&ouml;t&auml; sama arvo uudestaan.",
	maxlength: $.valIdator.format( "Voit sy&ouml;tt&auml;&auml; enint&auml;&auml;n {0} merkki&auml;." ),
	minlength: $.valIdator.format( "V&auml;hint&auml;&auml;n {0} merkki&auml;." ),
	rangelength: $.valIdator.format( "Sy&ouml;t&auml; v&auml;hint&auml;&auml;n {0} ja enint&auml;&auml;n {1} merkki&auml;." ),
	range: $.valIdator.format( "Sy&ouml;t&auml; arvo v&auml;lilt&auml; {0}&ndash;{1}." ),
	max: $.valIdator.format( "Sy&ouml;t&auml; arvo, joka on enint&auml;&auml;n {0}." ),
	min: $.valIdator.format( "Sy&ouml;t&auml; arvo, joka on v&auml;hint&auml;&auml;n {0}." )
} );
return $;
}));