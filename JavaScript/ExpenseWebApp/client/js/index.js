$(document).ready(function () {
    $.getJSON('http://localhost:3000/expenses', function (list) {
        console.log('test: ' + list[0].date);
        printTerms(list);
    });        
});

function printTerms(terms) {
    $.each(terms, function () {
        $('tbody').append('<tr>'+'<td>'+this.date+'</td>'+ '<td>'+this.amount+'</td>'+'<td>'+this.description+'</td>'+'</tr>')
    });
}

function searchFunction() {
      // Declare variables 
      var input, filter, table, tr, td, i;
      input = document.getElementById("searchInput");
      filter = input.value.toUpperCase();
      tbody = document.getElementById("tableBody");
      tr = tbody.getElementsByTagName("tr");

      // Loop through all table rows, and hide those who don't match the search query
      for (i = 0; i < tr.length; i++) {
          if (tr[i].innerHTML.toUpperCase().indexOf(filter) > -1) {
            tr[i].style.display = "";
          } else {
            tr[i].style.display = "none";
          } 
      }
    }
