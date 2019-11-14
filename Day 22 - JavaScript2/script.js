document.querySelector("#diceParent").addEventListener("click", rollDie);

function rollDie(){
    let resultDisplay = document.getElementById("rollResult");
    resultDisplay.textContent = getRandom();
}

function getRandom(){
    let numOfSides = document.getElementById("numOfSides");
    let sides = numOfSides.value;
    return Math.floor(Math.random() * sides) + 1;
}