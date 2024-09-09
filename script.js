document.getElementById('subscribeForm').addEventListener('submit', function(event) {
    event.preventDefault();

    const email = document.getElementById('email').value;

    fetch('http://localhost:5144/api/subscribe', { // Change to your API endpoint
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ email: email })
    })
    .then(response => response.text())
    .then(data => {
        document.getElementById('responseMessage').textContent = data;
    })
    .catch(error => {
        document.getElementById('responseMessage').textContent = 'An error occurred: ' + error;
    });
});

