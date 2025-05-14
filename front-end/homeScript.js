$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/filmes",
        dataType: "json",
        success: function (response) {

            response.sort(() => Math.random() - 0.5);

            let html = ''

            response.forEach(filme => {
                html +=`
                        <div>
                            <img data-id="${filme.id}" width=300 src="${filme.foto}" alt="${filme.nome}">
                        </div>
                    `;
            });

            $('#filmes-container').append(html);
        }
    });
});