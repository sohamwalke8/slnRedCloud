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
 * Locale: ZH (Chinese, 中文 (Zhōngwén), 汉语, 漢語)
 */
$.extend( $.valIdator.messages, {
	required: "这是必填字段",
	remote: "请修正此字段",
	email: "请输入有效的电子邮件地址",
	url: "请输入有效的网址",
	date: "请输入有效的日期",
	dateISO: "请输入有效的日期 (YYYY-MM-DD)",
	number: "请输入有效的数字",
	digits: "只能输入数字",
	creditcard: "请输入有效的信用卡号码",
	equalTo: "你的输入不相同",
	extension: "请输入有效的后缀",
	maxlength: $.valIdator.format( "最多可以输入 {0} 个字符" ),
	minlength: $.valIdator.format( "最少要输入 {0} 个字符" ),
	rangelength: $.valIdator.format( "请输入长度在 {0} 到 {1} 之间的字符串" ),
	range: $.valIdator.format( "请输入范围在 {0} 到 {1} 之间的数值" ),
	step: $.valIdator.format( "请输入 {0} 的整数倍值" ),
	max: $.valIdator.format( "请输入不大于 {0} 的数值" ),
	min: $.valIdator.format( "请输入不小于 {0} 的数值" )
} );
return $;
}));