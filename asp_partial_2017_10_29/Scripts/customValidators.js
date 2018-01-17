/// <reference path="jquery.validate.js" />
/// <reference path="jquery.validate.unobtrusive.js" />

$.validator.unobtrusive.adapters.addSingleVal("maxwordssingle", "wordcount")
$.validator.addMethod("maxwordssingle", function (value, element, maxwords) {

    if (value.split(' ').length > maxwords) {
        return false;
    }

    return true;
})

//add doesnt  work causing exceptions
$.validator.unobtrusive.adapters.addSingleVal("maxwordscustom", "words")
$.validator.addMethod("maxwordscustom", function (value, element, maxwordscustom) {

    console.log(maxwordscustom);

    var len = value.split(' ').length;

    var min = maxwordscustom.split(',')[0];
    var max = maxwordscustom.split(',')[1];
 
    console.log(min);
    console.log(max);

    if (len > min || len < max) {
        return false;
    }

    return true;
})
