function calculate(){

    let amount = document.getElementById("amount").value;
    amount = Number(amount);

    let discount = 0;
    let finalAmount;

    if(amount >= 5000){
        discount = amount * 0.20;
    }
    else if(amount >= 3000){
        discount = amount * 0.10;
    }
    else{
        discount = 0;
    }

    finalAmount = amount - discount;

    document.getElementById("discount").innerHTML =
        "Discount: ₹ " + discount;

    document.getElementById("final").innerHTML =
        "Final Amount: ₹ " + finalAmount;
}