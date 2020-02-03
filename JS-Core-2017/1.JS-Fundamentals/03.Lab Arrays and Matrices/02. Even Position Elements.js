function solve(arr) {
    // filters even indexes of the array where 'num' is the current element and 'i' is its index
    let result = arr.filter((num, i) => i % 2 === 0);
    console.log(result.join(' '));   //
}

solve([1,34,3,45,7,68]);