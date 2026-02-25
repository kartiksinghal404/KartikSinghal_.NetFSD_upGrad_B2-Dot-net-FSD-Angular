// Select elements
        const button = document.getElementById("feedbackBtn");
        const messageDiv = document.getElementById("message");

        // Add event listener
        button.addEventListener("click", () => {
            messageDiv.textContent = "✅ Thank you! Your feedback has been submitted successfully.";
        });