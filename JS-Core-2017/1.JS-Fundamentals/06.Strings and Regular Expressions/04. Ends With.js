function endsWith(text, subString) {
    if (text.endsWith(subString)) {
        console.log('true');
    } else {
        console.log('false');
    }
}

endsWith(
    'This sentence ends with fun?',
    'fun?'
);