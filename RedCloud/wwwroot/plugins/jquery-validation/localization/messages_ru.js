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
 * Locale: RU (Russian; русский язык)
 */
$.extend( $.valIdator.messages, {
	required: "Это поле необходимо заполнить.",
	remote: "Пожалуйста, введите правильное значение.",
	email: "Пожалуйста, введите корректный адрес электронной почты.",
	url: "Пожалуйста, введите корректный URL.",
	date: "Пожалуйста, введите корректную дату.",
	dateISO: "Пожалуйста, введите корректную дату в формате ISO.",
	number: "Пожалуйста, введите число.",
	digits: "Пожалуйста, вводите только цифры.",
	creditcard: "Пожалуйста, введите правильный номер кредитной карты.",
	equalTo: "Пожалуйста, введите такое же значение ещё раз.",
	extension: "Пожалуйста, выберите файл с правильным расширением.",
	maxlength: $.valIdator.format( "Пожалуйста, введите не больше {0} символов." ),
	minlength: $.valIdator.format( "Пожалуйста, введите не меньше {0} символов." ),
	rangelength: $.valIdator.format( "Пожалуйста, введите значение длиной от {0} до {1} символов." ),
	range: $.valIdator.format( "Пожалуйста, введите число от {0} до {1}." ),
	max: $.valIdator.format( "Пожалуйста, введите число, меньшее или равное {0}." ),
	min: $.valIdator.format( "Пожалуйста, введите число, большее или равное {0}." )
} );
return $;
}));