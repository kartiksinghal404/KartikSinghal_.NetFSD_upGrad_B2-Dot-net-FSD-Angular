const toggleButton = document.getElementById("themeToggle");

// Theme configuration object
const themes = {
    light: {
        "--bg-color": "#ffffff",
        "--text-color": "#000000"
    },
    dark: {
        "--bg-color": "#121212",
        "--text-color": "#ffffff"
    }
};

// Apply theme dynamically
function applyTheme(themeName) {
    const theme = themes[themeName];

    Object.keys(theme).forEach(key => {
        document.documentElement.style.setProperty(key, theme[key]);
    });

    localStorage.setItem("theme", themeName);
}

// Toggle theme
function toggleTheme() {
    const currentTheme = localStorage.getItem("theme") || "light";
    const newTheme = currentTheme === "light" ? "dark" : "light";
    applyTheme(newTheme);
}

// Load saved theme
function loadTheme() {
    const savedTheme = localStorage.getItem("theme") || "light";
    applyTheme(savedTheme);
}

toggleButton.addEventListener("click", toggleTheme);

loadTheme();