$(document).ready(function () {
    $.ajax({
        url: "../Appointment/AllSpecialties",
        method: "get",
        contentType: "application/json"
    })
    .done(res => {
        fillSpecialties(res);
    });

    $("#SpecialtyId").on("change", function (e) {
        $.ajax({
            url: "../Appointment/AllDoctorsInSpecialty",
            method: "get", 
            contentType: "application/json",
            data: {
                specialtyId: this.value,
            }
        })
        .done(res => {
            fillDoctors(res);
        });
    });
});

function fillSpecialties(data) {
    $("#SpecialtyId").append($("<option></option>").attr("value", "").text("Specialty"));
    for (let el of data) {
        $("#SpecialtyId").append($("<option></option>").attr("value", el.specialtyId).text(el.name));
    }
}

function fillDoctors(data) {
    $('#DoctorId').find('option').remove().end();

    if (data.length > 0) {
        $("#DoctorId").append($("<option></option>").attr("value", "").text("Doctor"));
        for (let el of data) {
            $("#DoctorId").append($("<option></option>").attr("value", el.doctorId).text(el.fullName));
        }
        $("#DoctorId").removeAttr("disabled");
    } else {
        $("#DoctorId").attr("disabled", true);
    }
}