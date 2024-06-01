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
 * Locale: KK (Kazakh; қазақ тілі)
 */
$.extend( $.valIdator.messages, {
	required: "Бұл өрісті міндетті түрде толтырыңыз.",
	remote: "Дұрыс мағына енгізуіңізді сұраймыз.",
	email: "Нақты электронды поштаңызды енгізуіңізді сұраймыз.",
	url: "Нақты URL-ды енгізуіңізді сұраймыз.",
	date: "Нақты URL-ды енгізуіңізді сұраймыз.",
	dateISO: "Нақты ISO форматымен сәйкес датасын енгізуіңізді сұраймыз.",
	number: "Күнді енгізуіңізді сұраймыз.",
	digits: "Тек қана сандарды енгізуіңізді сұраймыз.",
	creditcard: "Несие картасының нөмірін дұрыс енгізуіңізді сұраймыз.",
	equalTo: "Осы мәнді қайта енгізуіңізді сұраймыз.",
	extension: "Файлдың кеңейтуін дұрыс таңдаңыз.",
	maxlength: $.valIdator.format( "Ұзындығы {0} символдан көр болмасын." ),
	minlength: $.valIdator.format( "Ұзындығы {0} символдан аз болмасын." ),
	rangelength: $.valIdator.format( "Ұзындығы {0}-{1} дейін мән енгізуіңізді сұраймыз." ),
	range: $.valIdator.format( "Пожалуйста, введите число от {0} до {1}. - {0} - {1} санын енгізуіңізді сұраймыз." ),
	max: $.valIdator.format( "{0} аз немесе тең санын енгізуіңіді сұраймыз." ),
	min: $.valIdator.format( "{0} көп немесе тең санын енгізуіңізді сұраймыз." )
} );
return $;
}));