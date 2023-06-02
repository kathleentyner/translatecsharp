console.log("Do you believe in magic?");
console.log("------------------------");


//defination of a spell object
const createSpell = (name, isEvil, energyReqired) => {
    return {
      name: name,
      isEvil: isEvil,
      energyReqired: energyReqired,
    };
  };
//data for the indivudual spells
 const getSpells= () => {
    const spells = [
        createSpell("Turn enemy into a newt", true, 5.1),
        createSpell("Conjure some gold for a local charity", false, 2.99),
        createSpell("Give a deaf person the ability to heal", false, 12.2),
        createSpell("Make yourself emperor of the universe", true, 100.0),
        createSpell("Convince your relatives your political views are correct", false, 2921.5)
    ]
    return spells //return the array of spells
}

const spellsArray = getSpells() //all the spells

const evilSpells = (spellsArray) => { //make an object of the evil spells 
    return {
        bookName: "Evil Book", //name of book
        Spells: spellsArray.filter((spell) => spell.isEvil === true) //find the evil spells and add them as an array under the evil book object
    }

}

const goodSpells = (spellsArray) => { //object of good spells
    return {
        bookName: "Good Book",
        Spells: spellsArray.filter((spell) => spell.isEvil === false) //false
    }
}
//organize the spellbooks 
const spellBooks = (book) => {
    console.log(book.bookName) //name of the book 
    for (const spell of book.Spells) { 
        console.log(`  ${spell.name}`);//the array of spell names
    }
}

//show the books
spellBooks(goodSpells(spellsArray));
spellBooks(evilSpells(spellsArray))