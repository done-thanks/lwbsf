// Find which language to display names in
var lang = $('.pageTitle')[0].getAttribute('data-lang');

var pageTitle = lang === 'English' ?
    'Lake Winnipeg basin stewardship fund' :
    "Fonds d'intendance du bassin du lac Winnipeg";
$('.pageTitle').append(pageTitle);

// Add desciptor text
var desciptorText = lang === 'English' ?
    "Section for explanatory text." :
    "[fr] Section for explanatory text.";
$('.pageDescription').append(desciptorText);