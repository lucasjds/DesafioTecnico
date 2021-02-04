// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function calcularNumeros() {
  $.ajax({
    type: "POST",
    url: "/Home/ObtemResultadoCalculadora",
    data: {
      numero: $("#numero").val()
    },
    dataType: "text",
    success: function (msg) {
      $("#resultado").html("");
      $("#resultado").html(JSON.stringify(msg, null, 4));
    },
    error: function (req, status, error) {
      $("#resultado").html("");
      $("#resultado").html("Algum erro ocorreu");
    }
  }); 
}
