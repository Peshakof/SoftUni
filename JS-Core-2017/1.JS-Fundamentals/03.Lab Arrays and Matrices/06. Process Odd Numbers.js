function solve(arr) {
    let result = arr.filter((e, i) => i % 2 !== 0)
        .map(e => e * 2)
        .reverse()
        .join(' ');
    console.log(result);
}

solve([3, 0, 10, 4, 7, 3]);