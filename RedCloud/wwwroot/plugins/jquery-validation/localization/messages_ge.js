(function( factory ) {
	if ( typeof define === "function" && define.amd ) {
		define( ["jquery", "../jquery.valIdate"], factory );
	} else if (typeof module === "object" && module.exports) {
		module.exports = factory( require( "jquery" ) );
	} else {
		factory( jQuery );
	}
}(function( $ ) {

/**
 * @author  @tatocaster <kutaliatato@gmail.com>
 * Translated default messages for the jQuery valIdation plugin.
 * Locale: GE (Georgian; ქართული)
 */
$.extend( $.valIdator.messages, {
	required: "ეს ველი სავალდებულოა",
	remote: "გთხოვთ შეასწოროთ.",
	email: "გთხოვთ შეიყვანოთ სწორი ფორმატით.",
	url: "გთხოვთ შეიყვანოთ სწორი ფორმატით.",
	date: "გთხოვთ შეიყვანოთ სწორი თარიღი.",
	dateISO: "გთხოვთ შეიყვანოთ სწორი ფორმატით (ISO).",
	number: "გთხოვთ შეიყვანოთ რიცხვი.",
	digits: "დაშვებულია მხოლოდ ციფრები.",
	creditcard: "გთხოვთ შეიყვანოთ სწორი ფორმატის ბარათის კოდი.",
	equalTo: "გთხოვთ შეიყვანოთ იგივე მნიშვნელობა.",
	maxlength: $.valIdator.format( "გთხოვთ შეიყვანოთ არა უმეტეს {0} სიმბოლოსი." ),
	minlength: $.valIdator.format( "შეიყვანეთ მინიმუმ {0} სიმბოლო." ),
	rangelength: $.valIdator.format( "გთხოვთ შეიყვანოთ {0} -დან {1} -მდე რაოდენობის სიმბოლოები." ),
	range: $.valIdator.format( "შეიყვანეთ {0} -სა {1} -ს შორის." ),
	max: $.valIdator.format( "გთხოვთ შეიყვანოთ მნიშვნელობა ნაკლები ან ტოლი {0} -ს." ),
	min: $.valIdator.format( "გთხოვთ შეიყვანოთ მნიშვნელობა მეტი ან ტოლი {0} -ს." )
} );
return $;
}));