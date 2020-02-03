function addOrRemove(arr) {
    let resultArr = [];
    let initialNumber = 1;
    for (let el of arr) {
        if (el === 'add') {
            resultArr.push(initialNumber);
        } else if (el === 'remove') {
            resultArr.pop();
        }
        initialNumber++;
    }

    if (resultArr.length === 0) {
        console.log('Empty');
    } else {
        console.log(resultArr.join('\n'));
    }
}

addOrRemove([
    'add',
    'add',
    'add',
    'add']
);