//============================= Users =====================================//

$(function () {
    $('#dateActivated').datetimepicker({
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
            { "data": "userId", "name": "User Id" },
            { "data": "userFname", "name": "First Name" },
            { "data": "userLname", "name": "Last Name" },
            { "data": "activated", "name": "Date Activated" },
            { "data": "status", "name": "Status" },
            { "data": "htmlButtons", "name": "" }
        ]
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
            $("#usersTable").DataTable().ajax.reload();
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
            $("#usersTable").DataTable().ajax.reload();
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
            $("#usersTable").DataTable().ajax.reload();
            $('#deleteUserModal' + userId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//============================= Users =====================================//

//============================= Roles =====================================//

$(function () {
    $("#roleTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        "ajax": {
            "url": "/Roles/GetDetails",
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "roleId", "name": "Role Id" },
            { "data": "shortDesc", "name": "Description" },
            { "data": "htmlButtons", "name": "" }
        ]
    });
});

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
            $("#roleTable").DataTable().ajax.reload();
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
            $("#roleTable").DataTable().ajax.reload();
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
            $("#roleTable").DataTable().ajax.reload();
            $('#deleteUserModal' + roleId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//============================= Roles =====================================//

//============================= Loans =====================================//
$(document).ready(function () {
    $('#loanDateGranted').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });
    $('#loanDateStart').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });

    $("#loansFilterBy").change(function () {
        $("#loanEmployees").val("");
        $("#loanEmployeesId").val("");
        $("#newLoan").hide();
        $("#loanTable").DataTable().ajax.url("/Loans/GetDetails?empId=" + $("#loanEmployeesId").val() + "&status=" + $("#loansFilterBy").val()).load();
    });

    $("#loanEmployees").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Loans/GetEmployees?status=" + $("#loansFilterBy").val(),
                dataType: "json",
                contentType: 'application/json; charset=utf-8',
                data: {
                    term: request.term
                },
                success: function (data) {
                    response(JSON.parse(data).splice(0, 10));
                }
            });
        },
        minLength: 2,
        select: function (event, ui) {
            $("#newLoan").show();
            $("#loanEmployeesId").val(ui.item.id);
            $("#loanTable").DataTable().ajax.url("/Loans/GetDetails?empId=" + $("#loanEmployeesId").val() + "&status=" + $("#loansFilterBy").val()).load();
        }
    });
    $("#loanEmployees").focusout(function () {
        if ($(this).val() == '') {
            $("#loanTable").DataTable().ajax.url("/Loans/GetDetails?empId=" + $("#loanEmployeesId").val() + "&status=" + $("#loansFilterBy").val()).load();
            $("#newLoan").hide();
        }
    });

    $('#loanEmployeesEntry').on("keydown.autocomplete", function () {
        $("#loanEmployeesEntry").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "/Loans/GetEmployees?status=" + status,
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
                $("#loanEmployeesEntryId").val(ui.item.value);
            }
        });
        $("#loanEmployeesEntry").autocomplete("option", "appendTo", "#loanModal");
    });

    $("#loanTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        "ajax": {
            "url": "/Loans/GetDetails?empId=" + $("#loanEmployeesId").val() + "&status=" + $("#filterBy").val(),
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
    $("#addLoan").show();
    $("#updateLoan").hide();
}

