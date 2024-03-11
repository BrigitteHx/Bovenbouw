document.addEventListener('DOMContentLoaded', function () {
    fetch('games.json')
        .then(response => response.json())
        .then(data => {
            const gamesDiv = document.getElementById('gameList');
            const genreFilter = document.getElementById('genreFilter');
            const priceFilter = document.getElementById('priceFilter');
            const applyFiltersButton = document.getElementById('applyFiltersButton');
            const cart = document.getElementById('cart');
            const berekenenButton = document.getElementById('berekenenButton');
            const totalPriceDisplay = document.getElementById('totalPrice');

            let totalPrice = 0;

            function filterGames() {
                const selectedGenre = genreFilter.value;
                let maxPrice = parseFloat(priceFilter.value);
                
                gamesDiv.innerHTML = ''; // Clear the previous game list
                
                // Check if maxPrice is not a number or is less than 0
                if (isNaN(maxPrice) || maxPrice < 0) {
                    maxPrice = Infinity; // Set maxPrice to infinity to include all games
                }
                
                data.forEach(gameData => {
                    if ((selectedGenre === 'All' || gameData.genre === selectedGenre) &&
                        (gameData.price === 0 || gameData.price <= maxPrice)) {
                        const gameContainer = document.createElement('div');
                        gameContainer.classList.add('game-container');

                        const title = document.createElement('h2');
                        title.textContent = `${gameData.title}`;
                        gameContainer.appendChild(title);

                        const price = document.createElement('p');
                        price.textContent = `Price: ${gameData.price === 0 ? 'FREE' : gameData.price}`;
                        gameContainer.appendChild(price);

                        const genre = document.createElement('p');
                        genre.textContent = `Genre: ${gameData.genre}`;
                        gameContainer.appendChild(genre);

                        const rating = document.createElement('p');
                        rating.textContent = `Rating: ${gameData.rating}`;
                        gameContainer.appendChild(rating);

                        // Create checkbox
                        const checkbox = document.createElement('input');
                        checkbox.type = 'checkbox';
                        checkbox.classList.add('styled-checkbox');
                        checkbox.addEventListener('change', function () {
                            if (checkbox.checked) {
                                addToCart(gameData);
                            } else {
                                removeFromCart(gameData);
                            }
                        });
                        gameContainer.appendChild(checkbox);

                        gamesDiv.appendChild(gameContainer);
                    }
                });
            }

            // Function to add a game to the cart
            function addToCart(gameData) {
                const cartItem = document.createElement('div');
                cartItem.classList.add('cart-item');

                // Create a container for the game details
                const detailsContainer = document.createElement('div');
                detailsContainer.classList.add('game-details');

                // Create elements for each detail and append to the details container
                const title = document.createElement('p');
                title.textContent = `Title: ${gameData.title}`;
                detailsContainer.appendChild(title);

                const price = document.createElement('p');
                price.textContent = `Price: ${gameData.price === 0 ? 'FREE' : gameData.price}`;
                detailsContainer.appendChild(price);

                const genre = document.createElement('p');
                genre.textContent = `Genre: ${gameData.genre}`;
                detailsContainer.appendChild(genre);

                const rating = document.createElement('p');
                rating.textContent = `Rating: ${gameData.rating}`;
                detailsContainer.appendChild(rating);

                // Append the details container to the cart item
                cartItem.appendChild(detailsContainer);

                // Append the cart item to the cart
                cart.appendChild(cartItem);

                // Add the price to the total price
                totalPrice += gameData.price;
                updateTotalPrice();
            }

            // Function to remove a game from the cart
            function removeFromCart(gameData) {
                const cartItems = cart.querySelectorAll('.cart-item');
                cartItems.forEach(item => {
                    if (item.textContent.includes(gameData.title)) {
                        cart.removeChild(item);
                        // Subtract the price from the total price
                        totalPrice -= gameData.price;
                        
                    }
                });
            }

            // Call filterGames function initially
            filterGames();

            // Event listener for applying filters
            applyFiltersButton.addEventListener('click', filterGames);

            // Event listener for "berekenen" button
            document.getElementById('calculateTotalButton').addEventListener('click', function () {
                totalPriceDisplay.textContent = `Total Price: ${totalPrice.toFixed(2)}`;
                
            });
        })
        .catch(error => console.error('Error fetching data:', error));
});
