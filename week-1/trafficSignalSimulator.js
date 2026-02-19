function checkSignal() {
    let signal = document.getElementById("colorInput").value.toLowerCase();
    let message;

    switch(signal) {
        case "red":
            message = "Stop";
            break;

        case "yellow":
            message = "Get Ready";
            break;

        case "green":
            message = "Go";
            break;

        default:
            message = "Invalid signal color";
    }

    console.log(message);
    document.getElementById("result").innerText = message;
}