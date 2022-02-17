$(function () {
    $("#calendar").datepicker({
        onSelect: function () {
            let pickedDate = this.value;
            $("#calendar-value").text(pickedDate);
            $.ajax({
                url: "../Appointment/DoctorAvailability",
                method: "get",
                contentType: "application/json",
                data: {
                    doctorId: $("#DoctorId").val(),
                    date: pickedDate
                }
            })
                .done(res => {
                    $("#hours").empty();
                    $.each(res, function (k, v) {
                        if (v.availability) {
                            $("#hours").append("<p class='available'>" + v.hour + "</p>")
                        }
                        else {
                            $("#hours").append("<p class='not-available'>" + v.hour + "</p>");
                        }
                    });
                
            });
        }
    });
});