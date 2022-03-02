$(document).ready(function () {
    fillSpecialties();
    addOnChangeSpecialty();
});

function fillSpecialties() {
    $.ajax({
        url: "../Appointment/AllSpecialties",
        method: "get",
        contentType: "application/json"
    })
        .done(res => {
            $("#SpecialtyId").append($("<option></option>").attr("value", "").text("Specialty"));
            for (let el of res) {
                $("#SpecialtyId").append($("<option></option>").attr("value", el.specialtyId).text(el.name));
            }
        }); 
}

function addOnChangeSpecialty() {
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