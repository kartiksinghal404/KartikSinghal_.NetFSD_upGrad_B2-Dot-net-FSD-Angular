const products = [
    {
        id: 1,
        name: "iPhone 15",
        price: "₹79,900",
        image: "images/miniProduct-iphone.jpg",
        features: ["A16 Chip", "48MP Camera", "Dynamic Island"],
        benefits: ["Fast Performance", "Excellent Photos", "Premium Design"]
    },
    {
        id: 2,
        name: "Samsung Galaxy A73 5G",
        price: "₹74,999",
        image: "images/miniProduct-samsung.png",
        features: ["Snapdragon 8 Gen 2", "120Hz Display"],
        benefits: ["Smooth Experience", "Vibrant Screen"]
    },
    {
        id: 3,
        name: "MacBook Air",
        price: "₹1,14,900",
        image: "images/miniProduct-macbook.jpg",
        features: ["M2 Chip", "Retina Display", "18hr Battery"],
        benefits: ["Lightweight", "Long Battery Life"]
    }
];

const searchInput = document.getElementById("searchInput");
const productList = document.getElementById("productList");
const productDetails = document.getElementById("productDetails");

function renderProducts(list) {
    productList.innerHTML = "";

    if (list.length === 0) {
        productList.innerHTML = "<li>No Results Found</li>";
        productDetails.innerHTML = "";
        return;
    }

    list.forEach(product => {
        const li = document.createElement("li");
        li.textContent = product.name;
        li.dataset.id = product.id;
        productList.appendChild(li);
    });
}

function renderDetails(product) {
    productDetails.innerHTML = `
        <div class="detail-card">
            <img src="${product.image}" alt="${product.name}">
            <h2>${product.name}</h2>
            <p class="price">Price: ${product.price}</p>

            <h4>Features:</h4>
            <ul>
                ${product.features.map(f => `<li>${f}</li>`).join("")}
            </ul>

            <h4>Benefits:</h4>
            <ul>
                ${product.benefits.map(b => `<li>${b}</li>`).join("")}
            </ul>
        </div>
    `;
}

searchInput.addEventListener("input", function () {
    const value = this.value.toLowerCase();
    const filtered = products.filter(product =>
        product.name.toLowerCase().includes(value)
    );
    renderProducts(filtered);
});

productList.addEventListener("click", function (e) {
    if (e.target.tagName === "LI" && e.target.dataset.id) {
        const id = Number(e.target.dataset.id);
        const product = products.find(p => p.id === id);
        renderDetails(product);
    }
});

renderProducts(products);