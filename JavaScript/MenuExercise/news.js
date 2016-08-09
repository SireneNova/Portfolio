$(document).ready(function() {
  $(".ul2").hide();
  
  $("#s").mouseenter(function() {
    $(".ul2").slideToggle();
  });
  
  $(".ul2").mouseleave(function() {
    $(this).slideUp();
  });
  
  // This was stated to be necessary for menu, but is not:
  // $(".dropdown-toggle").dropdown("toggle");
  
  //This is for the mouse over tooltip:
  $(function () {
  $('[data-toggle="tooltip"]').tooltip()
  });  
  
});
