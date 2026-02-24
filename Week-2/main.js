// main.js
import { calculateTotal, generateInvoice } from './cart.js';

// Product Array
const cartProducts = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

// Calculate total
const total = calculateTotal(cartProducts);

// Display Invoice
console.log(generateInvoice(cartProducts));