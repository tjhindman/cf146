// * BOOLEAN data type
const isInstructor = false;

// * "FALSY" values (in JS)
/* 
    false
    0
    EMPTY STRINGS: "", '', ``
    null
    undefined
    NaN (not a number)
*/

// * IF/ELSE statement
// "!" bang (Mike Breen) symbol makes value OPPOSITE for boolean variables (if true, will be false. if false will be true)
if (!isInstructor) {
  // what I want to happen "if" true
  console.log("You da boss!");
} else {
  // what I want to happen if false (else)
  console.log("Boss ya life up!");
}

/* 
    write an "if/else" statement checking if "name.length > 13"
    if it is longer than 13 characters, console.log "You're the goat <name>"
    if it is NOT longer than 13 characters, console.log "Hit the gym <name>"
*/
const daGoat = "MichaelJordan";

const name = "JimmyButler";

if (name.length > daGoat.length) {
  console.log(`You're the goat ${name}`);
  console.log("Keep getting buckets");
} else {
  console.log(`Hit the gym ${name}`);
  console.log("I know some coaches for you");
}

// * TERNARY statement
// ! will not work if statement is not included for both true and false cases (need a ":" colon)
// ! you CANNOT execute multiple lines of code within each ternary case
const daTernaryGoat = "KobeBeanBryant";

name.length > daTernaryGoat.length
  ? console.log(`You're the goat ${name} from a ternary!`)
  : console.log(`Hit the gym ${name} from a ternary!`);

// * ELSE IF statement
/* 
    if age is at least 18, console.log "You can vote now!"
    if age is at least 21, console.log "You can drink now! Turn up!!"
    if age is at least 25, console.log "You can rent a car!"
    if 17 or younger, console.log "Sorry you can't do anything yet. Grow up first!"
*/
const age = 300;

if (age >= 25) {
  console.log(`You're ${age} or older! You can rent a car!`);
} else if (age >= 21) {
  console.log(`You're ${age} or older! You can drink now! Turn up!!`);
} else if (age >= 18) {
  console.log(`You're ${age} or older! You can vote now!`);
} else {
  console.log(`Sorry, you're only ${age}. Grow up first!`);
}

// * SWITCH CASES
const animeCharacter = "Krillin";

switch (animeCharacter) {
  case "Goku":
    console.log("I am a super saiyan. YAAAHHHAHAHAHHHAHHAHAHAAAA!!!!!!");
    break;
  case "Frieza":
    console.log("I hate all saiyans and I'm the best to ever fight");
    break;
  case "Krillin":
    console.log("I will fight for the Earth!");
    break;
  case "Vegeta":
    console.log("You all are useless compared to me.");
    break;
  default:
    console.log("I don't know this guy");
}

const movieRating = "G";

switch (movieRating) {
  case "G":
    console.log("Kids movie.");
  case "PG":
    console.log("Parental guidance needed.");
    break;
  case "PG13":
    console.log("Teenagers can see");
    break;
  case "R":
    console.log("Be careful");
    break;
  default:
    console.log("Don't know what to tell you");
}

/*
    Write a dessert menu
    - if "dessert" is "pie", console.log "Pie pie! Oh my!"
    - if "dessert" is "cake", console.log "This cake will be ate!"
    - if "dessert" is "ice cream", console.log "Ice cream you are the dessert of my dream!"
    - otherwise, console.log "Get out of here. We don't serve that stuff here!"
*/
const dessert = "fart pudding";

switch (dessert) {
  case "pie":
    console.log("Pie pie! Oh my!");
    break;
  case "cake":
    console.log("This cake will be ate!");
    break;
  case "ice cream":
    console.log("Ice cream you're the dessert of my dream!");
    break;
  default:
    console.log("Get out of here. We don't serve that stuff here!!");
}

// ! OPERATORS in JS
/* 
    ASSIGNMENT OPERATOR:
        =
    COMPARISON OPERATORS:
        >
        <
        >=
        <=

        ==
        ===

        !=
*/

// "Equal To" does type conversion to compare values to each other
console.log(`Equal To comparison operator: ${"3" == 3}`);
// expected: true

// "Strict Equal To" does not convert value types
console.log(`STRICT Equal To comparison operator: ${"3" === 3}`);
// expected: false

//  "!" = "NOT/OPPOSITE OF"
console.log(`Not Equal To: ${"3" != 3}`);
// expected: false

console.log(`STRICT Not Equal To: ${"3" !== 3}`);
// expected: true

// AND &&
// * always FALSE unless both comparisons are TRUE
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Logical_AND
const a = 2;
const b = 5;
// FALSY value variable (see line 179)
const youSuck = "";

console.log(`b > a && a > b: ${b > a && a > b}`);
// expected: false

// OR ||
// * always TRUE unless both comparisons are FALSE
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Logical_OR

console.log(`b > a || a > b: ${b > a || a > b}`);
// expected: true

console.log(`youSuck || !youSuck: ${youSuck || !youSuck}`);
