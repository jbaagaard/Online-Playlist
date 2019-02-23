let ui = {
    youtubeButton: window.document.getElementById("youtube-search-button"),
    spotifyButton: window.document.getElementById("spotify-search-button"),
    footer: window.document.getElementById("footer"),
    menuButton: window.document.getElementById("menu-logo"),
    sidebar: window.document.getElementById("sidebar"),
    sidebarOverlay: window.document.getElementById("sidebar-overlay")
};

ui.youtubeButton.addEventListener("click", function () {
    if(ui.footer.classList.contains("spotify-selected")){
        ui.footer.classList.remove("spotify-selected");
        ui.footer.classList.add("youtube-selected");
        if(ui.footer.classList.contains("hide"))
            ui.footer.classList.toggle("hide");
    }
    else if(ui.footer.classList.contains("youtube-selected")){
        ui.footer.classList.toggle("hide");
    }

});

ui.spotifyButton.addEventListener("click", function () {
    if(ui.footer.classList.contains("youtube-selected")){
        ui.footer.classList.remove("youtube-selected");
        ui.footer.classList.add("spotify-selected");
        if(ui.footer.classList.contains("hide"))
            ui.footer.classList.toggle("hide");

    }
    else if(ui.footer.classList.contains("spotify-selected")){
        ui.footer.classList.toggle("hide");
    }

});

ui.menuButton.addEventListener("click", function () {
    if(ui.sidebar.classList.contains("hidden")){
        ui.sidebar.classList.remove("hidden");
        ui.sidebarOverlay.style.visibility = "visible";
        ui.sidebarOverlay.style.backgroundColor= "rgba(0,0,0,0.4)";

    }
});


ui.sidebarOverlay.addEventListener("click", function () {
    if(!ui.sidebar.classList.contains("hidden")){
        ui.sidebar.classList.add("hidden");
        ui.sidebarOverlay.style.visibility = "hidden";
        ui.sidebarOverlay.style.backgroundColor= "rgba(0,0,0,0)";
    }
});


let songQueue = [];

songQueue.push("https://www.youtube.com/watch?v=yjrdJBP5i1I");
songQueue.push("https://www.youtube.com/watch?v=6KbRA2RjhgQ");




































