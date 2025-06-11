$(document).ready(function () {
  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes",
    dataType: "json",
    success: function (response) {
      response.sort((a, b) => b.avaliacao - a.avaliacao);

      let html = "";

      response.forEach((filme) => {
        html += `
                        <div>
                            <img data-id="${filme.id}" width=300 src="${filme.foto}" alt="${filme.nome}">
                        </div>
                    `;
      });

      $("#filmes-container").append(html);
    },
  });
});
