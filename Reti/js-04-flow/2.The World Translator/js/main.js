
/*  */

function helloWorld(language){
    switch (language) {
        case 'es':
            console.log("Hola, mundo");break;
        case 'de':
            console.log("Hallo, Welt"); break;
        case 'it':
            console.log("Ciao, Mondo");break;
        default:
            console.log("Hello, World");
      }
}

function helloWorldNoIf(language){
    const messages = {
        es:"Hola, mundo",
        de:"Hallo, Welt",
        it:"Ciao, Mondo",
    }
    if(messages[language] != undefined){
        console.log(messages[language]);
    }else{
        console.log("Hello, World");
    }
}


function helloWorldIf(language){
    if(language == "es"){
        console.log("Hola, mundo"); 
    }else if(language == "de"){
        console.log("Hallo, Welt"); 
    }else if (language == "en"){
        console.log("Hello, World"); 
    }else if (language == "it"){
        console.log("Ciao, Mondo");
    }else{
        console.log("Hello, World"); 
    }
    
}


/*assigning values*/
let es = "es";
let de = "de";
let it = "it";
let en = "en";

/*print values on console log*/
console.log("----------------------------------"); 
helloWorld(es);
helloWorld(de);
helloWorld(it);
helloWorld();
console.log("----------------------------------"); 
helloWorldIf(es);
helloWorldIf(de);
helloWorldIf(it);
helloWorldIf(en);
helloWorldIf();
console.log("----------------------------------"); 
helloWorldNoIf(es);
helloWorldNoIf(de);
helloWorldNoIf(it);
helloWorldNoIf();
console.log("----------------------------------"); 







