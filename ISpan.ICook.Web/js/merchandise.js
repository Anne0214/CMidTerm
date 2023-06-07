// tab用
let tabLink = document.getElementById("tab-btns").querySelectorAll("a");
let tabContents = document.getElementById("tab-inner").querySelectorAll('.form-content');

for (let i = 0; i < tabLink.length; i++) {
    tabLink[i].addEventListener('click', function(e) {
        e.preventDefault();
        panelDisplay(this);

    });

};

function panelDisplay(activePanel) {

    for (let i = 0; i < tabLink.length; i++) {

        if (tabLink[i] == activePanel) {
            tabLink[i].classList.add("tab_btn_active");
            tabContents[i].style.display = "block";

        } else {
            tabLink[i].classList.remove("tab_btn_active");
            tabContents[i].style.display = "none";
        }
    }
};


//數量器用
const counter = document.getElementById("num");
const add_btn = documment.getElementById("add_btn");
const minus_btn = documment.getElementById("minus_btn");
add_btn.addEventListener('click', function() {
    counter.value = counter.value + 1;
});
minus_btn.addEventListener('click', function() {
    counter.value = counter.value - 1;
});