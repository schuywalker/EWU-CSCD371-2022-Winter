document.getElementsByClassName("joke-button")[0].addEventListener("click", getJoke);

var menuDisplayed = false;

function getJoke() {
    axios.get("https://v2.jokeapi.dev/joke/Programming").then((response) => {
        console.log(response);
        if (response.data.type == "single") {
            document.getElementsByClassName("joke-line1")[0].innerHTML = response.data.joke;
            document.getElementsByClassName("joke-line2")[0].innerHTML = "";
        } else {
            document.getElementsByClassName("joke-line1")[0].innerHTML = response.data.setup;
            setTimeout(delayPunchline, 4000, response.data.delivery);
        }
    }).catch(function (error) {
    document.getElementsByClassName("joke-line1")[0].innerHTML = "Joke Service is down, try again in a few moments.";
    document.getElementsByClassName("joke-line2")[0].innerHTML = "";
})
}

function delayPunchline(joke) {
    document.getElementsByClassName("joke-line2")[0].innerHTML = joke;
}

function revealMenu() {

    menuDisplayed = !menuDisplayed

    if (menuDisplayed){
        document.getElementsByClassName("dropdown-menu")[0].style.display = "block";
    }
    else{
        document.getElementsByClassName("dropdown-menu")[0].style.display = "none";
    }
    
        
}
