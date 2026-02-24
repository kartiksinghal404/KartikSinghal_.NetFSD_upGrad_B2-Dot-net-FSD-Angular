// storage.js

let tasks = [];

// -----------------------------
// 1️⃣ CALLBACK VERSION
// -----------------------------

export const saveTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task);
        callback(`Task "${task}" added successfully (Callback)`);
    }, 1000);
};

export const deleteTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks = tasks.filter(t => t !== task);
        callback(`Task "${task}" deleted successfully (Callback)`);
    }, 1000);
};

export const listTasksCallback = (callback) => {
    setTimeout(() => {
        callback(tasks);
    }, 1000);
};

// -----------------------------
// 2️⃣ PROMISE VERSION
// -----------------------------

export const saveTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(`Task "${task}" added successfully (Promise)`);
        }, 1000);
    });
};

export const deleteTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks = tasks.filter(t => t !== task);
            resolve(`Task "${task}" deleted successfully (Promise)`);
        }, 1000);
    });
};

export const listTasksPromise = () => {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(tasks);
        }, 1000);
    });
};