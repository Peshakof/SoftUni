function solve(arr) {
    let products = arr.filter((e, i) => i % 2 === 0);
    let prices = arr
        .filter((e, i) => i % 2 !== 0)
        .map(Number);
    let total = prices.reduce((a,b) => a + b, 0);
    console.log(`You purchased ${products.join(', ')} for a total sum of ${total}`);
}

solve(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);