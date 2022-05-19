
/*  4.The Pluralizer
● Write a function named pluralize that:
○ takes 2 arguments, a noun and a number.
○ returns the number and pluralized form, like "5 cats" or "1 dog".
● Call that function for a few different scores and log the result to make sure it
works.
*/ 

function pluralize (noun,number){
    if (number > 1)
        console.log(number + " " +noun + "s"); 
    else
    console.log(number + " " + noun );
}



/*assigning values*/
let dog = "dog";
let oneAnimal = 1;
let fiveAnimal = 5;
let cat = "cat";

/*Show results*/
console.log("unique: ");
pluralize(dog,oneAnimal);
pluralize(cat,oneAnimal);
console.log(" ");
console.log("pluralize: ");
pluralize(dog,fiveAnimal);
pluralize(cat,fiveAnimal);













