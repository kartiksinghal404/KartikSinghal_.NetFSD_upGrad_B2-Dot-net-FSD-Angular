// cart.js

// Function to calculate total cart value
export const calculateTotal = (products) => {
    return products
        .map(product => product.price * product.quantity)
        .reduce((total, value) => total + value, 0);
};

// Function to generate invoice
export const generateInvoice = (products) => {
    const itemsList = products
        .map(product => 
            `${product.name} - ₹${product.price} x ${product.quantity} = ₹${product.price * product.quantity}`
        )
        .join("\n");

    const totalAmount = calculateTotal(products);

    return `
===== 🧾 INVOICE =====
${itemsList}
-----------------------
Total Amount: ₹${totalAmount}
=======================
`;
};