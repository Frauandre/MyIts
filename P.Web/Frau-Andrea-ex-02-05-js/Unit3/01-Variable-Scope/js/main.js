function addNumbers(num1, num2){
    let localResult = num1 + num2;
    console.log("The local result is: " + localResult);
}
addNumbers(2, 3);
console.log(localResult);

let globalResult;
function addNumbers(num1, num2) {
globalResult = num1 + num2;
console.log("The global result is: " + globalResult);
}
addNumbers(2, 3);
console.log(globalResult);

