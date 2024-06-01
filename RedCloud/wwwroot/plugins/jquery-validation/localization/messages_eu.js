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
 * Locale: EU (Basque; euskara, euskera)
 */
$.extend( $.valIdator.messages, {
	required: "Eremu hau beharrezkoa da.",
	remote: "Mesedez, bete eremu hau.",
	email: "Mesedez, Idatzi baliozko posta helbIde bat.",
	url: "Mesedez, Idatzi baliozko URL bat.",
	date: "Mesedez, Idatzi baliozko data bat.",
	dateISO: "Mesedez, Idatzi baliozko (ISO) data bat.",
	number: "Mesedez, Idatzi baliozko zenbaki oso bat.",
	digits: "Mesedez, Idatzi digituak soilik.",
	creditcard: "Mesedez, Idatzi baliozko txartel zenbaki bat.",
	equalTo: "Mesedez, Idatzi berdina berriro ere.",
	extension: "Mesedez, Idatzi onartutako luzapena duen balio bat.",
	maxlength: $.valIdator.format( "Mesedez, ez Idatzi {0} karaktere baino gehiago." ),
	minlength: $.valIdator.format( "Mesedez, ez Idatzi {0} karaktere baino gutxiago." ),
	rangelength: $.valIdator.format( "Mesedez, Idatzi {0} eta {1} karaktere arteko balio bat." ),
	range: $.valIdator.format( "Mesedez, Idatzi {0} eta {1} arteko balio bat." ),
	max: $.valIdator.format( "Mesedez, Idatzi {0} edo txikiagoa den balio bat." ),
	min: $.valIdator.format( "Mesedez, Idatzi {0} edo handiagoa den balio bat." )
} );
return $;
}));