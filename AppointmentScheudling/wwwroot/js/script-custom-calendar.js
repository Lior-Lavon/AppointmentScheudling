$(document).ready(function () { InitCalendar(); });


function InitCalendar() {
    try {
        $('#calendar').fullCalendar({
            timezone: false,
            header: {
                left: 'prev,next,today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            selectable: true,
            editable: false
        });
    } catch (ex) {
        alert(ex);
    }
}