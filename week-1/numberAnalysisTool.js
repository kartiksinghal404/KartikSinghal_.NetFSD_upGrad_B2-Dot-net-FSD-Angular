function analyzeNumber() {
    let num = parseInt(document.getElementById("numberInput").value);
    let result = document.getElementById("result");
    let list = document.getElementById("list");

    if (isNaN(num)) {
        result.innerHTML = "Please enter a valid number!";
        list.innerHTML = "";
        return;
    }

    // Ternary operator → Positive or Negative
    let sign = (num >= 0) ? "Positive Number" : "Negative Number";

    // If-else → Even or Odd
    let parity;
    if (num % 2 === 0) {
        parity = "Even Number";
    } else {
        parity = "Odd Number";
    }

    // Display result
    result.innerHTML = `
        Sign: ${sign} <br>
        Type: ${parity}
    `;

    // Loop → Print numbers from 1 to given number
    list.innerHTML = "<b>Numbers from 1 to " + num + ":</b><br>";
    for (let i = 1; i <= num; i++) {
        list.innerHTML += i + " ";
    }
}