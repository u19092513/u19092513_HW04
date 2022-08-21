$(document).ready(function (){

    //To only show input fields related to the donation type selected
    $(".clothing").show();
    $(".money").hide();
    $(".food").hide();

    $("#donationType").on("change", function ()) {
        var val = $(this).val();

        if (val == "1") {
            $(".clothing").show();
            $(".money").hide();
            $(".food").hide();
        }

        if (val == "2") {
            $(".clothing").hide();
            $(".money").show();
            $(".food").hide();
        }

        if (val == "3") {
            $(".clothing").hide();
            $(".money").hide();
            $(".food").show();
        }

        
    }
   

}