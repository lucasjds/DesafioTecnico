// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.ajax({
  type: "POST",
  url: "/Home/ObtemResultadoCalculadora",
  data: { numero: 45 },
  dataType: "text",
  success: function (msg) {
    alert("RESULTADO PARA NUMERO 45 : " + JSON.stringify(msg, null, 2) );
  },
  error: function (req, status, error) {
    console.log(msg);
  }
}); 