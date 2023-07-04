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


    $(document).ready(function() {
        $('.table').DataTable();
    });

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
})


// Function to show or hide the "Parent/Guardian Name" field based on the value of "UnderEighteen"
function toggleParentGuardianField() {
    var underEighteen = document.getElementById('UnderEighteen').checked;
    var parentGuardianField = document.getElementById('parentGuardianField');

    if (underEighteen) {
        parentGuardianField.style.display = 'block'; // Show the field
    } else {
        parentGuardianField.style.display = 'none'; // Hide the field
    }
}

// Attach event listener to the "UnderEighteen" checkbox
var underEighteenCheckbox = document.getElementById('UnderEighteen');
underEighteenCheckbox.addEventListener('change', toggleParentGuardianField);

// Call the function on page load to ensure the initial state is correct
toggleParentGuardianField();
// get all the dropdown links
var dropdownLinks = document.querySelectorAll('.nav-item.dropdown .nav-link.dropdown-toggle');

// loop through each dropdown link
for (var i = 0; i < dropdownLinks.length; i++) {
    // add a click event listener to each dropdown link
    dropdownLinks[i].addEventListener('click', function (e) {
        // prevent the default behavior of the link
        e.preventDefault();
        // toggle the "show" class on the dropdown menu
        this.nextElementSibling.classList.toggle('show');
    });
}

// get all the links in the navbar
var navbarLinks = document.querySelectorAll('.navbar-nav .nav-link');

// loop through each navbar link
for (var i = 0; i < navbarLinks.length; i++) {
    // add a click event listener to each navbar link
    navbarLinks[i].addEventListener('click', function () {
        // remove the "show" class from all dropdown menus
        var dropdownMenus = document.querySelectorAll('.navbar-nav .dropdown-menu.show');
        for (var j = 0; j < dropdownMenus.length; j++) {
            dropdownMenus[j].classList.remove('show');
        }
    });
}

var db = new PatientDbContext()
{
    var newPatient = new Patient
    {
        Name = "John Doe"



        db.Patients.Add(newPatient);
        db.SaveChanges();

        var registrationNumber = newPatient.RegistrationNumber;
        // use the registration number to input vital signs and beds
    }

    //var subcounties = {
    //    mombasa: ["Changamwe", "Jomvu", "Kisauni", "Nyali", "Likoni", "Mvita"],
    //    kwale: ["Kinango", "Lunga Lunga", "Msambweni", "Matuga"],
    //    kilifi: ["Kaloleni", "Kilifi North", "Kilifi South", "Magarini", "Malindi", "Rabai"]
    //    // add more sub-counties for the remaining counties
    //};
    //var countySelect = document.getElementById("county");
    //var subcountySelect = document.getElementById("subcounty");

    //countySelect.addEventListener("change", function () {
    //    var county = this.value;
    //    subcountySelect.innerHTML = ""; // clear previous options
    //    subcountySelect.disabled = (county === "");
    //    if (county in subcounties) {
    //        subcounties[county].forEach(function (subcounty) {
    //            var option = document.createElement("option");
    //            option.value = subcounty;
    //            option.textContent = subcounty;
    //            subcountySelect.appendChild(option);
    //        });
    //    }
    //});





}