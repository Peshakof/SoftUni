function solve(arr) {
    let result = arr.sort((a,b) => a - b)
        .slice(0, 2)
        .join(' ');

    return result;
}

console.log(solve([30,15,50,5]));