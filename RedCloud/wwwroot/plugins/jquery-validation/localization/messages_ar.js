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
 * Locale: AR (Arabic; العربية)
 */
$.extend( $.valIdator.messages, {
	required: "هذا الحقل إلزامي",
	remote: "يرجى تصحيح هذا الحقل للمتابعة",
	email: "رجاء إدخال عنوان بريد إلكتروني صحيح",
	url: "رجاء إدخال عنوان موقع إلكتروني صحيح",
	date: "رجاء إدخال تاريخ صحيح",
	dateISO: "رجاء إدخال تاريخ صحيح (ISO)",
	number: "رجاء إدخال عدد بطريقة صحيحة",
	digits: "رجاء إدخال أرقام فقط",
	creditcard: "رجاء إدخال رقم بطاقة ائتمان صحيح",
	equalTo: "رجاء إدخال نفس القيمة",
	extension: "رجاء إدخال ملف بامتداد موافق عليه",
	maxlength: $.valIdator.format( "الحد الأقصى لعدد الحروف هو {0}" ),
	minlength: $.valIdator.format( "الحد الأدنى لعدد الحروف هو {0}" ),
	rangelength: $.valIdator.format( "عدد الحروف يجب أن يكون بين {0} و {1}" ),
	range: $.valIdator.format( "رجاء إدخال عدد قيمته بين {0} و {1}" ),
	max: $.valIdator.format( "رجاء إدخال عدد أقل من أو يساوي {0}" ),
	min: $.valIdator.format( "رجاء إدخال عدد أكبر من أو يساوي {0}" )
} );
return $;
}));