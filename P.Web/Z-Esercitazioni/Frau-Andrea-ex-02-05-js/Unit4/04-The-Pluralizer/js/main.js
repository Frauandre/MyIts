function pluralize (noun,number){
    if (number > 1)
        console.log(number + " " +noun + "s"); 
    else
    console.log(number + " " + noun );
}

let dog = "dog";
let oneAnimal = 1;
let fiveAnimal = 5;
let cat = "cat";

console.log("unique: ");
pluralize(dog,oneAnimal);
pluralize(cat,oneAnimal);
console.log(" ");
console.log("pluralize: ");
pluralize(dog,fiveAnimal);
pluralize(cat,fiveAnimal);













