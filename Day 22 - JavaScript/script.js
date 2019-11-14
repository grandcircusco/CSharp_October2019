console.log("Hey, snowy world!");



function displayEquals(){

let doubleEquals = (25 == "25");
let tripleEquals = (25 === "25");

alert(`double equals ${doubleEquals}, triple equals ${tripleEquals}`);
//triple equals is literal, looks at the datatypes
//double equals erases the datatypes
}

function addNumbers(){
    let number1 = prompt("Give me a number!");
    let number2 = prompt("Give me another number!");
    number1 = parseInt(number1);
    number2 = parseInt(number2);
    alert(number1 + number2);
}

document.write("JavaScript all the things!");

//document.body.innerHTML = '<p>I changed the whoooole page!</p>';

let happyId = document.getElementById("happy");
happyId.innerText = "I changed juuuust this paragraph!";

let header = document.createElement("h1");
header.innerText = "This is a header!";
document.body.appendChild(header);