function getJoke() {
    axios.get("https://v2.jokeapi.dev/joke/Programming").then((response) => {
        console.log(response);
        if (response.data.type == "single") {
            console.log(response.data.joke);
        } else {
            console.log(response.data.setup);
            console.log(response.data.delivery);
        }
    });
}
