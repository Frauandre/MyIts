
/*  returns a grade for the score, either "A", "B", "C", "D", or "F" */
/*
A	93–100
B	85–92
C	77–84
D	70–76
F	0–69
*/ 

function assignGrade(grade){
    if((grade > 100) ||  (grade < 0)){
        console.log("Error!"); 
    }else if((grade >= 93) &&  (grade <= 100)){
        console.log("A"); 
    }else if ((grade >= 85) &&  (grade <= 92)){
        console.log("B"); 
    }else if ((grade >= 77) &&  (grade <= 84)){
        console.log("C");
    }else if ((grade >= 70) &&  (grade <= 76)){
        console.log("D");
    }else if ((grade >= 0) &&  (grade <= 69)){
        console.log("F");
    }else{
        console.log("Error!"); 
    }
    
}


/*assigning values*/
let scoreA = 94;
let scoreB = 85;
let scoreC = 79;
let scoreD = 75;
let scoreF = 50;
let scoreError = -5;


/*print values on console log and test code*/
console.log("Number score to grade: "); 
assignGrade(scoreA);
assignGrade(scoreB);
assignGrade(scoreC);
assignGrade(scoreD);
assignGrade(scoreF);
assignGrade(scoreError);
assignGrade();










