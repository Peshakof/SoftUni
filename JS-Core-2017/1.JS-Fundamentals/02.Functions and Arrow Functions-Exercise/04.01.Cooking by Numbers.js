function solve(input) {
    let num = +input[0];

    let chop = () => num / 2;
    let dice = () => Math.sqrt(num);
    let spice = () => num + 1;
    let bake = () => num * 3;
    let fillet = () => num * 0.8;

    for (let i = 1; i < input.length; i++) {
        let operation = input[i];
        switch (operation) {
            case 'chop': num = chop();
                break;
            case 'dice': num = dice();
                break;
            case 'spice': num = spice();
                break;
            case 'bake': num = bake();
                break;
            case 'fillet': num = fillet();
                break;
        }
        console.log(num);
    }
}

solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);