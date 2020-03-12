(function () {

    var element = document.getElementById("mObject");


    element.addEventListener("click", function () {
        var x = Math.floor(Math.random() * 600);
        var y = Math.floor(Math.random() * 1000);
        element.style.top = x + "px";
        element.style.left = y + "px";
        console.log("Object Clicked")

    });

    console.log(element);
    console.log("Object ready")
})();