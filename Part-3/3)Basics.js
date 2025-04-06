// Variables
var age2 = 25; // Used in olden days
let city2 = "New York"; // the value is expected to change.
const country = "USA"; // Constant value that cannot change

// Data Types
var str = "Hello, World!"; // String
var num = 42; // Number
var isTrue = true; // Boolean
var arr = [1, 2, 3]; // Array
var obj = { key: "value" }; // Object

// example of object
var person = {
  name: "John",
  age: 30,
  city: "New York",
};

console.log(person.name); // Accessing object property
console.log(person["age"]); // Accessing object property using bracket notation

// ==, ===, !=, !==
var a = 5;
var b = "5";
console.log(a == b); // true (loose equality)
console.log(a === b); // false (strict equality)
console.log(a != b); // false (loose inequality)
console.log(a !== b); // true (strict inequality)

// 1 == true -> true
// 1 === true -> false
// 1 == "1" -> true
// 1 === "1" -> false
// 1 == null -> false
// 1 == undefined -> false
// null == undefined -> true
// null === undefined -> false


// Logical Operators
var x = true;
var y = false;
console.log(x && y); // AND operator
console.log(x || y); // OR operator
console.log(!x); // NOT operator
// Ternary Operator
var age3 = 18;
var canVote = (age3 >= 18) ? "Yes" : "No";
console.log(canVote); // Output: Yes

// Functions
function greet(name) {
  return "Hello, " + name + "!";
}
console.log(greet("Alice")); // Output: Hello, Alice!

// Arrow Functions
const add = (a, b) => a + b;
console.log(add(5, 10)); // Output: 15

// if else
var number = 10;
if (number > 0) {
  console.log("Positive");
}
else if (number < 0) {
    console.log("Negative");
}

// Switch Case
var day = 3;
switch (day) {
  case 1:
    console.log("Monday");
    break;
  case 2:
    console.log("Tuesday");
    break;
  case 3:
    console.log("Wednesday");
    break;
  default:
    console.log("Invalid day");
}

// Loops------------------------------------------------

// While Loop
var i = 0;
while (i < 5) {
  console.log(i); // Output: 0, 1, 2, 3, 4
  i++;
}
// Do While Loop
var j = 0;
do {
  console.log(j); // Output: 0, 1, 2, 3, 4
  j++;
}while (j < 5);

// For Loop
for (var i = 0; i < 5; i++) {
    console.log(i); // Output: 0, 1, 2, 3, 4
}

// For Each Loop
var arr = [1, 2, 3, 4, 5];
arr.forEach(function(item) {
  console.log(item); // Output: 1, 2, 3, 4, 5
});

// For In Loop
var obj = { a: 1, b: 2, c: 3 };
for (var key in obj) {
  console.log(key + ": " + obj[key]); // Output: a: 1, b: 2, c: 3
}

// For Of Loop
var arr = [1, 2, 3];
for (var value of arr) {
  console.log(value); // Output: 1, 2, 3
}

// Break and Continue
for (var i = 0; i < 5; i++) {
  if (i === 2) {
    continue; // Skip the iteration when i is 2
  }
  console.log(i); // Output: 0, 1, 3, 4
}

// Break
for (var i = 0; i < 5; i++) {
  if (i === 3) {
    break; // Exit the loop when i is 3
  }
  console.log(i); // Output: 0, 1, 2
}

