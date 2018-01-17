


$.validator.unobstrusive.adapters.addSingleValue("maxwordssingle", "wordcount")
$.validator.addMethod("maxwordssingle", function (value, element, maxwords) {
    if (value.split(' ').length > maxwords) {
        return false;
    }
})


