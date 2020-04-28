// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


     var search = document.getElementById("search");

        search.addEventListener("keydown", function (e) {
            if (e.keyCode === 13) {  
                checkInput();
            }
        });


        function checkInput() {
            var query = document.getElementById('search').value;
            window.find(query);
            return true;
        }
