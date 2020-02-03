function findVariables(input) {
    let regex = /\b_[a-zA-Z0-9]+\b/g;
    let matches = input.match(regex);
    let validMatches = [];
    for (let i = 0; i < matches.length; i++) {
        let currentMatch = matches[i].substring(1);
        validMatches.push(currentMatch)
    }
    console.log(validMatches.join(','));
}

findVariables('__invalidVariable _evenMoreInvalidVariable_ _validVariable');