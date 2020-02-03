function solve(matrix) {
    let biggest = Number.NEGATIVE_INFINITY;
    matrix.forEach(row =>
        row.forEach(e => {
            if (e > biggest) {
                biggest = e;
            }
        })
    );
    return biggest;
}

console.log(solve([
    [3, 5, 17, 12, 91, 5],
    [-1, 7, 4, 33, 6, 22],
    [1, 8, 99, 3, 10, 43]
]));