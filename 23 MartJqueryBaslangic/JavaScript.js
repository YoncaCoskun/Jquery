function $(metin) {
    return new Nesne(document.getElementById(metin));


}

function Nesne(HtmlNesnesi) {
    this.html = function (yazi) {
        HtmlNesnesi.innerHTML = yazi;  // yazıyı olusturma
    }
    this.bgColor = function (color1, color2) {
        HtmlNesnesi.style.backgroundColor = color1; //arkaplan rengı olusturma
        HtmlNesnesi.style.color = color2;
    }

}