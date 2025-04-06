
const student = {
    name: "John Doe",
    age: 30,
    isStudent: false,
    courses: ["Math", "Science", "History"],
};

// Converting JavaScript object to JSON string
const jsonString = JSON.stringify(student);
console.log(jsonString); // Output: JSON string

// -------------------------------------------------------

const jsonData = `{
    "name": "John Doe",
    "age": 30,
    "isStudent": false,
}`;

console.log(jsonData); // Output: JSON string
// Parsing JSON string to JavaScript object
const jsonObject = JSON.parse(jsonData);
console.log(jsonObject.name); // Output: John Doe
console.log(jsonObject.age); // Output: 30
console.log(jsonObject.isStudent); // Output: false
console.log(jsonObject); // Output: { name: 'John Doe', age: 30, isStudent: false }


// -------------------------------------------------------------------