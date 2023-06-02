console.log("Let's roll some dice, baby!");
console.log("---------------------------");
/*
 * Returns a random integer between min (inclusive) and max (inclusive).
 * The value is no lower than min (or the next integer greater than min
 * if min isn't an integer) and no greater than max (or the next integer
 * lower than max if max isn't an integer).
 * Using Math.round() will give you a non-uniform distribution!
 */
//functions to roll the die
function dieRoll(min, max) {
    min = Math.ceil(1);
    max = Math.floor(6);
    return Math.floor(Math.random() * 6) + 1;
}

//function to compare rolls and display totals 
const Roll = () => {
    {
        const roll1 = dieRoll()
        const roll2 = dieRoll()
        let message = `${roll1} + ${roll2} =  ${roll1 + roll2}`
        if (roll1 === roll2) {
            return message += " DOUBLES!"
        }
        else {
            return message
        }
    }
}


// console.log(Roll())

//for loop that is running the function 10 times
for (let i = 0; i <= 10; i++) {
    console.log(Roll())
}

