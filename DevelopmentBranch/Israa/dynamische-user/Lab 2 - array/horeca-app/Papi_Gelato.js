// Constanten en variabelen
const BTW_PERC = 6;
const OPTION_ERROR = 'Sorry, dat is geen optie die we aanbieden...';

// Object om de prijzen van verschillende items bij te houden
const prices = {
    aardbei: 0.95,
    chocolade: 0.95,
    vanille: 0.95,
    hoorntje: 1.25,
    bakje: 0.75,
    slagroom: 0.50,
    sprinkels: 0.30,
    caramel_saus: 0.90
};

// Object om het aantal bestelde items bij te houden
let order = {
    bolletjes: 0,
    liter: 0,
    hoorntje: 0,
    bakje: 0,
    topping: ''
};

// Functie om welkomstbericht te tonen
function welcomeMessage() {
    return "Welkom bij Papi Gelato\n";
}

// Functie om te vragen of de klant particulier of zakelijk is
function customerType() {
    let choice = true;
    while (choice) {
        let customer = prompt("Bent u 1) een particuliere klant of 2) een zakelijke klant?");
        if (customer === '1' || customer === '2') {
            choice = false;
            return customer;
        } else {
            alert(OPTION_ERROR);
        }
    }
}

// Functie om het aantal te vragen
function askQuantity(customerType) {
    let quantity = true;
    while (quantity) {
        let amount;
        if (customerType === '1') {
            amount = parseInt(prompt("Hoeveel bolletjes wilt u?"));
            if (amount > 8) {
                alert("Sorry, zulke grote bakken hebben we niet");
            } else {
                quantity = false;
            }
        } else if (customerType === '2') {
            amount = parseInt(prompt("Hoeveel liter wilt u?"));
            quantity = false;
        }
        return amount;
    }
}

// Functie om smaak te kiezen
function chooseFlavors(amount) {
    let flavors = [];
    let counter = 0;
    let container = (order.liter > 0) ? "liter" : "bolletjes";
    while (counter < amount) {
        let flavor = prompt(`Welke smaak wilt u voor ${container} ${counter + 1}?\nA) Aardbei, C) Chocolade of V) Vanille?`);
        if (flavor.toLowerCase() === "aardbei" || flavor.toLowerCase() === "chocolade" || flavor.toLowerCase() === "vanille") {
            flavors.push(flavor.toLowerCase());
            counter++;
        } else {
            alert(OPTION_ERROR);
        }
    }
    return flavors;
}

// Functie om keuze te maken
function makeChoice(amount, customerType) {
    let choice = '';
    if (customerType === '1') {
        if (amount <= 3) {
            choice = prompt(`Wilt u deze ${amount} bolletjes in een hoorntje of een bakje?`);
            if (choice.toLowerCase() !== 'hoorntje' && choice.toLowerCase() !== 'bakje') {
                alert(OPTION_ERROR);
            }
        } else if (amount >= 4 && amount <= 8) {
            alert(`Dan krijgt u van mij een bakje met ${amount} bolletjes`);
            choice = 'bakje';
        }
    } else if (customerType === '2') {
        choice = '';
    }
    return choice;
}

// Functie om topping te kiezen
function chooseTopping(customerType) {
    let topping = '';
    if (customerType === '1') {
        topping = prompt("Wat voor topping wilt u: \nA) Geen, B) Slagroom, C) Sprinkels of D) Caramel Saus?");
        if (topping.toLowerCase() !== 'a' && topping.toLowerCase() !== 'b' && topping.toLowerCase() !== 'c' && topping.toLowerCase() !== 'd') {
            alert(OPTION_ERROR);
        }
    }
    return topping.toLowerCase();
}

// Functie om de totale prijs te berekenen
function calculateTotalPrice(flavors, topping) {
    let totalPrice = 0;
    flavors.forEach(flavor => {
        totalPrice += prices[flavor];
    });
    if (topping !== 'a') {
        totalPrice += prices[topping];
    }
    return totalPrice;
}

// Functie om meer te bestellen
function buyMore(customerType) {
    let extra = '';
    if (customerType === '1') {
        extra = prompt('Wilt u nog meer bestellen?');
    } else if (customerType === '2') {
        extra = 'stop';
    }
    return extra;
}

// Functie om bonnetje te genereren
function generateReceipt(flavors, totalPrice, customerType) {
    let receipt = [];
    flavors.forEach(flavor => {
        receipt.push(`${flavor}: €${prices[flavor].toFixed(2)}`);
    });
    if (order.topping !== 'a') {
        receipt.push(`Topping: €${prices[order.topping].toFixed(2)}`);
    }
    receipt.push(`Totaal: €${totalPrice.toFixed(2)}`);
    if (customerType === '2') {
        let btwAmount = totalPrice / 100 * (BTW_PERC + 100);
        receipt.push(`BTW (${BTW_PERC}%): €${btwAmount.toFixed(2)}`);
    }
    return receipt;
}

// Hoofdprogramma
function main() {
    let order_again = true;
    alert(welcomeMessage());

    while (order_again) {
        let customer = customerType();
        order.bolletjes = askQuantity(customer);
        let chosenFlavors = chooseFlavors(order.bolletjes);
        order.hoorntje_bakje = makeChoice(order.bolletjes, customer);
        order.topping = chooseTopping(customer);
        let totalPrice = calculateTotalPrice(chosenFlavors, order.topping);
        let receipt = generateReceipt(chosenFlavors, totalPrice, customer);
        console.log(receipt);
        let more = buyMore(customer);
        if (more.toLowerCase() !== "stop" && more.toLowerCase() !== "nee") {
            order_again = true;
        } else {
            alert("Bedankt voor uw bestelling!");
            console.log(receipt)
            order_again = false;
        }
        
    }
}

// Roep het hoofdprogramma aan om te starten
main();
