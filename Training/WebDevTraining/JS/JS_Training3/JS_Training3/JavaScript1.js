setTimeout(function () { alert("Hello World !!!") }, 5000);

function Zarowka(zapalona) {
    this.zapalona = zapalona;
    this.zapal = function () {
        var zarowka = document.getElementsByClassName("bulb");

        if (zarowka && zarowka.length) {
            if (this.zapalona) {
                zarowka[0].style.backgroundPositionX = "";
            }
            else {
                zarowka[0].style.backgroundPositionX = "640px";
            }

            this.zapalona = !this.zapalona;
        }
    }

    if (zapalona) {
        this.zapal();
    }
}

var zarowka = new Zarowka(true);

//funkcja zapal:
//function zapal() {
//    var zarowka = document.getElementsByClassName("bulb");

//    if (zarowka && zarowka.length) {
//        zarowka[0].style.backgroundPositionX="640px";
//    }

//funkca zapal zgas:
//function zapal() {
//    var zarowka = document.getElementsByClassName("bulb");

//    if (zarowka && zarowka.length) {
//        if (zarowka[0].style.backgroundPositionX) {
//            zarowka[0].style.backgroundPositionX = "";
//        }
//        else {
//            zarowka[0].style.backgroundPositionX = "640px";
//        }
//    }
}