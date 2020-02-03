function printTriangle(n) {
    function prinStars(count) {
        console.log('*'.repeat(count));
    }
    for (let index = 1; index <= n; index++) 
    prinStars(index);
    for (let index = n-1; index > 0; index--)
    prinStars(index);
}

printTriangle(3);