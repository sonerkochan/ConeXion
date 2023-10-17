document.getElementById("flip-register").addEventListener("click", function () {
    document.querySelector(".form-box").classList.add("flip");
});

document.getElementById("flip-login").addEventListener("click", function () {
    document.querySelector(".form-box").classList.remove("flip");
});