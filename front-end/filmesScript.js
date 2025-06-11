$(document).ready(function () {
  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Acao",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide filme-img">
                    <img class="filme-img" data-id="${filme.id}" width=200 src="${filme.foto}" alt="Filme 1">
                </div>
                `;
      });

      $("#carrossel-acao").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=FiccaoCientifica",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-ficcaoCientifica").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Aventura",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-aventura").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Animacao",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-animacao").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Comedia",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-comedia").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Documentario",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-documentario").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Acao",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-acao").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Drama",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-drama").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Fantasia",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-fantasia").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Faroeste",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-faroeste").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Romance",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-romance").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Terror",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-terror").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $.ajax({
    type: "GET",
    url: "https://cinemaisturbodeploy.onrender.com/api/filmes?genero=Suspense",
    dataType: "json",
    success: function (response) {
      let html = "";

      response.forEach((filme) => {
        html += `
                <div class="swiper-slide">
                    <img data-id="${filme.id}" class="filme-img" width=200 src="${filme.foto}" alt="${filme.nome}">
                </div>
                `;
      });

      $("#carrossel-suspense").append(html);
    },
    error: function () {
      console.error("erro meu");
    },
  });

  $(document).on("click", ".filme-img", function () {
    const filmeId = $(this).data("id");

    $.ajax({
      type: "GET",
      url: `https://cinemaisturbodeploy.onrender.com/api/filmes/${filmeId}`,
      dataType: "json",
      success: function (filme) {
        Swal.fire({
          html: `
                        <div class="text-white p-4" style="
                            background: linear-gradient(rgba(0,0,0,0.92), rgba(0,0,0,0.92)), url('${
                              filme.foto
                            }') no-repeat center center;
                            background-size: cover;
                            border-radius: 10px;
                            
                            ">
                            <div class="row">
                                <div class="col-md-4 text-center mb-3">
                                    <img class="img-fluid rounded shadow" src="${
                                      filme.foto
                                    }" alt="${filme.nome}">
                                    <div class="mt-3">
                                        <label><strong>URL da Foto/Poster:</strong></label>
                                        <input type="text" class="form-control" id="input-foto" value="${
                                          filme.foto
                                        }">
                                    </div>
                                </div>
                                
                                <div class="col-md-8">
                                <div class="mb-2">
                                <label><strong>Nome:</strong></label>
                                <input type="text" class="form-control" id="input-nome" value="${
                                  filme.nome
                                }">
                            </div>

                                <div class="mb-2">
                                    <div class="form-group">
                                        <label for="genero">Gênero:</label>
                                        <select value=${
                                          filme.genero
                                        } name="genero" id="input-genero">
                                            <option value="" disabled >Selecione uma opção</option>
                                            <option value="Acao">Ação</option>
                                            <option value="Aventura">Aventura</option>
                                            <option value="Animacao">Animação</option>
                                            <option value="Comedia">Comédia</option>
                                            <option value="Documentario">Documentário</option>
                                            <option value="Drama">Drama</option>
                                            <option value="Fantasia">Fantasia</option>
                                            <option value="Faroeste">Faroeste</option>
                                            <option value="FiccaoCientifica">Ficção Científica</option>
                                            <option value="Romance">Romance</option>
                                            <option value="Suspense">Suspense</option>
                                            <option value="Terror">Terror</option>
                                        </select>
                                    </div>
                                </div>

                                <div class="mb-2">
                                    <label><strong>Duração:</strong></label>
                                    <input type="text" class="form-control" id="input-duracao" value="${
                                      filme.duracao
                                    }">
                                </div>

                                <div class="mb-2">
                                    <label><strong>Nota IMDB:</strong></label>
                                    <input type="number" class="form-control" id="input-imdb" value="${
                                      filme.avaliacaoImdb
                                    }">
                                </div>

                                <div class="mb-2">
                                    <label><strong>Nota Tomates:</strong></label>
                                    <input type="number" class="form-control" id="input-tomates" value="${
                                      filme.avaliacaoTomates
                                    }">
                                </div>

                                <div class="mb-2">
                                    <label><strong>Avaliação:</strong></label>
                                    <input type="number" class="form-control" id="input-avaliacao" value="${
                                      filme.avaliacao
                                    }">
                                </div>
                                <div class="mb-2">
                                <label><strong>Lançamento:</strong></label>
                                <input type="date" class="form-control" id="input-lancamento" value="${
                                  new Date(filme.lancamento)
                                    .toISOString()
                                    .split("T")[0]
                                }">
                            </div>
                                </div>
                            </div>

                            <div class="row mt-3">
                                <div class="col">
                                <label><h4>Sinopse</h4></label>
                                <textarea class="form-control" id="input-sinopse" rows="4">${
                                  filme.sinopse
                                }</textarea>
                                </div>
                            </div>

                            <div class="row mt-4 justify-content-center text-center">
                                <div class="col-auto">
                                </div>
                                <div class="col-auto">
                                <button type="button" class="btn btn-danger excluirFilme" data-id="${
                                  filme.id
                                }">
                                    <i class="fa-solid fa-trash"></i>&nbsp;EXCLUIR
                                </button>
                                </div>
                                <div class="col-auto">
                                <button type="button" class="btn btn-warning editarFilme" data-id="${
                                  filme.id
                                }">
                                    <i class="fa-solid fa-pen-to-square"></i>&nbsp;EDITAR
                                </button>
                                </div>
                                <div class="col-auto">
                                </div>
                            </div>
                        </div>
                    `,
          didOpen: () => {
            $("#input-genero").val(filme.genero); // define o gênero corretamente
            document.querySelector(
              ".swal2-popup"
            ).style.backgroundImage = `linear-gradient(rgba(0,0,0,0.92), rgba(0,0,0,0.92)), url('${filme.foto}')`;
          },
          showCloseButton: true,
          showConfirmButton: false,
          width: "1000px",
          background: "transparent",
          customClass: {
            popup: "popup-altura",
          },
        });
      },
      error: function () {
        Swal.fire(
          "Erro",
          "Não foi possível carregar os detalhes do filme.",
          "error"
        );
      },
    });
  });
});

