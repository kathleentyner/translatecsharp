// Put your code here

console.log("My Enemies List!")
console.log("----------------")


//create an array of enemies
const enemies = 
[
      {
        FirstName:"Joshua",
        LastName: "Flowers",
        IsReallyHated: true,
        Offenses: 
           [ "Being a jerk to me in elementary school",
            "Not being nice to me in elementary school"]
        },
    
   {
        FirstName: "Darth",
        LastName: "Vader",
        IsReallyHated: false,
        Offenses: [
            "Cut off Luke's hand",
            "Murdered all those kids",
            "Unkind management practices"]
        
         },
   {
        FirstName: "Betty",
        LastName: "Rudelady",
        IsReallyHated: true,
        Offenses: [
            "Phone calls in the theater",
            "Phone calls on the bus",
            "Phone calls in line at the grocery store",
            "Poor conversationalist"]
        },
      
     {
        FirstName: "Leon",
        LastName: "Peck",
        IsReallyHated: false,
        Offenses: "Keeps giving me a hotplate"
        },
       
    ]

// get the ememies
const getEnemies  = () => {
 enemies.map(enemie => ({...enemie}))}
const ememies = getEnemies() 

const singleEnemie = () => {
    for (const enemie of enemies) {
        if (enemie.IsReallyHated === true)
        {
        console.log(`${enemie.FirstName} ${enemie.LastName} is really hated.`)}
    
    else
    {(console.log(`${enemie.FirstName} ${enemie.LastName}`))}}}
    

    console.log(singleEnemie())