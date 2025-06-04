$(document).ready(function () {
  function fetchAndDisplayTop10(apiUrl, wrapperSelector, itemType) {
    $.ajax({
      type: "GET",
      url: apiUrl,
      dataType: "json",
      success: function (top10Items) {
        let html = "";
        if (top10Items && top10Items.length > 0) {
          top10Items.forEach((item, index) => {
            html += `
                    <div class="swiper-slide">
                        <div class="ranking-number">${index + 1}</div>
                        <img data-id="${
                          item.id
                        }" class="poster ${itemType}-img" src="${
              item.foto
            }" alt="${item.nome}">
                    </div>
                    `;
          });
        } else {
          html = `<p class="text-white text-center" style="width: 100%;">Nenhum ${itemType} encontrado para exibir no ranking.</p>`;
        }

        $(wrapperSelector).html(html);
      },
      error: function (error) {
        console.error(`Erro ao buscar ${itemType}s de ${apiUrl}:`, error);
        $(wrapperSelector).html(
          `<p class="text-white text-center" style="width: 100%;">Erro ao carregar o ranking de ${itemType}s.</p>`
        );
      },
    });
  }

  fetchAndDisplayTop10(
    "http://localhost:5018/api/filmes/top10",
    ".top10Swiper .swiper-wrapper:eq(0)",
    "filme"
  );

  fetchAndDisplayTop10(
    "http://localhost:5018/api/series/top10",
    ".top10Swiper .swiper-wrapper:eq(1)",
    "serie"
  );

  function fetchTotalFilmes() {
    $.ajax({
      type: "GET",
      url: "http://localhost:5018/api/filmes/total",
      dataType: "json",
      success: function (total) {
        $("#total-filmes").text(total);
      },
      error: function (error) {
        console.error("Erro ao buscar total de filmes:", error);
        $("#total-filmes").text("N/A");
      },
    });
  }

  function fetchTotalSeries() {
    $.ajax({
      type: "GET",
      url: "http://localhost:5018/api/series/total",
      dataType: "json",
      success: function (total) {
        $("#total-series").text(total);
      },
      error: function (error) {
        console.error("Erro ao buscar total de séries:", error);
        $("#total-series").text("N/A");
      },
    });
  }

  fetchTotalFilmes();
  fetchTotalSeries();
});
