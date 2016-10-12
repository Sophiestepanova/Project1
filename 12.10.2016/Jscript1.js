function show_pic() {
    //alert('hi');
    var c1_elem = document.getElementById("c1");
    var c2_elem = document.getElementById("c2");
    var c3_elem = document.getElementById("c3");
    c1_elem.style.display = 'none';
    c2_elem.style.display = 'block';
    c3_elem.style.display = 'none';
}

function show_text() {
    var c1_elem = document.getElementById("c1");
    var c2_elem = document.getElementById("c2");
    var c3_elem = document.getElementById("c3");
    c1_elem.style.display = 'block';
    c2_elem.style.display = 'none';
    c3_elem.style.display = 'none';
}

function show_game() {
    var c1_elem = document.getElementById("c1");
    var c2_elem = document.getElementById("c2");
    var c3_elem = document.getElementById("c3");
    c1_elem.style.display = 'none';
    c2_elem.style.display = 'none';
    c3_elem.style.display = 'block';
}
function check() {
    q1elem = document.getElementById("q1");
    if (q1elem.checked) {
        alert("Да")
    }
    else {
        alert("Нет")
    };
    q3elem = document.getElementById("q3");
    answer = q3elem.value;
    alert("Точно " + answer + "?")
} 
