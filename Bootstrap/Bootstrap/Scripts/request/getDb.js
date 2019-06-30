function getDB(el) {

        var xhr = new XMLHttpRequest();
        xhr.open('GET', 'aaa.json', false);
        xhr.send();

        if (xhr.status != 200) {
            //alert(xhr.status + ': ' + xhr.statusText);
            document.getElementById(el).textContent = xhr.status + ': ' + xhr.statusText;
        } else {
            //alert(xhr.responseText);
            document.getElementById(el).textContent = xhr.responseText;
}
}