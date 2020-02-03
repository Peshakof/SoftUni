function validate(email) {
    let pattern = /^[a-zA-Z0-9]+@[a-z]+(\.[a-z]+)+$/g;

    let result = pattern.test(email); // Returns true if the email matches the pattern

    if (result) {
        console.log("Valid");
    } else {
        console.log("Invalid");
    }
}

validate(['bai.ivan@mail.sf.net']);