window.ChartJsInterop = {
    createChart: function (canvasId, data) {
        const ctx = document.getElementById(canvasId).getContext("2d");

        new Chart(ctx, {
            type: "bar",
            data: data,
            options: {
                legend: { display: false },
                title: {
                    display: true,
                    text: "World Wine Production 2018"
                }
            }
        });
    }
};
