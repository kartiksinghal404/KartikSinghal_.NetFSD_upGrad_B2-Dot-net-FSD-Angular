// ================= MODULE STRUCTURE =================

// Select Elements
const taskInput = document.getElementById("taskInput");
const addBtn = document.getElementById("addBtn");
const taskList = document.getElementById("taskList");


// -------- Add Task Function --------
const addTask = () => {
    const taskText = taskInput.value.trim();
    if (!taskText) return;

    const li = document.createElement("li");
    li.innerHTML = `
        <span class="task-text">${taskText}</span>
        <button class="delete-btn">Delete</button>
    `;

    taskList.appendChild(li);
    taskInput.value = "";
};


// -------- Delete Task Function --------
const deleteTask = (element) => {
    element.parentElement.remove();
};


// -------- Toggle Complete Function --------
const toggleComplete = (element) => {
    element.classList.toggle("completed");
};


// -------- Event Listeners --------
addBtn.addEventListener("click", addTask);

taskInput.addEventListener("keypress", (e) => {
    if (e.key === "Enter") addTask();
});


// ===== EVENT DELEGATION =====
// Single listener for delete & complete
taskList.addEventListener("click", (e) => {

    // Delete Button Click
    if (e.target.classList.contains("delete-btn")) {
        deleteTask(e.target);
    }

    // Mark Complete (Click on text)
    if (e.target.classList.contains("task-text")) {
        toggleComplete(e.target.parentElement);
    }

});