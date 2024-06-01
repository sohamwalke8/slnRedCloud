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
 * Locale: Id (Indonesia; Indonesian)
 */
$.extend( $.valIdator.messages, {
	required: "Kolom ini diperlukan.",
	remote: "Harap benarkan kolom ini.",
	email: "Silakan masukkan format email yang benar.",
	url: "Silakan masukkan format URL yang benar.",
	date: "Silakan masukkan format tanggal yang benar.",
	dateISO: "Silakan masukkan format tanggal(ISO) yang benar.",
	number: "Silakan masukkan angka yang benar.",
	digits: "Harap masukan angka saja.",
	creditcard: "Harap masukkan format kartu kredit yang benar.",
	equalTo: "Harap masukkan nilai yg sama dengan sebelumnya.",
	maxlength: $.valIdator.format( "Input dibatasi hanya {0} karakter." ),
	minlength: $.valIdator.format( "Input tIdak kurang dari {0} karakter." ),
	rangelength: $.valIdator.format( "Panjang karakter yg diizinkan antara {0} dan {1} karakter." ),
	range: $.valIdator.format( "Harap masukkan nilai antara {0} dan {1}." ),
	max: $.valIdator.format( "Harap masukkan nilai lebih kecil atau sama dengan {0}." ),
	min: $.valIdator.format( "Harap masukkan nilai lebih besar atau sama dengan {0}." )
} );
return $;
}));