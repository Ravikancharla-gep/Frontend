// Select HTML Elements
const button = document.getElementById('newQuoteButton');
const paragraph = document.getElementById('quoteDisplay');

// Create an Array of Quotes
const quotes = [
    "The best way to predict the future is to invent it.",
    "Life is 10% what happens to us and 90% how we react to it.",
    "Success is not the key to happiness. Happiness is the key to success."
];

// Add an Event Listener
button.addEventListener('click', () => {
    const randomIndex = Math.floor(Math.random() * quotes.length);
    paragraph.textContent = quotes[randomIndex];
    console.log(quotes[randomIndex]);
});