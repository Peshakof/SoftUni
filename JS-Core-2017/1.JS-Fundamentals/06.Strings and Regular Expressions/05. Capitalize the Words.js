function test(text) {
    let resultArr = text.split(' ');
    for (let i = 0; i < resultArr.length; i++) {
        resultArr[i] = resultArr[i].charAt(0).toUpperCase()
            + resultArr[i].substring(1).toLocaleLowerCase();
    }

    return resultArr.join(' ');
}

console.log(test('Capitalize these words'));