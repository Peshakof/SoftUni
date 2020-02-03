function solve(arr) {
    let k = arr.shift();
    let firstK = arr.slice(0, k).join(' ');
    let lastK = arr.slice(-k).join(' ');  // '-k' returns last index
    console.log(`${firstK}\n${lastK}`);
}

solve([2,7,8,9]);