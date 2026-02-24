// taskManager.js

import {
    saveTaskCallback,
    deleteTaskCallback,
    listTasksCallback,
    saveTaskPromise,
    deleteTaskPromise,
    listTasksPromise
} from './storage.js';


// =============================
// 1️⃣ CALLBACK VERSION
// =============================

export const runCallbackVersion = () => {

    saveTaskCallback("Learn JavaScript", (msg) => {
        console.log(msg);

        listTasksCallback((tasks) => {
            console.log(`Tasks (Callback): ${tasks.join(", ")}`);

            deleteTaskCallback("Learn JavaScript", (msg) => {
                console.log(msg);

                listTasksCallback((tasks) => {
                    console.log(`Final Tasks (Callback): ${tasks.join(", ")}`);
                });
            });
        });
    });
};


// =============================
// 2️⃣ PROMISE VERSION
// =============================

export const runPromiseVersion = () => {

    saveTaskPromise("Learn React")
        .then(msg => {
            console.log(msg);
            return listTasksPromise();
        })
        .then(tasks => {
            console.log(`Tasks (Promise): ${tasks.join(", ")}`);
            return deleteTaskPromise("Learn React");
        })
        .then(msg => {
            console.log(msg);
            return listTasksPromise();
        })
        .then(tasks => {
            console.log(`Final Tasks (Promise): ${tasks.join(", ")}`);
        });
};


// =============================
// 3️⃣ ASYNC/AWAIT VERSION
// =============================

export const runAsyncAwaitVersion = async () => {

    try {
        const addMsg = await saveTaskPromise("Learn NodeJS");
        console.log(addMsg);

        const tasks1 = await listTasksPromise();
        console.log(`Tasks (Async/Await): ${tasks1.join(", ")}`);

        const delMsg = await deleteTaskPromise("Learn NodeJS");
        console.log(delMsg);

        const tasks2 = await listTasksPromise();
        console.log(`Final Tasks (Async/Await): ${tasks2.join(", ")}`);

    } catch (error) {
        console.error("Error:", error);
    }
};