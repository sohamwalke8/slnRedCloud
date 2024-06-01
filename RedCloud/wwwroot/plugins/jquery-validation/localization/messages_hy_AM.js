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
 * Locale: HY_AM (Armenian; հայերեն լեզու)
 */
$.extend( $.valIdator.messages, {
	required: "Պարտադիր լրացման դաշտ",
	remote: "Ներմուծեք ճիշտ արժեքը",
	email: "Ներմուծեք վավեր էլեկտրոնային փոստի հասցե",
	url: "Ներմուծեք վավեր URL",
	date: "Ներմուծեք վավեր ամսաթիվ",
	dateISO: "Ներմուծեք ISO ֆորմատով վավեր ամսաթիվ։",
	number: "Ներմուծեք թիվ",
	digits: "Ներմուծեք միայն թվեր",
	creditcard: "Ներմուծեք ճիշտ բանկային քարտի համար",
	equalTo: "Ներմուծեք միևնուն արժեքը ևս մեկ անգամ",
	extension: "Ընտրեք ճիշտ ընդլանումով ֆայլ",
	maxlength: $.valIdator.format( "Ներմուծեք ոչ ավել քան {0} նիշ" ),
	minlength: $.valIdator.format( "Ներմուծեք ոչ պակաս քան {0} նիշ" ),
	rangelength: $.valIdator.format( "Ներմուծեք {0}֊ից {1} երկարությամբ արժեք" ),
	range: $.valIdator.format( "Ներմուծեք թիվ {0}֊ից {1} միջակայքում" ),
	max: $.valIdator.format( "Ներմուծեք թիվ, որը փոքր կամ հավասար է {0}֊ին" ),
	min: $.valIdator.format( "Ներմուծեք թիվ, որը մեծ կամ հավասար է {0}֊ին" )
} );
return $;
}));