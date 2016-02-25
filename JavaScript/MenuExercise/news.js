$(document).ready(function() {
  $(".ul2").hide();
  
  $("#s").mouseenter(function() {
    $(".ul2").slideToggle();
  });
  
  $(".ul2").mouseleave(function() {
    $(this).slideUp();
  });
  
});