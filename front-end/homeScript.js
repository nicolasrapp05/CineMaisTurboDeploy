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
                            <img width=300 src="${filme.foto}" alt="Filme 1">
                        </div>
                    `;
            });

            $('#filmes-container').append(html);
        }
    });
});