function add_Loan() {

    var frequency = ($('#loan1stPeriod').is(':checked') ? '1' : '') + ($('#loan2ndPeriod').is(':checked') ? '2' : '');
    var loan = {
        EmployeeId: $("#loanEmployeesId").val(),
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
            $("#loanTable").DataTable().ajax.reload();
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
            $("#loanTable").DataTable().ajax.reload();
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
            $("#loanTable").DataTable().ajax.reload();
            $('#deleteLoanModal' + loanId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//============================= Loans =====================================//
//============================= Payroll =====================================//
$(document).ready(function () {
    $("#payrollSearchText").on("keydown.autocomplete", function () {

        var status = $("#payrollFilterBy").val();
        switch ($("#searchByType").val()) {
            case "Name":
                $("#payrollSearchText").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/Payroll/GetEmployees?status=" + status,
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            data: {
                                term: request.term
                            },
                            success: function (data) {
                                response(JSON.parse(data).splice(0, 10));
                            }
                        });
                    },
                    minLength: 2,
                    select: function (event, ui) {
                        //alert("Selected: " + ui.item.value + " aka " + ui.item.id);
                        //loansFilterByEmployeeStatus(ui.item.id, '', '/Payroll/Index');
                        $("#payrollSearchTextId").val(ui.item.id);
                    }
                });
                break;
            case "EmpID":
                $("#payrollSearchText").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/Payroll/GetEmployeesId?status=" + status,
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            data: {
                                term: request.term
                            },
                            success: function (data) {
                                response(JSON.parse(data).splice(0, 10));
                            }
                        });
                    },
                    minLength: 2,
                    select: function (event, ui) {
                        //alert("Selected: " + ui.item.value + " aka " + ui.item.id);
                        //loansFilterByEmployeeStatus(ui.item.id, '', '/Payroll/Index');
                        $("#payrollSearchTextId").val(ui.item.id);
                    }
                });
                break;
            case "PayCode":
                $("#payrollSearchText").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/Payroll/GetPayCode?status=" + status,
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            data: {
                                term: request.term
                            },
                            success: function (data) {
                                response(JSON.parse(data).splice(0, 10));
                            }
                        });
                    },
                    minLength: 2,
                    select: function (event, ui) {
                        //alert("Selected: " + ui.item.value + " aka " + ui.item.id);
                        //loansFilterByEmployeeStatus(ui.item.id, '', '/Payroll/Index');
                        $("#payrollSearchTextId").val(ui.item.id);
                    }
                });
                break;
            case "Department":
                $("#payrollSearchText").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/Payroll/GetDepartment?status=" + status,
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            data: {
                                term: request.term
                            },
                            success: function (data) {
                                response(JSON.parse(data).splice(0, 10));
                            }
                        });
                    },
                    minLength: 2,
                    select: function (event, ui) {
                        //alert("Selected: " + ui.item.value + " aka " + ui.item.id);
                        //loansFilterByEmployeeStatus(ui.item.id, '', '/Payroll/Index');
                        $("#payrollSearchTextId").val(ui.item.id);
                    }
                });
                break;
        }
    });

    $("#payrollSearchText").focusout(function () {
        if ($(this).val() == '') {
            $("#payrollSearchText").val("");
            $("#payrollSearchTextId").val("");
            $("#payrollTabs").tabs();
            $('#payrollTabs a[href="#timesheet"]').click();
            $("#payrollTabs").tabs("disable");
        }
    });

    $("#payrollFilterBy").change(function () {
        $("#payrollSearchText").val("");
        $("#payrollSearchTextId").val("");
        $("#payrollTabs").tabs();
        $('#payrollTabs a[href="#timesheet"]').click();
        $("#payrollTabs").tabs("disable");
    });

    $("#searchEmployee").click(function () {
        if ($("#payrollSearchTextId").val() != '') {
            $("#payrollTabs").tabs("destroy");
            $("#payrollTabs").tabs();
            $('#payrollTabs a[href="#timesheet"]').click();

            var empId = $("#payrollSearchTextId").val();
            var status = $("#payrollFilterBy").val();
            $("#incomeTable").DataTable().destroy();
            $("#incomeTable").dataTable({
                "processing": true, // for show progress bar
                "serverSide": true, // for process server side
                "filter": false, // this is for disable filter (search box)
                "ordering": false,
                lengthChange: false,
                "ajax": {
                    "url": "/Payroll/GetIncomeDetails?searchText=" + empId + "&status=" + status,
                    "type": "GET",
                    "contentType": 'application/json; charset=utf-8',
                    "datatype": "json"
                },
                "columns": [
                    { "data": "earnDescr", "name": "Description" },
                    { "data": "tranDate", "name": "Tran Date" },
                    { "data": "amount", "name": "Amount" },
                    { "data": "recurStart", "name": "Recur Start" },
                    { "data": "recurEnd", "name": "Recur End" },
                    { "data": "frequency", "name": "Frequency" },
                    { "data": "htmlButtons", "name": "" }
                ]
            });

            $("#deductionTable").DataTable().destroy();
            $("#deductionTable").dataTable({
                "processing": true, // for show progress bar
                "serverSide": true, // for process server side
                "filter": false, // this is for disable filter (search box)
                "ordering": false,
                lengthChange: false,
                "ajax": {
                    "url": "/Payroll/GetDeductionDetails?searchText=" + empId + "&status=" + status,
                    "type": "GET",
                    "contentType": 'application/json; charset=utf-8',
                    "datatype": "json"
                },
                "columns": [
                    { "data": "dedDescr", "name": "Description" },
                    { "data": "tranDate", "name": "Tran Date" },
                    { "data": "dedAmount", "name": "Amount" },
                    { "data": "recurStart", "name": "Recur Start" },
                    { "data": "recurEnd", "name": "Recur End" },
                    { "data": "frequency", "name": "Frequency" },
                    { "data": "htmlButtons", "name": "" }
                ]
            });
        }
        
    });

    $('#incomeTranDate').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });


    $('#incomeRecurStart').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });


    $('#incomeRecurEnd').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });

    $('#deductionTranDate').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });


    $('#deductionRecurStart').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });


    $('#deductionRecurEnd').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2
    });

    $("#searchByType").hide();
    $("#payrollTabs").tabs();
    $("#payrollTabs").tabs("disable");
});

