document.addEventListener("DOMContentLoaded", () => {
    const container = document.getElementById("filmes-container");
  
    fetch("http://localhost:5018/api/filmes")
      .then((res) => res.json())
      .then((filmes) => {
        filmes.forEach((filme) => {
          const img = document.createElement("img");
          img.src = filme.foto;
          img.width = 300;
          img.alt = filme.nome;
          container.appendChild(img);
        });
      })
      .catch((err) => {
        console.error("Erro ao buscar filmes:", err);
        container.innerHTML = "<p>Erro ao carregar os filmes.</p>";
      });
  });
  