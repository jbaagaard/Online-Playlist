UI = {
    bgc:window.document.getElementById("bgc"),
    playerImg:window.document.getElementById("player-img")
};


function setCoverImg(url) {
    UI.bgc.style.backgroundImage = `url(http://i.ytimg.com/vi/${url}/maxresdefault.jpg)`;
    UI.playerImg.src = `url(http://i.ytimg.com/vi/${url}/maxresdefault.jpg)`;

}

setCoverImg("Y8ibdsPYOgw");

