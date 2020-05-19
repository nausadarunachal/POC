$.validator.setDefaults({
    submitHandler: function () {
        alert("submitted!");
        $.ajax({
            url: "/api/value", success: function (result) {
                alert(result);
                //$("#div1").html(result);
            }
        });
    }
});
$(document).ready(function () { alert("test!");});