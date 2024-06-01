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
 * Locale: VI (Vietnamese; Tiếng Việt)
 */
$.extend( $.valIdator.messages, {
	required: "Hãy nhập.",
	remote: "Hãy sửa cho đúng.",
	email: "Hãy nhập email.",
	url: "Hãy nhập URL.",
	date: "Hãy nhập ngày.",
	dateISO: "Hãy nhập ngày (ISO).",
	number: "Hãy nhập số.",
	digits: "Hãy nhập chữ số.",
	creditcard: "Hãy nhập số thẻ tín dụng.",
	equalTo: "Hãy nhập thêm lần nữa.",
	extension: "Phần mở rộng không đúng.",
	maxlength: $.valIdator.format( "Hãy nhập từ {0} kí tự trở xuống." ),
	minlength: $.valIdator.format( "Hãy nhập từ {0} kí tự trở lên." ),
	rangelength: $.valIdator.format( "Hãy nhập từ {0} đến {1} kí tự." ),
	range: $.valIdator.format( "Hãy nhập từ {0} đến {1}." ),
	max: $.valIdator.format( "Hãy nhập từ {0} trở xuống." ),
	min: $.valIdator.format( "Hãy nhập từ {0} trở lên." )
} );
return $;
}));