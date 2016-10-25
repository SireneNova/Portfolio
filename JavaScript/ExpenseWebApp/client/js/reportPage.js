$(document).ready(function () {
    $.getJSON('http://localhost:3000/expenses', function (list) {
        printSelection();
        prepareFields(list);
        
        //make table:
        var yyyy = document.querySelector('option').value;
        var yearFilter= function(obj) { return obj.year==yyyy };
        filteredList = list.filter(yearFilter);
        groupWeeks(filteredList);
          
    $('select').on('change', function (){
        $('tbody tr').remove();
        var yyyy= this.value;
        var yearFilter= function(obj) { return obj.year==yyyy };
        filteredList = list.filter(yearFilter);
        groupWeeks(filteredList);
        });
    }); 
});

//print select menu:
function printSelection () {
    var thisDate = new Date();
    var endYear = thisDate.getFullYear();
    for (i=endYear; i>=1900; i--) {
        $('select').append('<option value = "' + i + '"> ' + i +'</option>');
        
    };    
};

//place actual amount, actual date, year, and week number to each array:
function prepareFields (obj) {
    $.each(obj, function () {
        this.amount = Number(this.amount);
        this.date= new Date(this.date);
        var actualDate=this.date;
        var actualYear = actualDate.getFullYear();
        this.year = actualYear;
        //Jan 1st of the year:
        var startDate = new Date("01-01-"+actualYear.toString());
        //difference in seconds:
        var diff = (actualDate-startDate)/1000;
        var secondsPerWeek = (60*60*24*7);
        var weekNo = Math.ceil(diff/(secondsPerWeek));
        this.week = weekNo;
        });
};

//pass filteredList into this:
function groupWeeks(obj2) {
    var groupedWeeks = _.groupBy(obj2, function(obj2){return obj2.week});
    
    weekKeys = Object.keys(groupedWeeks);
    
    var sumAmounts = new Array();
    
    $.each(groupedWeeks, function () {
        var this2 = this;
        var eachAmount = new Array();
        
        $.each(this2, function (){ 
            eachAmount.push(this.amount);
        });
        
        var sumAmount = eachAmount.reduce(add, 0);    
        function add(a, b) {
        return a + b;
        };
        sumAmounts.push(sumAmount);
    });
    
    for(var i = 0; i < weekKeys.length; i++){
        $('tbody').append('<tr>'+'<td>'+weekKeys[i]+'</td>'+'<td>'+sumAmounts[i]+'</td>'+'</tr>')
    };
};