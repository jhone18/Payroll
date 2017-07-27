//============================= Users =====================================//
$(function () {
    $('#dateActivated').datetimepicker({
        format: 'mm/dd/yyyy',
        minView:2
    });
});

function clearTextBox_Users() {
    $('#userId').val("");
    $('#firstName').val("");
    $('#lastName').val("");
    $('#password').val("");
    $('#dateActivated').val("");
    $('#status').val("");
    $('#updateUser').hide();
    $('#addUser').show();
    //$('#Name').css('border-color', 'lightgrey');
    //$('#Age').css('border-color', 'lightgrey');
    //$('#State').css('border-color', 'lightgrey');
    //$('#Country').css('border-color', 'lightgrey');
}

function add_Users(){
    var user = {
        UserId: $('#userId').val(),
        UserFname: $('#firstName').val(),
        UserLname: $('#lastName').val(),
        Password: $('#password').val(),
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
            $('#userModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function show_Users(userId) {
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
            $('#password').val(data.Password);
            $('#dateActivated').val(data.Activated);
            $('#status').val(data.Status.trim());
            $('#userModal').modal('show');
            $('#updateUser').show();
            $('#addUser').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function update_Users() {

    var user = {
        UserId: $('#userId').val(),
        UserFname: $('#firstName').val(),
        UserLname: $('#lastName').val(),
        Password: $('#password').val(),
        Activated: $('#dateActivated').val(),
        Status: $('#status').val(),
    };
    $.ajax({
        url: "/Users/Edit",
        type: "POST",
        data: "jsonData=" + JSON.stringify(user),
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#userModal').modal('hide');
            $('#userId').val("");
            $('#firstName').val("");
            $('#lastName').val("");
            $('#password').val("");
            $('#dateActivated').val("");
            $('#status').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function delete_Users(userId) {
    $.ajax({
        url: "/Users/Delete",
        type: "POST",
        data: "userId=" + userId,
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#deleteUserModal' + userId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//============================= Users =====================================//

//============================= Users =====================================//
function clearTextBox_Roles() {
    $('#roleId').val("");
    $('#roleDescription').val("");
    $('#roleShortDescription').val("");
    $('#updateRole').hide();
    $('#addRole').show();
}

function add_Role() {
    var role = {
        Description: $('#roleDescription').val(),
        ShortDesc: $('#roleShortDescription').val()
    };
    $.ajax({
        url: "/Roles/Create",
        data: "role=" + JSON.stringify(role),
        type: "POST",
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#roleModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function show_Role(roleId) {
    $('#roleId').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Roles/Details/?roleId=" + roleId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            $('#roleId').val(data.RoleId);
            $('#roleDescription').val(data.Description);
            $('#roleShortDescription').val(data.ShortDesc);
            $('#roleModal').modal('show');
            $('#updateRole').show();
            $('#addRole').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function update_Role() {

    var role = {
        RoleId: $('#roleId').val(),
        Description: $('#roleDescription').val(),
        ShortDesc: $('#roleShortDescription').val()
    };
    $.ajax({
        url: "/Roles/Edit",
        type: "POST",
        data: "role=" + JSON.stringify(role),
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#roleModal').modal('hide');
            $('#roleId').val("");
            $('#roleDescription').val("");
            $('#roleShortDescription').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function delete_Role(roleId) {
    $.ajax({
        url: "/Roles/Delete",
        type: "POST",
        data: "roleId=" + roleId,
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#deleteUserModal' + roleId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//============================= Users =====================================//