document.addEventListener('DOMContentLoaded', function () {
    fetch('data.json')
        .then(response => response.json())
        .then(data => {
            const personenDiv = document.getElementById('personen-info');
            data.forEach(person => {
                const personDiv = document.createElement('div');
                personDiv.classList.add('persoon');

                const title = document.createElement('h2');
                title.textContent = `${person.voornaam} ${person.achternaam}`;
                personDiv.appendChild(title);

                const ul = document.createElement('ul');
                ul.innerHTML = `
                    <li><strong>Nationaliteit:</strong> ${person.nationaliteit}</li>
                    <li><strong>Leeftijd:</strong> ${person.leeftijd}</li>
                    <li><strong>Gewicht:</strong> ${person.gewicht}</li>
                `;
                personDiv.appendChild(ul);

                personenDiv.appendChild(personDiv);
            });
        })
        .catch(error => console.error('Error fetching data:', error));
});
