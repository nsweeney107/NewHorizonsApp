$("a").click(function (event) {
    event.preventDefault();
    CallJSCSharp.redirctURL($(this).attr('href'));
});