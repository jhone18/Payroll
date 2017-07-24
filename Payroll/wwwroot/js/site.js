// Write your Javascript code.
$(function () {
    $('#dateActivated').datetimepicker({
        format: 'mm/dd/yyyy',
        minView:2
    });
});

function clearTextBox() {
    $('#userId').val("");
    $('#firstName').val("");
    $('#lastName').val("");
    $('#dateActivated').val("");
    $('#status').val("");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    //$('#Name').css('border-color', 'lightgrey');
    //$('#Age').css('border-color', 'lightgrey');
    //$('#State').css('border-color', 'lightgrey');
    //$('#Country').css('border-color', 'lightgrey');
}

function Add() {
    var user = {
        UserId: $('#userId').val(),
        UserFname: $('#firstName').val(),
        UserLname: $('#lastName').val(),
        Activated: $('#dateActivated').val(),
        Status: $('#status').val(),
    };
    $.ajax({
        url: "/Users/Create",
        data: "user=" + JSON.stringify(user),
        type: "POST",
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#myModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function getbyID(userId) {
    $('#userId').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Users/Details/?userId=" + userId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            $('#userId').val(data.UserId);
            $('#firstName').val(data.UserFname);
            $('#lastName').val(data.UserLname);
            $('#dateActivated').val(data.Activated);
            $('#status').val(data.Status.trim());
            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function Update() {

    var user = {
        UserId: $('#userId').val(),
        UserFname: $('#firstName').val(),
        UserLname: $('#lastName').val(),
        Activated: $('#dateActivated').val(),
        Status: $('#status').val(),
    };
    alert(JSON.stringify(user));
    $.ajax({
        url: "/Users/Edit",
        type: "POST",
        data: "jsonData=" + JSON.stringify(user),
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#myModal').modal('hide');
            $('#userId').val("");
            $('#firstName').val("");
            $('#lastName').val("");
            $('#dateActivated').val("");
            $('#status').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function Delete(userId) {
    $.ajax({
        url: "/Users/Delete",
        type: "POST",
        data: "userId=" + userId,
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#deleteModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}