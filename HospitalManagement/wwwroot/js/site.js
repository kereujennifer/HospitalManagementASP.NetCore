// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Get the current year
const currentYear = new Date().getFullYear();

// Update the content of the span element with the current year
document.getElementById("current-year").textContent = currentYear;

function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}
const list = document.querySelectorAll('.list')
function activeLink() {
    list.forEach((item) =>
        item.classList.remove('active'));
    this.classList.add('active');
    debugger
    let id = this.getAttribute("id");
    sessionStorage.setItem("sidebarMenu", id);

}
list.forEach((item) =>
    item.addEventListener('click', activeLink));

//change active class
debugger
const sidebarMenu = sessionStorage.getItem("sidebarMenu");
if (sidebarMenu) {
    list.forEach((item) =>
        item.classList.remove('active'));
    const elem = document.getElementById(sidebarMenu);
    elem.classList.add('active');
}
$(document).ready(function () {
    $('#calendar').fullCalendar({
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        events: function (start, end, timezone, callback) {
            $.ajax({
                url: '/Appointments/GetAppointments',
                type: 'GET',
                dataType: 'json',
                success: function (response) {
                    var events = [];
                    $.each(response, function (index, appointment) {
                        events.push({
                            id: appointment.id,
                            title: appointment.title,
                            start: moment(appointment.start),
                            end: moment(appointment.end),
                            url: '/Appointments/Edit/' + appointment.id
                        });
                    });
                    callback(events);
                }
            });
        }
    });
});