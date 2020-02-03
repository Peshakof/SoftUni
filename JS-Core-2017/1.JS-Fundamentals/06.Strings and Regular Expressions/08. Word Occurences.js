function wordInSentence(text, searchedWord) {
    let regex = new RegExp(`\\b${searchedWord}\\b`, 'gi');

    if (text.match(regex) !== null) {
        let match = text.match(regex).length;
        console.log(match);
    } else {
        console.log(0);
    }
}

wordInSentence(
    'The waterfall was so high, that the child couldn’t see its peak.',
    'the'
);