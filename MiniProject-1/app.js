let events = JSON.parse(localStorage.getItem("events")) || [];


/* LOGIN */

function login(e){

e.preventDefault()

let email = document.getElementById("email").value
let password = document.getElementById("password").value

if(email==="admin@upgrad.com" && password==="12345"){

localStorage.setItem("login",true)

window.location="events.html"

}
else{

alert("Invalid Credentials")

}

}


/* CHECK LOGIN */

function checkLogin(){

if(!localStorage.getItem("login")){

alert("Unauthorized Access")

window.location="login.html"

}

displayAdminEvents()

}


/* LOGOUT */

function logout(){

localStorage.removeItem("login")

window.location="login.html"

}


/* ADD EVENT */

document.getElementById("eventForm")?.addEventListener("submit",function(e){

e.preventDefault()

let event={

id:eventId.value,
name:eventName.value,
category:eventCategory.value,
date:eventDate.value,
time:eventTime.value,
url:eventUrl.value

}

events.push(event)

localStorage.setItem("events",JSON.stringify(events))

displayAdminEvents()

})


/* DISPLAY EVENTS */

function displayAdminEvents(){

let container=document.getElementById("adminEvents")

if(!container) return

container.innerHTML=""

events.forEach((e,i)=>{

container.innerHTML+=`

<div class="col-md-4 mt-3">

<div class="card p-3">

<h5>${e.name}</h5>

<p>ID: ${e.id}</p>

<p>Category: ${e.category}</p>

<p>Date: ${e.date}</p>

<a href="${e.url}" target="_blank">Join Event</a>

<button class="btn btn-danger mt-2" onclick="deleteEvent(${i})">Delete</button>

</div>

</div>

`

})

}


/* DELETE EVENT */

function deleteEvent(i){

events.splice(i,1)

localStorage.setItem("events",JSON.stringify(events))

displayAdminEvents()

}


/* REGISTER */

function registerEvent(e){

e.preventDefault()

alert("You are successfully registered to this event!")

}


/* CONTACT */

function contactSubmit(e){

e.preventDefault()

alert("Message submitted successfully!")

}