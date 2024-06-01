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
 * Locale: MK (Macedonian; македонски јазик)
 */
$.extend( $.valIdator.messages, {
	required: "Полето е задолжително.",
	remote: "Поправете го ова поле",
	email: "Внесете правилна e-mail адреса",
	url: "Внесете правилен URL.",
	date: "Внесете правилен датум",
	dateISO: "Внесете правилен датум (ISO).",
	number: "Внесете правилен број.",
	digits: "Внесете само бројки.",
	creditcard: "Внесете правилен број на кредитната картичка.",
	equalTo: "Внесете ја истата вредност повторно.",
	extension: "Внесете вредност со соодветна екстензија.",
	maxlength: $.valIdator.format( "Внесете максимално {0} знаци." ),
	minlength: $.valIdator.format( "Внесете барем {0} знаци." ),
	rangelength: $.valIdator.format( "Внесете вредност со должина помеѓу {0} и {1} знаци." ),
	range: $.valIdator.format( "Внесете вредност помеѓу {0} и {1}." ),
	max: $.valIdator.format( "Внесете вредност помала или еднаква на {0}." ),
	min: $.valIdator.format( "Внесете вредност поголема или еднаква на {0}" )
} );
return $;
}));