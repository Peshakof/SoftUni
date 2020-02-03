function nthElement(input) {
    let step = +input.pop();

    for (let i = 0; i < input.length; i += step) {
        let currentEl = input[i];
        console.log(currentEl);
    }
}

nthElement([
    '5',
    '20',
    '31',
    '4',
    '20',
    '2']
);