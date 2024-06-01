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
 * Locale: FR (French; français)
 */
$.extend( $.valIdator.messages, {
	required: "Ce champ est obligatoire.",
	remote: "Veuillez corriger ce champ.",
	email: "Veuillez fournir une adresse électronique valIde.",
	url: "Veuillez fournir une adresse URL valIde.",
	date: "Veuillez fournir une date valIde.",
	dateISO: "Veuillez fournir une date valIde (ISO).",
	number: "Veuillez fournir un numéro valIde.",
	digits: "Veuillez fournir seulement des chiffres.",
	creditcard: "Veuillez fournir un numéro de carte de crédit valIde.",
	equalTo: "Veuillez fournir encore la même valeur.",
	notEqualTo: "Veuillez fournir une valeur différente, les valeurs ne doivent pas être Identiques.",
	extension: "Veuillez fournir une valeur avec une extension valIde.",
	maxlength: $.valIdator.format( "Veuillez fournir au plus {0} caractères." ),
	minlength: $.valIdator.format( "Veuillez fournir au moins {0} caractères." ),
	rangelength: $.valIdator.format( "Veuillez fournir une valeur qui contient entre {0} et {1} caractères." ),
	range: $.valIdator.format( "Veuillez fournir une valeur entre {0} et {1}." ),
	max: $.valIdator.format( "Veuillez fournir une valeur inférieure ou égale à {0}." ),
	min: $.valIdator.format( "Veuillez fournir une valeur supérieure ou égale à {0}." ),
	step: $.valIdator.format( "Veuillez fournir une valeur multiple de {0}." ),
	maxWords: $.valIdator.format( "Veuillez fournir au plus {0} mots." ),
	minWords: $.valIdator.format( "Veuillez fournir au moins {0} mots." ),
	rangeWords: $.valIdator.format( "Veuillez fournir entre {0} et {1} mots." ),
	letterswithbasicpunc: "Veuillez fournir seulement des lettres et des signes de ponctuation.",
	alphanumeric: "Veuillez fournir seulement des lettres, nombres, espaces et soulignages.",
	lettersonly: "Veuillez fournir seulement des lettres.",
	nowhitespace: "Veuillez ne pas inscrire d'espaces blancs.",
	ziprange: "Veuillez fournir un code postal entre 902xx-xxxx et 905-xx-xxxx.",
	integer: "Veuillez fournir un nombre non décimal qui est positif ou négatif.",
	vinUS: "Veuillez fournir un numéro d'Identification du véhicule (VIN).",
	dateITA: "Veuillez fournir une date valIde.",
	time: "Veuillez fournir une heure valIde entre 00:00 et 23:59.",
	phoneUS: "Veuillez fournir un numéro de téléphone valIde.",
	phoneUK: "Veuillez fournir un numéro de téléphone valIde.",
	mobileUK: "Veuillez fournir un numéro de téléphone mobile valIde.",
	strippedminlength: $.valIdator.format( "Veuillez fournir au moins {0} caractères." ),
	email2: "Veuillez fournir une adresse électronique valIde.",
	url2: "Veuillez fournir une adresse URL valIde.",
	creditcardtypes: "Veuillez fournir un numéro de carte de crédit valIde.",
	ipv4: "Veuillez fournir une adresse IP v4 valIde.",
	ipv6: "Veuillez fournir une adresse IP v6 valIde.",
	require_from_group: $.valIdator.format( "Veuillez fournir au moins {0} de ces champs." ),
	nifES: "Veuillez fournir un numéro NIF valIde.",
	nieES: "Veuillez fournir un numéro NIE valIde.",
	cifES: "Veuillez fournir un numéro CIF valIde.",
	postalCodeCA: "Veuillez fournir un code postal valIde.",
	pattern: "Format non valIde."
} );
return $;
}));