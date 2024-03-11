// Functie om het panel met knoppen te maken
function createButtonPanel() {
    // Maak een div-element voor het panel
    const panel = document.createElement("div");
    panel.id = "button-panel";
    
    // Voeg stijlen toe aan het panel
    panel.style.textAlign = "center";
    panel.style.margin = "5vh"
    panel.style.padding = "5vh";
    panel.style.backgroundColor = "white";
    
    // Maak drie knoppen voor groen, rood en blauw
    const greenButton = createButton("Groen", "green");
    const redButton = createButton("Rood", "red");
    const blueButton = createButton("Blauw", "blue");
    
    // Voeg de knoppen toe aan het panel
    panel.appendChild(greenButton);
    panel.appendChild(redButton);
    panel.appendChild(blueButton);
    
    // Voeg het panel toe aan de container in de HTML
    const container = document.getElementById("container");
    container.appendChild(panel);
}

// Functie om een knop te maken
function createButton(text, color) {
    // Maak een button-element
    const button = document.createElement("button");
    
    // Voeg de tekst en stijl toe aan de knop
    button.textContent = text;
    button.style.backgroundColor = color;
    button.style.color = "white";
    button.style.padding = "10px 20px";
    button.style.margin = "10px";
    button.style.border = "none";
    button.style.borderRadius = "5px";
    button.style.cursor = "pointer";
    
    // Voeg een event listener toe om de achtergrondkleur te veranderen wanneer er op de knop wordt geklikt
    button.addEventListener("click", function() {
        document.body.style.backgroundColor = color;
    });
    
    return button;
}

// Roep de functie aan om het panel met knoppen te maken wanneer de pagina wordt geladen
window.onload = function() {
    createButtonPanel();
};