$(document).on("click", ".excluirFilme", function () {
  let id = $(this).data("id");

  Swal.fire({
    title: "Tem certeza?",
    icon: "warning",
    showCancelButton: true,
    confirmButtonColor: "#3085d6",
    cancelButtonColor: "#d33",
    confirmButtonText: "Sim, deletar!",
    cancelButtonText: "Cancelar",
  }).then((result) => {
    if (result.isConfirmed) {
      $.ajax({
        type: "DELETE",
        url: `https://cinemaisturbodeploy.onrender.com/api/filmes/${id}`,
        success: function () {
          $(`img[data-id="${id}"]`).closest(".swiper-slide").remove();

          Swal.fire({
            title: "Sucesso!",
            text: "Filme deletado com sucesso.",
            icon: "success",
          });
        },
        error: function () {
          Swal.fire({
            title: "Erro!",
            text: "Erro ao deletar filme.",
            icon: "error",
          });
        },
      });
    }
  });
});

$(document).on("click", ".editarFilme", function () {
  const id = $(this).data("id");

  const dadosAtualizados = {
    nome: $("#input-nome").val(),
    foto: $("#input-foto").val(),
    lancamento: $("#input-lancamento").val(),
    genero: $("#input-genero").val(),
    duracao: $("#input-duracao").val(),
    avaliacaoImdb: parseInt($("#input-imdb").val()),
    avaliacaoTomates: parseInt($("#input-tomates").val()),
    avaliacao: parseInt($("#input-avaliacao").val()),
    sinopse: $("#input-sinopse").val(),
  };

  $.ajax({
    type: "PUT",
    url: `https://cinemaisturbodeploy.onrender.com/api/filmes/${id}`,
    contentType: "application/json",
    data: JSON.stringify(dadosAtualizados),
    success: function () {
      Swal.fire({
        icon: "success",
        title: "Filme atualizado!",
        text: "As informações foram salvas com sucesso.",
      }).then(() => location.reload());
    },
    error: function () {
      Swal.fire({
        icon: "error",
        title: "Erro ao atualizar",
        text: "Não foi possível salvar as alterações.",
      });
    },
  });
});
