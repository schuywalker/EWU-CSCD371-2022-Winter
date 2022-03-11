document.getElementsByClassName("joke-button")[0].addEventListener("click", getJoke);

var menuDisplayed = false;
var flipped = false;
var winning = false;

function getJoke() {
    axios
        .get("https://v2.jokeapi.dev/joke/Programming")
        .then((response) => {
            console.log(response);
            if (response.data.type == "single") {
                document.getElementsByClassName("joke-line1")[0].innerHTML = response.data.joke;
                document.getElementsByClassName("joke-line2")[0].innerHTML = "";
            } else {
                document.getElementsByClassName("joke-line1")[0].innerHTML = response.data.setup;
                document.getElementsByClassName("joke-line2")[0].innerHTML = "";
                setTimeout(delayPunchline, 4000, response.data.delivery);
            }
        })
        .catch(function (error) {
            document.getElementsByClassName("joke-line1")[0].innerHTML =
                "Joke Service is down, try again in a few moments.";
            document.getElementsByClassName("joke-line2")[0].innerHTML = "";
        });
}

function delayPunchline(joke) {
    document.getElementsByClassName("joke-line2")[0].innerHTML = joke;
}

function revealMenu() {
    menuDisplayed = !menuDisplayed;

    if (menuDisplayed) {
        document.getElementsByClassName("dropdown-menu")[0].style.display = "block";
    } else {
        document.getElementsByClassName("dropdown-menu")[0].style.display = "none";
    }
}

function flipBody() {
    flipped = !flipped;
    if (flipped) {
        document.getElementsByTagName("body")[0].classList.add("invert");
    } else {
        document.getElementsByTagName("body")[0].classList.remove("invert");
    }
}

function winBigBaby() {
    /*other way to do it
    // winning = !winning;
    // if (winning) {
    //     document.getElementsByTagName("body")[0].classList.add("add-money");
    // } else {
    //     document.getElementsByTagName("body")[0].classList.remove("add-money");
 } */
    winning = !winning;
    if (winning) {
        document.getElementsByTagName("body")[0].style.backgroundImage =
            "url('./piles-of-big-money.jpeg')";
    } else {
        document.getElementsByTagName("body")[0].style.backgroundImage = "none";
    }
}
