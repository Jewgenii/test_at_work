

$.validator.unobtrusive.adapters.addSingleVal("maxwordssingle", "wordcount")
$.validator.addMethod("maxwordssingle", function (value, element, maxwords) {

    if (value.split(' ').length > maxwords) {
        return false;
    }

    return true;
})


$.validator.unobtrusive.adapters.add("maxwordscustom", "words")
$.validator.addMethod("maxwordscustom", function (value, element, words) {

    console.log(words);

    var len = +value.split(' ').length;

    var min = +words.split(' ')[0];
    var max = +words.split(' ')[1];
 
    console.log(min);
    console.log(max);

    if (len > min || len < max) {
        return false;
    }

    return true;
})
