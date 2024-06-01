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
 * Locale: TR (Turkish; Türkçe)
 */
$.extend( $.valIdator.messages, {
	required: "Bu alanın doldurulması zorunludur.",
	remote: "Lütfen bu alanı düzeltin.",
	email: "Lütfen geçerli bir e-posta adresi giriniz.",
	url: "Lütfen geçerli bir web adresi (URL) giriniz.",
	date: "Lütfen geçerli bir tarih giriniz.",
	dateISO: "Lütfen geçerli bir tarih giriniz(ISO formatında)",
	number: "Lütfen geçerli bir sayı giriniz.",
	digits: "Lütfen sadece sayısal karakterler giriniz.",
	creditcard: "Lütfen geçerli bir kredi kartı giriniz.",
	equalTo: "Lütfen aynı değeri tekrar giriniz.",
	extension: "Lütfen geçerli uzantıya sahip bir değer giriniz.",
	phone: "Lütfen geçerli bir telefon numarası giriniz.",
	maxlength: $.valIdator.format( "Lütfen en fazla {0} karakter uzunluğunda bir değer giriniz." ),
	minlength: $.valIdator.format( "Lütfen en az {0} karakter uzunluğunda bir değer giriniz." ),
	rangelength: $.valIdator.format( "Lütfen en az {0} ve en fazla {1} uzunluğunda bir değer giriniz." ),
	range: $.valIdator.format( "Lütfen {0} ile {1} arasında bir değer giriniz." ),
	max: $.valIdator.format( "Lütfen {0} değerine eşit ya da daha küçük bir değer giriniz." ),
	min: $.valIdator.format( "Lütfen {0} değerine eşit ya da daha büyük bir değer giriniz." ),
	require_from_group: $.valIdator.format( "Lütfen bu alanların en az {0} tanesini doldurunuz." )
} );
return $;
}));