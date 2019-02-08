// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function calculate() {
    
    var result = parseInt(document.getElementById("first").value) + parseInt(document.getElementById("second").value);
    document.getElementById("result").innerHTML = result;
}