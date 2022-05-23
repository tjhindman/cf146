var detailedInfo = document.getElementsByTagName("h1")[0];

console.log(detailedInfo.innerText);

// "var" basic variable storage name for data
// "const" for specific variables that are not expected to change in code
// "let" allows you to change value of variable within code
// * STRING data type
let greetingMessage = "what's up";
const name = "TJ";

// * STRING CONCATENATION
greetingMessage = greetingMessage + " " + name;

console.log(greetingMessage);

// * NULL data type
const nullVar = null;

// * NUMBER data type
const zeroVar = 0;

// * ARRAY data type
const names = ["TJ", 1, "Mary", "Rob", undefined, [1, 2, 3], nullVar, "Marco"];

console.log(`"names" array: ${names}`);
// should be "Rob" (index start a 0)
console.log("names[3]", names[3]);

// * OBJECT data type
const person = {
  // key : value
  name: "TJ",
  age: 300,
  hobbies: ["coding", "gaming", "listening to music"],
};

person.age = 50;

console.log(`"person" object: ${person}`);
console.log('person["age"]: ', person["age"]);
console.log("person.age: ", person.age);

// ! JS with HTML function ex:
const submissions = [
  { name: "marco", status: "happy" },
  { name: "tj", status: "tired" },
  { name: "danny", status: "phantom" },
];

function handleSubmit() {
  // * "Event" is JS prepackaged object giving us access to different properties when an HTML event occurs.
  Event.preventDefault;

  const nameInput = document.getElementById("name");
  const statusInput = document.getElementById("status");

  const status = {
    name: "",
    status: "",
  };

  // ".value" returns value of HTML input elements
  status.name = nameInput.value;
  status.status = statusInput.value;

  submissions.push(status);

  console.log(submissions);

  // only resetting "value" of inputs AFTER current values have been saved in memory.
  nameInput.value = "";
  statusInput.value = "";
}

function logSubmissions() {
  // * Simple FOR loop
  for (let i = 0; i < submissions.length; i++) {
    console.log(submissions[i]);
  }
}

function greetNames() {
  // * MAP array method:
  // * https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/map
  const greetings = submissions.map(
    // * BACK TICKS + $ + CURLY BRACES = TEMPLATE STRING/TEMPLATE LITERAL: `${}`
    (submission) => `What's up ${submission.name}`
  );

  console.log(greetings);
}

// * ARROW FUNCTION!!! (anonymous arrow functions seen on line 88 and 100)
const showSubmissionInfo = () => {
  const infoUnorderedList = document.createElement("ul");

  // * FOREACH array method:
  // * https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/foreach
  submissions.forEach((submission) => {
    const infoListItem = document.createElement("li");

    infoListItem.innerText = `This is ${submission.name}, they are ${submission.status}.`;

    infoUnorderedList.appendChild(infoListItem);
  });

  // * "document.body" used to represent ENTIRE HTML body
  document.body.appendChild(infoUnorderedList);
};
