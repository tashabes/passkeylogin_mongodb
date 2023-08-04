// wwwroot/js/chart.js
function createChart(data) {
    var ctx = document.getElementById('myChart').getContext('2d');

    new Chart(ctx, {
        type: 'bar', // Change to 'line', 'pie', etc. for different chart types
        data: {
            labels: data.labels,
            datasets: data.datasets
        },
        options: {
            responsive: true,
            maintainAspectRatio: false // Set to true if you want the chart to maintain aspect ratio
        }
    });
}
