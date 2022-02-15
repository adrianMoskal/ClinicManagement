$(function () {
    $("#calendar").datepicker({
        onSelect: function () {
            $("#calendar-value").text(this.value);
        }
    });
});
