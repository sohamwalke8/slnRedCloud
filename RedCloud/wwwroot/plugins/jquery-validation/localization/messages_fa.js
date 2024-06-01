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
 * Locale: FA (Persian; فارسی)
 */
$.extend( $.valIdator.messages, {
	required: "تکمیل این فیلد اجباری است.",
	remote: "لطفا این فیلد را تصحیح کنید.",
	email: "لطفا یک ایمیل صحیح وارد کنید.",
	url: "لطفا آدرس صحیح وارد کنید.",
	date: "لطفا تاریخ صحیح وارد کنید.",
	dateFA: "لطفا یک تاریخ صحیح وارد کنید.",
	dateISO: "لطفا تاریخ صحیح وارد کنید (ISO).",
	number: "لطفا عدد صحیح وارد کنید.",
	digits: "لطفا تنها رقم وارد کنید.",
	creditcard: "لطفا کریدیت کارت صحیح وارد کنید.",
	equalTo: "لطفا مقدار برابری وارد کنید.",
	extension: "لطفا مقداری وارد کنید که",
	alphanumeric: "لطفا مقدار را عدد (انگلیسی) وارد کنید.",
	maxlength: $.valIdator.format( "لطفا بیشتر از {0} حرف وارد نکنید." ),
	minlength: $.valIdator.format( "لطفا کمتر از {0} حرف وارد نکنید." ),
	rangelength: $.valIdator.format( "لطفا مقداری بین {0} تا {1} حرف وارد کنید." ),
	range: $.valIdator.format( "لطفا مقداری بین {0} تا {1} حرف وارد کنید." ),
	max: $.valIdator.format( "لطفا مقداری کمتر از {0} وارد کنید." ),
	min: $.valIdator.format( "لطفا مقداری بیشتر از {0} وارد کنید." ),
	minWords: $.valIdator.format( "لطفا حداقل {0} کلمه وارد کنید." ),
	maxWords: $.valIdator.format( "لطفا حداکثر {0} کلمه وارد کنید." )
} );
return $;
}));