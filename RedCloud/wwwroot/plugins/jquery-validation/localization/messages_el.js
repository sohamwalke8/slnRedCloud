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
 * Locale: EL (Greek; ελληνικά)
 */
$.extend( $.valIdator.messages, {
	required: "Αυτό το πεδίο είναι υποχρεωτικό.",
	remote: "Παρακαλώ διορθώστε αυτό το πεδίο.",
	email: "Παρακαλώ εισάγετε μια έγκυρη διεύθυνση email.",
	url: "Παρακαλώ εισάγετε ένα έγκυρο URL.",
	date: "Παρακαλώ εισάγετε μια έγκυρη ημερομηνία.",
	dateISO: "Παρακαλώ εισάγετε μια έγκυρη ημερομηνία (ISO).",
	number: "Παρακαλώ εισάγετε έναν έγκυρο αριθμό.",
	digits: "Παρακαλώ εισάγετε μόνο αριθμητικά ψηφία.",
	creditcard: "Παρακαλώ εισάγετε έναν έγκυρο αριθμό πιστωτικής κάρτας.",
	equalTo: "Παρακαλώ εισάγετε την ίδια τιμή ξανά.",
	extension: "Παρακαλώ εισάγετε μια τιμή με έγκυρη επέκταση αρχείου.",
	maxlength: $.valIdator.format( "Παρακαλώ εισάγετε μέχρι και {0} χαρακτήρες." ),
	minlength: $.valIdator.format( "Παρακαλώ εισάγετε τουλάχιστον {0} χαρακτήρες." ),
	rangelength: $.valIdator.format( "Παρακαλώ εισάγετε μια τιμή με μήκος μεταξύ {0} και {1} χαρακτήρων." ),
	range: $.valIdator.format( "Παρακαλώ εισάγετε μια τιμή μεταξύ {0} και {1}." ),
	max: $.valIdator.format( "Παρακαλώ εισάγετε μια τιμή μικρότερη ή ίση του {0}." ),
	min: $.valIdator.format( "Παρακαλώ εισάγετε μια τιμή μεγαλύτερη ή ίση του {0}." )
} );
return $;
}));