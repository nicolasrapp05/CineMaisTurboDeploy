document.addEventListener("DOMContentLoaded", () => {
  const container = document.getElementById("filmes-container");

  if (container) {
    fetch("https://cinemaisturbodeploy.onrender.com/api/filmes")
      .then((res) => {
        if (!res.ok) {
          throw new Error(`HTTP error! status: ${res.status}`);
        }
        return res.json();
      })
      .then((filmes) => {
        filmes.forEach((filme) => {
          const img = document.createElement("img");
          img.src = filme.foto;
          img.width = 300;
          img.height = 450;
          img.alt = filme.nome;
          img.style.cursor = "pointer";
          container.appendChild(img);
        });
      })
      .catch((err) => {
        console.error("Erro ao buscar filmes:", err);
        container.innerHTML =
          "<p style='color: red;'>Erro ao carregar os filmes.</p>";
      });
  }

  const cadastroForm = document.getElementById("cadastroForm");

  if (cadastroForm) {
    const tipoSelect = document.getElementById("tipo");
    const campoDuracao = document.getElementById("campoDuracao");
    const campoSerie = document.getElementById("campoSerie");
    const mensagemStatus = document.getElementById("mensagem");

    const toggleFields = () => {
      if (!tipoSelect || !campoDuracao || !campoSerie) return;

      if (tipoSelect.value === "series") {
        campoDuracao.style.display = "none";
        campoSerie.style.display = "block";
      } else {
        campoDuracao.style.display = "block";
        campoSerie.style.display = "none";
      }
    };

    if (tipoSelect) {
      tipoSelect.addEventListener("change", toggleFields);
      toggleFields();
    } else {
      console.error("Elemento #tipo não encontrado.");
    }

    cadastroForm.addEventListener("submit", function (e) {
      e.preventDefault();

      const tipo = tipoSelect.value;
      const apiUrl = `https://cinemaisturbodeploy.onrender.com/api/${tipo}`;

      mensagemStatus.textContent = "";
      mensagemStatus.style.color = "";

      let avaliacaoImdb = 0,
        avaliacaoTomates = 0,
        avaliacao = 0,
        temporadas = 0,
        episodios = 0;
      try {
        avaliacaoImdb =
          parseInt(document.getElementById("avaliacaoImdb").value) || 0;
      } catch {}
      try {
        avaliacaoTomates =
          parseInt(document.getElementById("avaliacaoTomates").value) || 0;
      } catch {}
      try {
        avaliacao = parseInt(document.getElementById("avaliacao").value) || 0;
      } catch {}

      const data = {
        nome: document.getElementById("nome").value,
        sinopse: document.getElementById("sinopse").value,
        avaliacaoImdb: avaliacaoImdb,
        avaliacaoTomates: avaliacaoTomates,
        foto: document.getElementById("foto").value,
        genero: document.getElementById("genero").value,
        avaliacao: avaliacao,
        lancamento: document.getElementById("lancamento").value,
      };

      if (tipo === "filmes") {
        data.duracao = document.getElementById("duracao").value;
      } else {
        try {
          temporadas =
            parseInt(document.getElementById("temporadas").value) || 0;
        } catch {}
        try {
          episodios = parseInt(document.getElementById("episodios").value) || 0;
        } catch {}
        data.temporadas = temporadas;
        data.episodios = episodios;
      }

      fetch(apiUrl, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(data),
      })
        .then((response) => {
          if (!response.ok) {
            throw new Error(
              `Falha no cadastro: ${response.status} ${response.statusText}`
            );
          }
          return response;
        })
        .then((result) => {
          console.log("Cadastro bem-sucedido:", result);

          Swal.fire({
            title: "Sucesso!",
            text: "Cadastro bem sucedido!",
            icon: "success",
            timer: 2000, // Fecha automaticamente após 2 segundos
            showConfirmButton: false, // Remove botão "OK"
          });

          setTimeout(() => {
            window.location.href = "home.html";
          }, 2000); // mesmo tempo do timer acima

          cadastroForm.reset();

          if (tipoSelect) {
            tipoSelect.value = "filmes";
            toggleFields();
          }
        })
        .catch((error) => {
          console.error("Erro durante o cadastro:", error);

          mensagemStatus.textContent = `Erro: ${
            error.message || "Não foi possível conectar ao servidor."
          }`;
          mensagemStatus.style.color = "red";
        });
    });
  }
});
