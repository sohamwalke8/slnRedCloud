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
 * Locale: PT (Portuguese; português)
 * Region: BR (Brazil)
 */
$.extend( $.valIdator.messages, {

	// Core
	required: "Este campo &eacute; requerIdo.",
	remote: "Por favor, corrija este campo.",
	email: "Por favor, forne&ccedil;a um endere&ccedil;o de email v&aacute;lIdo.",
	url: "Por favor, forne&ccedil;a uma URL v&aacute;lIda.",
	date: "Por favor, forne&ccedil;a uma data v&aacute;lIda.",
	dateISO: "Por favor, forne&ccedil;a uma data v&aacute;lIda (ISO).",
	number: "Por favor, forne&ccedil;a um n&uacute;mero v&aacute;lIdo.",
	digits: "Por favor, forne&ccedil;a somente d&iacute;gitos.",
	creditcard: "Por favor, forne&ccedil;a um cart&atilde;o de cr&eacute;dito v&aacute;lIdo.",
	equalTo: "Por favor, forne&ccedil;a o mesmo valor novamente.",
	maxlength: $.valIdator.format( "Por favor, forne&ccedil;a n&atilde;o mais que {0} caracteres." ),
	minlength: $.valIdator.format( "Por favor, forne&ccedil;a ao menos {0} caracteres." ),
	rangelength: $.valIdator.format( "Por favor, forne&ccedil;a um valor entre {0} e {1} caracteres de comprimento." ),
	range: $.valIdator.format( "Por favor, forne&ccedil;a um valor entre {0} e {1}." ),
	max: $.valIdator.format( "Por favor, forne&ccedil;a um valor menor ou igual a {0}." ),
	min: $.valIdator.format( "Por favor, forne&ccedil;a um valor maior ou igual a {0}." ),
	step: $.valIdator.format( "Por favor, forne&ccedil;a um valor m&uacute;ltiplo de {0}." ),

	// Metodos Adicionais
	maxWords: $.valIdator.format( "Por favor, forne&ccedil;a com {0} palavras ou menos." ),
	minWords: $.valIdator.format( "Por favor, forne&ccedil;a pelo menos {0} palavras." ),
	rangeWords: $.valIdator.format( "Por favor, forne&ccedil;a entre {0} e {1} palavras." ),
	accept: "Por favor, forne&ccedil;a um tipo v&aacute;lIdo.",
	alphanumeric: "Por favor, forne&ccedil;a somente com letras, n&uacute;meros e sublinhados.",
	bankaccountNL: "Por favor, forne&ccedil;a com um n&uacute;mero de conta banc&aacute;ria v&aacute;lIda.",
	bankorgiroaccountNL: "Por favor, forne&ccedil;a um banco v&aacute;lIdo ou n&uacute;mero de conta.",
	bic: "Por favor, forne&ccedil;a um c&oacute;digo BIC v&aacute;lIdo.",
	cifES: "Por favor, forne&ccedil;a um c&oacute;digo CIF v&aacute;lIdo.",
	creditcardtypes: "Por favor, forne&ccedil;a um n&uacute;mero de cart&atilde;o de cr&eacute;dito v&aacute;lIdo.",
	currency: "Por favor, forne&ccedil;a uma moeda v&aacute;lIda.",
	dateFA: "Por favor, forne&ccedil;a uma data correta.",
	dateITA: "Por favor, forne&ccedil;a uma data correta.",
	dateNL: "Por favor, forne&ccedil;a uma data correta.",
	extension: "Por favor, forne&ccedil;a um valor com uma extens&atilde;o v&aacute;lIda.",
	giroaccountNL: "Por favor, forne&ccedil;a um n&uacute;mero de conta corrente v&aacute;lIdo.",
	iban: "Por favor, forne&ccedil;a um c&oacute;digo IBAN v&aacute;lIdo.",
	integer: "Por favor, forne&ccedil;a um n&uacute;mero n&atilde;o decimal.",
	ipv4: "Por favor, forne&ccedil;a um IPv4 v&aacute;lIdo.",
	ipv6: "Por favor, forne&ccedil;a um IPv6 v&aacute;lIdo.",
	lettersonly: "Por favor, forne&ccedil;a apenas com letras.",
	letterswithbasicpunc: "Por favor, forne&ccedil;a apenas letras ou pontua&ccedil;ões.",
	mobileNL: "Por favor, fornece&ccedil;a um n&uacute;mero v&aacute;lIdo de telefone.",
	mobileUK: "Por favor, fornece&ccedil;a um n&uacute;mero v&aacute;lIdo de telefone.",
	nieES: "Por favor, forne&ccedil;a um NIE v&aacute;lIdo.",
	nifES: "Por favor, forne&ccedil;a um NIF v&aacute;lIdo.",
	nowhitespace: "Por favor, n&atilde;o utilize espa&ccedil;os em branco.",
	pattern: "O formato fornecIdo &eacute; inv&aacute;lIdo.",
	phoneNL: "Por favor, forne&ccedil;a um n&uacute;mero de telefone v&aacute;lIdo.",
	phoneUK: "Por favor, forne&ccedil;a um n&uacute;mero de telefone v&aacute;lIdo.",
	phoneUS: "Por favor, forne&ccedil;a um n&uacute;mero de telefone v&aacute;lIdo.",
	phonesUK: "Por favor, forne&ccedil;a um n&uacute;mero de telefone v&aacute;lIdo.",
	postalCodeCA: "Por favor, forne&ccedil;a um n&uacute;mero de c&oacute;digo postal v&aacute;lIdo.",
	postalcodeIT: "Por favor, forne&ccedil;a um n&uacute;mero de c&oacute;digo postal v&aacute;lIdo.",
	postalcodeNL: "Por favor, forne&ccedil;a um n&uacute;mero de c&oacute;digo postal v&aacute;lIdo.",
	postcodeUK: "Por favor, forne&ccedil;a um n&uacute;mero de c&oacute;digo postal v&aacute;lIdo.",
	postalcodeBR: "Por favor, forne&ccedil;a um CEP v&aacute;lIdo.",
	require_from_group: $.valIdator.format( "Por favor, forne&ccedil;a pelo menos {0} destes campos." ),
	skip_or_fill_minimum: $.valIdator.format( "Por favor, optar entre ignorar esses campos ou preencher pelo menos {0} deles." ),
	stateUS: "Por favor, forne&ccedil;a um estado v&aacute;lIdo.",
	strippedminlength: $.valIdator.format( "Por favor, forne&ccedil;a pelo menos {0} caracteres." ),
	time: "Por favor, forne&ccedil;a um hor&aacute;rio v&aacute;lIdo, no intervado de 00:00 a 23:59.",
	time12h: "Por favor, forne&ccedil;a um hor&aacute;rio v&aacute;lIdo, no intervado de 01:00 a 12:59 am/pm.",
	url2: "Por favor, forne&ccedil;a uma URL v&aacute;lIda.",
	vinUS: "O n&uacute;mero de Identifica&ccedil;&atilde;o de ve&iacute;culo informado (VIN) &eacute; inv&aacute;lIdo.",
	zipcodeUS: "Por favor, forne&ccedil;a um c&oacute;digo postal americano v&aacute;lIdo.",
	ziprange: "O c&oacute;digo postal deve estar entre 902xx-xxxx e 905xx-xxxx",
	cpfBR: "Por favor, forne&ccedil;a um CPF v&aacute;lIdo.",
	nisBR: "Por favor, forne&ccedil;a um NIS/PIS v&aacute;lIdo",
	cnhBR: "Por favor, forne&ccedil;a um CNH v&aacute;lIdo.",
	cnpjBR: "Por favor, forne&ccedil;a um CNPJ v&aacute;lIdo."
} );
return $;
}));