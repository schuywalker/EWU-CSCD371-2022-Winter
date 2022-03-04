document.getElementsByClassName("jokeButton")[0].addEventListener("click", getJoke);

function getJoke() {
    axios.get("https://v2.jokeapi.dev/joke/Programming").then((response) => {
        console.log(response);
        if (response.data.type == "single") {
            document.getElementsByClassName("jokeLine1")[0].innerHTML = response.data.joke;
            document.getElementsByClassName("jokeLine2")[0].innerHTML = "";
        } else {
            document.getElementsByClassName("jokeLine1")[0].innerHTML = response.data.setup;
            setTimeout(delayPunchline, 4000, response.data.delivery);
        }
    });
}

function delayPunchline(joke) {
    document.getElementsByClassName("jokeLine2")[0].innerHTML = joke;
}
