$(function () {
    $('#dateActivated').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });

    $('#loanDateGranted').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });
    $('#loanDateStart').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });
    $("#usersTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        "ajax": {
            "url": "/Users/GetDetails",
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "userId", "name" : "User Id"},
            { "data": "userFname", "name": "First Name" },
            { "data": "userLname", "name": "Last Name" },
            { "data": "activated", "name": "Date Activated" },
            { "data": "status", "name": "Status" },
            { "data": "htmlButtons", "name" : ""}
        ]
    });

    var empId = $("#loanEmployeesId").val();
    var status = $("#filterBy").val();
    $("#loanTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        "ajax": {
            "url": "/Loans/GetDetails?empId=" + empId + "&status=" + status,
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "loanCode", "name": "Loan Code" },
            { "data": "loanDescr", "name": "Description" },
            { "data": "principal", "name": "Loan Principal" },
            { "data": "withInterest", "name": "Loan Amount" },
            { "data": "approvedDate", "name": "Date Approved" },
            { "data": "htmlButtons", "name": "" }
        ]
    });
});

//============================= Users =====================================//

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

function add_Users() {
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

//============================= Roles =====================================//
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
//============================= Roles =====================================//

//============================= Loans =====================================//

function loansFilterByEmployeeStatus(empId, status, baseURL) {
    if (status == '')
        window.location.href = baseURL + "?employeeId=" + empId + "&status=" + $('#filterBy').val();
    else if (empId == '')
        window.location.href = baseURL + "?employeeId=" + $('#loanEmployeesId').val() + "&status=" + status.value;
}

function selectedCompany(baseUrl) {
    var companyId = $("#loanCompanyCode").val();
    var companyName = $("#loanCompanyCode").text();
    location.href = baseUrl + "?companyId=" + companyId + "&companyName=" + companyName;
}

function clearTextBox_Loans() {
    $('#loanEmployeesEntry').val('');
    $('#loanEmployeesEntryId').val('');
    $('#loanId').val('');
    $('#loanType').val('');
    $('#loanPrincipal').val('');
    $('#loanAmount').val('');
    $('#loanTotalPayment').val('');
    $('#loanBalance').val('');
    $('#loanAmortization').val('');
    $('#loanDateGranted').val('');
    $('#loanDateStart').val('');
    $('#loanRemarks').val('');
    $('#loanHoldPayment').prop('checked', false);
    $('#loan1stPeriod').prop('checked', false);
    $('#loan2ndPeriod').prop('checked', false);
    $('#loanEmployeesEntry').prop("disabled", false);
}

function add_Loan() {
    
    var frequency = ($('#loan1stPeriod').is(':checked') ? '1' : '') + ($('#loan2ndPeriod').is(':checked') ? '2' : '');
    var loan = {
        EmployeeId: $("#loanEmployeesEntryId").val(),
        LoanCode: $('#loanType').val(),
        Principal: $('#loanPrincipal').val(),
        WithInterest: $('#loanAmount').val(),
        TotalPayments: $('#loanTotalPayment').val(),
        Balance: $('#loanBalance').val(),
        Amortization: $('#loanAmortization').val(),
        ApprovedDate: $('#loanDateGranted').val(),
        StartDate: $('#loanDateStart').val(),
        Remarks: $('#loanRemarks').val(),
        Hold: $('#loanHoldPayment').is(':checked') ? true : false,
        Frequency: frequency
    };

    $.ajax({
        url: "/Loans/Create",
        data: "loan=" + JSON.stringify(loan),
        type: "POST",
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#loanModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function show_Loan(loanId) {
    if ($("#loanEmployeesEntry").data('autocomplete')) {
        $("#loanEmployeesEntry").autocomplete("destroy");
    }
    $('#loanEmployeesEntry').prop("disabled", true);
    $('#loanId').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Loans/Details/?loanId=" + loanId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            $('#loanEmployeesEntry').val(data.Employee.FullName);
            $('#loanEmployeesEntryId').val(data.EmployeeId);
            $('#loanId').val(data.LoanId);
            $('#loanType').val(data.LoanCode.trim());
            $('#loanPrincipal').val(data.Principal);
            $('#loanAmount').val(data.WithInterest);
            $('#loanTotalPayment').val(data.TotalPayments);
            $('#loanBalance').val(data.Balance);
            $('#loanAmortization').val(data.Amortization);
            $('#loanDateGranted').val(data.ApprovedDate);
            $('#loanDateStart').val(data.StartDate);
            $('#loanRemarks').val(data.Remarks);
            $('#loanHoldPayment').prop('checked', data.Hold);
            switch (data.Frequency.trim()) {
                case '1':
                    $('#loan1stPeriod').prop('checked', true);
                    $('#loan2ndPeriod').prop('checked', false);
                    break;
                case '2':
                    $('#loan1stPeriod').prop('checked', false);
                    $('#loan2ndPeriod').prop('checked', true);
                    break;
                case '12':
                    $('#loan1stPeriod').prop('checked', true);
                    $('#loan2ndPeriod').prop('checked', true);
                    break;
            }
            $('#loanModal').modal('show');
            $('#updateLoan').show();
            $('#addLoan').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function update_Loan() {
    var frequency = ($('#loan1stPeriod').is(':checked') ? '1' : '') + ($('#loan2ndPeriod').is(':checked') ? '2' : '');
    var loan = {
        LoanId: $('#loanId').val(),
        LoanCode: $('#loanType').val(),
        Principal: $('#loanPrincipal').val(),
        WithInterest: $('#loanAmount').val(),
        TotalPayments: $('#loanTotalPayment').val(),
        Balance: $('#loanBalance').val(),
        Amortization: $('#loanAmortization').val(),
        ApprovedDate: $('#loanDateGranted').val(),
        StartDate: $('#loanDateStart').val(),
        Remarks: $('#loanRemarks').val(),
        Hold: $('#loanHoldPayment').is(':checked') ? true : false,
        Frequency: frequency
    };
    $.ajax({
        url: "/Loans/Edit",
        type: "POST",
        data: "loan=" + JSON.stringify(loan),
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#loanModal').modal('hide');
            clearTextBox_Loans();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function delete_Loan(loanId) {
    $.ajax({
        url: "/Loans/Delete",
        type: "POST",
        data: "LoanId=" + loanId,
        dataType: "json",
        success: function (result) {
            window.location.reload();
            $('#deleteLoanModal' + loanId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}


$.fn.pageMe = function (opts) {
    var $this = this,
        defaults = {
            perPage: 7,
            showPrevNext: false,
            hidePageNumbers: false
        },
        settings = $.extend(defaults, opts);

    var listElement = $this;
    var perPage = settings.perPage;
    var children = listElement.children();
    var pager = $('.pager');

    if (typeof settings.childSelector != "undefined") {
        children = listElement.find(settings.childSelector);
    }

    if (typeof settings.pagerSelector != "undefined") {
        pager = $(settings.pagerSelector);
    }

    var numItems = children.size();
    var numPages = Math.ceil(numItems / perPage);

    pager.data("curr", 0);

    if (settings.showPrevNext) {
        $('<li><a href="#" class="prev_link">«</a></li>').appendTo(pager);
    }

    var curr = 0;
    while (numPages > curr && (settings.hidePageNumbers == false)) {
        $('<li><a href="#" class="page_link">' + (curr + 1) + '</a></li>').appendTo(pager);
        curr++;
    }

    if (settings.showPrevNext) {
        $('<li><a href="#" class="next_link">»</a></li>').appendTo(pager);
    }

    pager.find('.page_link:first').addClass('active');
    pager.find('.prev_link').hide();
    if (numPages <= 1) {
        pager.find('.next_link').hide();
    }
    pager.children().eq(1).addClass("active");

    children.hide();
    children.slice(0, perPage).show();

    pager.find('li .page_link').click(function () {
        var clickedPage = $(this).html().valueOf() - 1;
        goTo(clickedPage, perPage);
        return false;
    });
    pager.find('li .prev_link').click(function () {
        previous();
        return false;
    });
    pager.find('li .next_link').click(function () {
        next();
        return false;
    });

    function previous() {
        var goToPage = parseInt(pager.data("curr")) - 1;
        goTo(goToPage);
    }

    function next() {
        goToPage = parseInt(pager.data("curr")) + 1;
        goTo(goToPage);
    }

    function goTo(page) {
        var startAt = page * perPage,
            endOn = startAt + perPage;

        children.css('display', 'none').slice(startAt, endOn).show();

        if (page >= 1) {
            pager.find('.prev_link').show();
        }
        else {
            pager.find('.prev_link').hide();
        }

        if (page < (numPages - 1)) {
            pager.find('.next_link').show();
        }
        else {
            pager.find('.next_link').hide();
        }

        pager.data("curr", page);
        pager.children().removeClass("active");
        pager.children().eq(page + 1).addClass("active");

    }
};

$(document).ready(function () {

    $("#loanEmployees").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Loans/GetEmployees",
                dataType: "json",
                contentType: 'application/json; charset=utf-8',
                data: {
                    term: request.term
                },
                success: function (data) {
                    response(JSON.parse(data).splice(0,10));
                }
            });
        },
        minLength: 2,
        select: function (event, ui) {
            //alert("Selected: " + ui.item.value + " aka " + ui.item.id);
            loansFilterByEmployeeStatus(ui.item.id, '', '/Loans/Index');
        }
    });

    $('#loanEmployeesEntry').on("keydown.autocomplete", function () {
        $("#loanEmployeesEntry").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "/Loans/GetEmployees",
                    dataType: "json",
                    contentType: 'application/json; charset=utf-8',
                    data: {
                        term: request.term
                    },
                    success: function (data) {
                        response(JSON.parse(data).splice(0, 10));
                    },
                    error: function (err) {
                        alert(err);
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {
                //alert("Selected: " + ui.item.value + " aka " + ui.item.id);
                $("#loanEmployeesEntryId").val(ui.item.id);
            }
        });
        $("#loanEmployeesEntry").autocomplete("option", "appendTo", "#loanModal");
    });

    //$('#myTable').pageMe({ pagerSelector: '#myPager', showPrevNext: true, hidePageNumbers: false, perPage: 10 });
});
//============================= Loans =====================================//