function printReverse(s){
    return s.split("").reverse().join("");
}

function  isPalindrome(string){
    if(string == printReverse(string)){
        console.log(string ,":  Is palindrome ");
    }
    else
        console.log(string,":  is not palindrome");
}

let palindrome1 = "madam";
let notpalindorme = "Happy";


isPalindrome(palindrome1);
isPalindrome(notpalindorme);



