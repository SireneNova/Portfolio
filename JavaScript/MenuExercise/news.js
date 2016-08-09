$(document).ready(function() {
  $(".ul2").hide();
  
  $("#s").mouseenter(function() {
    $(".ul2").slideToggle();
  });
  
  $(".ul2").mouseleave(function() {
    $(this).slideUp();
  });
  
  // This could be used instead of data attributes to call "bootstrap menu":
  // $(".dropdown-toggle").dropdown("toggle");
  
  //This is necessary for the mouse over tooltip:
  $(function () {
  $('[data-toggle="tooltip"]').tooltip()
  });  
  
});
