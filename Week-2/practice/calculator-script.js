const display = document.getElementById("display");
const buttons = document.querySelector(".buttons");

// Event Delegation (Advanced Concept)
buttons.addEventListener("click", (e) => {
    if(!e.target.matches("button")) return;

    const value = e.target.textContent; 

    if(e.target.classList.contains("clear")){
        display.value= "";
    }
    else if(e.target.classList.contains("delete")){
        display.value = display.value.slice(0,-1);
    }
    else if(e.target.classList.contains("equal")) {
        calculateResult();
    }

    else{
        display.value += value;
    }
});

// Keyboard Support (Advanced Feature)

document.addEventListener("keydown", (e)=>{
    if((e.key >= "0" && e.key <= "9") || "+-*/.%".includes(e.key)){
        display.value += e.key;
    }
    else if(e.key ==="Enter"){
        calculateResult();
    }
    else if(e.key === "Backspace"){
        display.value = display.value.slice(0,-1);
    }
});

// Safe Calculation with Error Handling

function calculateResult(){
    try{
        display.value = eval(display.value);
    }catch{
        display.value = "Error";
    }
}