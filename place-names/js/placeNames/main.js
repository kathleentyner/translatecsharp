
const names = [
   "Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
];
//print All Place Names
console.log("All Place Names");

//list the place names
for (const name of names) {
  console.log(name);
}

// Filter the list to create a new list that only has 
//  place names that start with the word "The".
console.log("'the' place names")



let theNames = names.filter(name => name.includes('The'))

console.log(theNames)