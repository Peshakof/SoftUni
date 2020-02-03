function solve(str, text) {
    let counter = 0;
    let index = text.indexOf(str);

    while (index !== -1) {
        counter++;
        index++;
        index = text.indexOf(str, index);
    }

    return  counter;
}

console.log(solve('the', 'the quick brown fox jumps over the lay dog.'));