function rotate(arr) {
    let rotations = +arr.pop();
    rotations %= arr.length;

    for (let i = 0; i < rotations; i++) {
        let lastEl = arr.pop();
        arr.unshift(lastEl);
    }
    console.log(arr.join(' '));
}

rotate([
    'Banana',
    'Orange',
    'Coconut',
    'Apple',
    '15'
    ]);