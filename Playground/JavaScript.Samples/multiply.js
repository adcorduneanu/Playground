function multiply(a, b) {
    return a * b;
}

function currying(fn) {
    return function (a) {
        return function (b) {
            return fn(a, b);
        }
    }
}

var curriedMultiply = currying(multiply);

curriedMultiply(4)(3);