function hidePayrollUpdate() {
    $("#updatePayroll").hide();
}

function showPayrollUpdate() {
    $("#updatePayroll").show();
}

function clearTextBox_PayrollIncome() {
    $("#incomeId").val("");
    $('#incomeDescription').val("");
    $('#incomeTranDate').val("");
    $('#incomeAmount').val("");
    $('#incomeRecurStart').val("");
    $('#incomeRecurEnd').val("");
    $('#incomeFrequency').val("");
    $('#updatePayrollIncome').hide();
    $('#addPayrollIncome').show();
    $('#income1stPeriod').prop('checked', false);
    $('#income2ndPeriod').prop('checked', false);
}

function clearTextBox_PayrollDeduction() {
    $("#deductionId").val("");
    $('#deductionDescription').val("");
    $('#deductionTranDate').val("");
    $('#deductionAmount').val("");
    $('#deductionRecurStart').val("");
    $('#deductionRecurEnd').val("");
    $('#deductionFrequency').val("");
    $('#updatePayrollDeduction').hide();
    $('#addPayrollDeduction').show();
    $('#deduction1stPeriod').prop('checked', false);
    $('#deduction2ndPeriod').prop('checked', false);
}

function add_PayrollIncome() {
    var frequency = ($('#income1stPeriod').is(':checked') ? '1' : '') + ($('#income2ndPeriod').is(':checked') ? '2' : '');
    var income = {
        EarnCode: $("#incomeDescription").val(),
        EmployeeId: $("#payrollSearchTextId").val(),
        TranDate: $('#incomeTranDate').val(),
        Amount: $('#incomeAmount').val(),
        RecurStart: $('#incomeRecurStart').val(),
        RecurEnd: $('#incomeRecurEnd').val(),
        Frequency: frequency
    };
    $.ajax({
        url: "/Payroll/CreateIncome",
        data: "income=" + JSON.stringify(income),
        type: "POST",
        dataType: "json",
        success: function (result) {
            $("#incomeTable").DataTable().ajax.reload();
            $('#incomeModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function add_PayrollDeduction() {
    var frequency = ($('#deduction1stPeriod').is(':checked') ? '1' : '') + ($('#deduction2ndPeriod').is(':checked') ? '2' : '');
    var deduction = {
        DedCode: $("#deductionDescription").val(),
        EmployeeId: $("#payrollSearchTextId").val(),
        TranDate: $('#deductionTranDate').val(),
        DedAmount: $('#deductionAmount').val(),
        RecurStart: $('#deductionRecurStart').val(),
        RecurEnd: $('#deductionRecurEnd').val(),
        Frequency: frequency
    };
    $.ajax({
        url: "/Payroll/CreateDeduction",
        data: "deduction=" + JSON.stringify(deduction),
        type: "POST",
        dataType: "json",
        success: function (result) {
            $("#deductionTable").DataTable().ajax.reload();
            $('#deductionModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function show_PayrollIncome(incomeId) {
    //$('#userId').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Payroll/DetailsIncome/?incomeId=" + incomeId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            $("#payrollSearchTextId").val(data.EmployeeId);
            $("#incomeId").val(data.EarningId);
            $("#incomeCode").val(data.EarnCode);
            $('#incomeDescription').val(data.EarnCode);
            $('#incomeTranDate').val(data.TranDate);
            $('#incomeAmount').val(data.Amount);
            $('#incomeRecurStart').val(data.RecurStart);
            $('#incomeRecurEnd').val(data.RecurEnd);
            switch (data.Frequency.trim()) {
                case '1':
                    $('#income1stPeriod').prop('checked', true);
                    $('#income2ndPeriod').prop('checked', false);
                    break;
                case '2':
                    $('#income1stPeriod').prop('checked', false);
                    $('#income2ndPeriod').prop('checked', true);
                    break;
                case '12':
                    $('#income1stPeriod').prop('checked', true);
                    $('#income2ndPeriod').prop('checked', true);
                    break;
            }
            $('#incomeModal').modal('show');
            $('#updatePayrollIncome').show();
            $('#addPayrollIncome').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function show_PayrollDeduction(deductionId) {
    //$('#userId').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Payroll/DetailsDeduction/?deductionId=" + deductionId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            $("#payrollSearchTextId").val(data.EmployeeId);
            $("#deductionId").val(data.DeductionId);
            $("#deductionCode").val(data.DedCode);
            $('#deductionDescription').val(data.DedCode);
            $('#deductionTranDate').val(data.TranDate);
            $('#deductionAmount').val(data.DedAmount);
            $('#deductionRecurStart').val(data.RecurStart);
            $('#deductionRecurEnd').val(data.RecurEnd);
            switch (data.Frequency.trim()) {
                case '1':
                    $('#deduction1stPeriod').prop('checked', true);
                    $('#deduction2ndPeriod').prop('checked', false);
                    break;
                case '2':
                    $('#deduction1stPeriod').prop('checked', false);
                    $('#deduction2ndPeriod').prop('checked', true);
                    break;
                case '12':
                    $('#deduction1stPeriod').prop('checked', true);
                    $('#deduction2ndPeriod').prop('checked', true);
                    break;
            }
            $('#deductionModal').modal('show');
            $('#updatePayrollDeduction').show();
            $('#addPayrollDeduction').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function update_PayrollIncome() {
    var frequency = ($('#income1stPeriod').is(':checked') ? '1' : '') + ($('#income2ndPeriod').is(':checked') ? '2' : '');
    var income = {
        EarningId: $("#incomeId").val(),
        EmployeeId: $("#payrollSearchTextId").val(),
        EarnCode: $("#incomeDescription").val(),
        TranDate: $('#incomeTranDate').val(),
        Amount: $('#incomeAmount').val(),
        RecurStart: $('#incomeRecurStart').val(),
        RecurEnd: $('#incomeRecurEnd').val(),
        Frequency: frequency
    };
    $.ajax({
        url: "/Payroll/EditIncome",
        type: "POST",
        data: "income=" + JSON.stringify(income),
        dataType: "json",
        success: function (result) {
            $("#incomeTable").DataTable().ajax.reload();
            $('#incomeModal').modal('hide');
            $('#incomeId').val("");
            //$('#incomeDescription').val("");
            $('#incomeTranDate').val("");
            $('#incomeAmount').val("");
            $('#incomeRecurStart').val("");
            $('#incomeRecurEnd').val("");
            $('#incomeFrequency').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function update_PayrollDeduction() {
    var frequency = ($('#deduction1stPeriod').is(':checked') ? '1' : '') + ($('#deduction2ndPeriod').is(':checked') ? '2' : '');
    var deduction = {
        DeductionId: $("#deductionId").val(),
        EmployeeId: $("#payrollSearchTextId").val(),
        DedCode: $("#deductionDescription").val(),
        TranDate: $('#deductionTranDate').val(),
        DedAmount: $('#deductionAmount').val(),
        RecurStart: $('#deductionRecurStart').val(),
        RecurEnd: $('#deductionRecurEnd').val(),
        Frequency: frequency
    };
    $.ajax({
        url: "/Payroll/EditDeduction",
        type: "POST",
        data: "deduction=" + JSON.stringify(deduction),
        dataType: "json",
        success: function (result) {
            $("#deductionTable").DataTable().ajax.reload();
            $('#deductionModal').modal('hide');
            $('#deductionId').val("");
            $('#deductionTranDate').val("");
            $('#deductionAmount').val("");
            $('#deductionRecurStart').val("");
            $('#deductionRecurEnd').val("");
            $('#deductionFrequency').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function delete_PayrollIncome(incomeId) {
    $.ajax({
        url: "/Payroll/DeleteIncome",
        type: "POST",
        data: "incomeId=" + incomeId,
        dataType: "json",
        success: function (result) {
            $("#incomeTable").DataTable().ajax.reload();
            $('#deleteIncomeModal' + incomeId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function delete_PayrollDeduction(deductionId) {
    $.ajax({
        url: "/Payroll/DeleteDeduction",
        type: "POST",
        data: "deductionId=" + deductionId,
        dataType: "json",
        success: function (result) {
            $("#deductionTable").DataTable().ajax.reload();
            $('#deleteDeductionModal' + deductionId).modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//============================= Payroll =====================================//