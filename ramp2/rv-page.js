// https://css-tricks.com/snippets/javascript/get-url-variables/
function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split("&");
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split("=");
        if (pair[0] == variable) { return pair[1]; }
    }
    return (false);
}

function bookmark() {
    return new Promise(function (resolve) {
        var thing = getQueryVariable("rv");
        console.log(thing);
        resolve(thing);
    });
}

function queryStringToJSON(q) {
    var pairs = q.search.slice(1).split('&');
    var result = {};
    pairs.forEach(function (pair) {
        pair = pair.split('=');
        result[pair[0]] = decodeURIComponent(pair[1] || '');
    });
    return JSON.parse(JSON.stringify(result));
}
// grab & process the url
var queryStr = queryStringToJSON(document.location);
var keys = queryStr.keys;
// console.log('keys', keys);
if (keys) {
    // turn keys into an array, pass them to the map
    var keysArr = keys.split(',');
    RV.getMap('fgpmap').restoreSession(keysArr);
} else {
    var bookmark = queryStr.rv;
    // console.log("bookmark", bookmark);
    RV.getMap('fgpmap').initialBookmark(bookmark);
}