function mixUp(string1, string2) {
    return string2.slice(0, 2) + string1.slice(2) + " " + string1.slice(0, 2) + string2.slice(2);
  }

let word1 = "happy";
let word2 = "day";

console.log(mixUp(word1,word2));











