//============================= Users =====================================//

$(function () {
    $('#dateActivatedPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
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
            { "data": "activated", "name": "Date Activated", "render": function (d) { return moment(d).format("MM/DD/YYYY"); } },
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
        data: JSON.stringify(user),
        type: "POST",
        dataType: "json",
        contentType: 'application/json; charset=UTF-8',
        success: function (result) {
            $("#usersTable").DataTable().ajax.reload();
            $('#userModal').modal('hide');
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
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
            $('#dateActivated').val(moment(data.Activated).format("MM/DD/YYYY"));
            $('#status').val(data.Status.trim());
            $('#userModal').modal('show');
            $('#updateUser').show();
            $('#addUser').hide();
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
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
        "columnDefs": [
            { "targets": [0], "visible": false }
        ],
        "columns": [
            { "data": "roleId", "name": "Role Id" },
            { "data": "shortDesc", "name": "Short Description" },
            { "data": "description", "name": "Description" },
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
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
            $('#deleteRoleModal' + roleId).modal('hide');
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
}
//============================= Roles =====================================//

//============================= Loans =====================================//
$(document).ready(function () {
    $('#loanDateGrantedPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    });
    $('#loanDateStartPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
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

    $('#loanEmployeesEntry').off("keydown.autocomplete");
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
                        showMessage(err);
                    }
                });
            },
            minLength: 2,
            select: function (event, ui) {
                //showMessage("Selected: " + ui.item.value + " aka " + ui.item.id);
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
            { "data": "principal", "name": "Loan Principal", "render": $.fn.dataTable.render.number(',', '.', 2, '') },
            { "data": "withInterest", "name": "Loan Amount", "render": $.fn.dataTable.render.number(',', '.', 2, '') },
            { "data": "approvedDate", "name": "Date Approved", "render": function (d) { return moment(d).format("MM/DD/YYYY"); } },
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
            showMessage(errormessage.statusText);
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
            $('#loanDateGranted').val(moment(data.ApprovedDate).format("MM/DD/YYYY"));
            $('#loanDateStart').val(moment(data.StartDate).format("MM/DD/YYYY"));
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
        }
    });
}

//============================= Loans =====================================//
//============================= Payroll =====================================//
$(document).ready(function () {

    $('#timesheet :input').prop('disabled', true);
    $('#otSheet :input').prop('disabled', true);
    $('#updatePayroll').prop('disabled', true);
    $("#newPayrollIncome").prop('disabled', true);
    $("#newPayrollDeduction").prop('disabled', true);
    $("#payrollTabs").tabs();

    $("#payrollTabs").tabs({
        activate: function (event, ui) {
            var empId = $("#payrollSearchTextId").val();
            var status = $("#payrollFilterBy").val();
            switch (ui.newTab.index()) {
                case 0:
                    showTimeSheet(empId);
                    break;
                case 1:
                    showOTSheet(empId);
                    break;
                case 2:
                    populatePayrollIncome(empId, status);
                    break;
                case 3:
                    populatePayrollDeduction(empId, status)
                    break;
            }
        }
    });


    $("#payrollSearchText").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Payroll/GetEmployeesByName?status=" + $("#payrollFilterBy").val(),
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
            //showMessage("Selected: " + ui.item.value + " aka " + ui.item.id);
            //loansFilterByEmployeeStatus(ui.item.id, '', '/Payroll/Index');
            $("#payrollSearchTextId").val(ui.item.id);
        }
    });

    populateEmployeeTable("/Payroll/GetEmployees?status=" + $("#payrollFilterBy").val());
    selectDataTable();

    $("#searchByType").off("change");
    $("#searchByType").on("change", function () {

        var status = $("#payrollFilterBy").val();
        switch ($("#searchByType").val()) {
            case "Name":
                showSearchText();
                $("#payrollSearchText").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/Payroll/GetEmployeesByName?status=" + status,
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
                        $("#payrollSearchTextId").val(ui.item.id);
                    }
                });

                populateEmployeeTable("/Payroll/GetEmployees?status=" + status);
                selectDataTable();
                break;
            case "EmpID":
                showSearchText();
                $("#payrollSearchText").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/Payroll/GetEmployeesById?status=" + status,
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
                        $("#payrollSearchTextId").val(ui.item.id);
                    }
                });

                populateEmployeeTable("/Payroll/GetEmployees?status=" + status);
                selectDataTable();
                break;
            case "PayCode":
                showSearchList();
                $.getJSON("/Payroll/GetPayCode", function (result) {
                    var options = $("#payrollSearchList");
                    options.empty();
                    options.append($("<option />").val("").text("").prop("selected", true));
                    result = jQuery.parseJSON(result);
                    $.each(result, function (index, item) {
                        options.append($("<option />").val(item.id).text(item.value));
                    });
                });

                $("#payrollSearchList").off("change");
                $("#payrollSearchList").on("change", function () {
                    var payCode = $(this).val();
                    populateEmployeeTable("/Payroll/GetEmployeesByPayCode?payCode=" + payCode + "&status=" + status);
                    selectDataTable();
                });
                break;
            case "Department":
                showSearchList();
                $.getJSON("/Payroll/GetDepartment", function (result) {
                    var options = $("#payrollSearchList");
                    options.empty();
                    options.append($("<option />").val("").text("").prop("selected", true));
                    result = jQuery.parseJSON(result);
                    $.each(result, function (index, item) {
                        options.append($("<option />").val(item.id).text(item.value));
                    });
                });
                $("#payrollSearchList").off("change");
                $("#payrollSearchList").on("change", function () {
                    var departmentId = $(this).val();
                    populateEmployeeTable("/Payroll/GetEmployeesByDepartment?departmentId=" + departmentId + "&status=" + status);
                    selectDataTable();
                });
                break;
        }
    });

    $("#payrollSearchText").focusout(function () {
        if ($(this).val() == '') {
            $("#payrollSearchText").val("");
            $("#payrollSearchTextId").val("");
            reloadPayrollTable();
            disableInputFields();
        }
    });

    $("#payrollFilterBy").change(function () {
        $("#payrollSearchText").val("");
        $("#payrollSearchTextId").val("");
        reloadPayrollTable();
        disableInputFields();
    });


    $("#searchEmployee").click(function () {
        if ($("#payrollSearchTextId").val() != '') {
            enableInputFields();

            var empId = $("#payrollSearchTextId").val();
            var status = $("#payrollFilterBy").val();

            populateEmployeeTable("/Payroll/GetEmployeesID?employeeId=" + empId + "&status=" + status);
            selectDataTable();
            loadActiveTab();
        }

    });


    $('#incomeTranDatePicker').datetimepicker({
        format: 'mm/dd/yyyy',
        defaultDate: new Date(),
        minView: 2,
        autoclose: true
    }).on("change", function () {
        $("#incomeTranDate").focus();
        setTimeout(function () { $("#incomeAmount").focus(); }, 10);
    });


    $('#incomeRecurStartPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    }).on("change", function () {
        var incomeRecurStart = $('#incomeRecurStart').val();
        var incomeRecurEnd = $('#incomeRecurEnd').val();
        if (incomeRecurStart != '') {
            $("#incomeRecurStart").parent().removeClass("has-error");
            $('#incomeRecurStart').prop("title", "");
        }
    });


    $('#incomeRecurEndPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    }).on("change", function () {
        var incomeRecurStart = $('#incomeRecurStart').val();
        var incomeRecurEnd = $('#incomeRecurEnd').val();

        if (incomeRecurEnd != '') {
            $("#incomeRecurEnd").parent().removeClass("has-error");
            $('#incomeRecurEnd').prop("title", "");
        }
    });

    $('#deductionTranDatePicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    });


    $('#deductionRecurStartPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    }).on("change", function () {
        $("#deductionRecurStart").parent().removeClass("has-error");
        $('#deductionRecurStart').prop("title", "");
    });


    $('#deductionRecurEndPicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    }).on("change", function () {
        $("#deductionRecurEnd").parent().removeClass("has-error");
        $('#deductionRecurEnd').prop("title", "");
    });

    //$("#incomeForm").validate({
    //    rules: {
    //        incomeDescription: "required",
    //        incomeTranDate: "required",
    //        incomeAmount: "required"
    //    },
    //    messages: {
    //        incomeDescription: "Please select Description",
    //        incomeTranDate: "Please enter Tran Date",
    //        incomeAmount: "Please enter Amount",
    //    },
    //    errorElement: "em",
    //    errorPlacement: function (error, element) {
    //        // Add the `help-block` class to the error element
    //        error.addClass("help-block");

    //        if (element.prop("type") === "checkbox") {
    //            error.insertAfter(element.parent("label"));
    //        } else if (element.siblings(".input-group-addon").length > 0) {
    //            error.insertAfter(element.siblings(".input-group-addon"));
    //        } else {
    //            error.insertAfter(element);
    //        }
    //    },
    //    highlight: function (element, errorClass, validClass) {
    //        $(element).parents(".col-md-7").addClass("has-error").removeClass("has-success");
    //    },
    //    unhighlight: function (element, errorClass, validClass) {
    //        $(element).parents(".col-md-7").addClass("has-success").removeClass("has-error");
    //        //$(element).siblings(".input-group-addon").css("display", "inline-table");
    //    }
    //});
});

function populatePayrollIncome(empId, status) {
    $("#incomeTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        destroy: true,
        "ajax": {
            "url": "/Payroll/GetIncomeDetails?searchText=" + empId + "&status=" + status,
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "earnDescr", "name": "Description" },
            { "data": "tranDate", "name": "Tran Date", "render": function (d) { return moment(d).format("MM/DD/YYYY"); } },
            { "data": "amount", "name": "Amount", "render": $.fn.dataTable.render.number(',', '.', 2, '') },
            { "data": "recurStart", "name": "Recur Start", "render": function (d) { if (d == null) { return '' } else { return moment(d).format("MM/DD/YYYY"); } } },
            { "data": "recurEnd", "name": "Recur End", "render": function (d) { if (d == null) { return '' } else { return moment(d).format("MM/DD/YYYY"); } } },
            { "data": "frequency", "name": "Frequency" },
            { "data": "htmlButtons", "name": "" }
        ]
    });
}

function populatePayrollDeduction(empId, status) {
    $("#deductionTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        destroy: true,
        "ajax": {
            "url": "/Payroll/GetDeductionDetails?searchText=" + empId + "&status=" + status,
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "dedDescr", "name": "Description" },
            { "data": "tranDate", "name": "Tran Date", "render": function (d) { return moment(d).format("MM/DD/YYYY"); } },
            { "data": "dedAmount", "name": "Amount", "render": $.fn.dataTable.render.number(',', '.', 2, '') },
            { "data": "recurStart", "name": "Recur Start", "render": function (d) { if (d == null) { return '' } else { return moment(d).format("MM/DD/YYYY"); } } },
            { "data": "recurEnd", "name": "Recur End", "render": function (d) { if (d == null) { return '' } else { return moment(d).format("MM/DD/YYYY"); } } },
            { "data": "frequency", "name": "Frequency" },
            { "data": "htmlButtons", "name": "" }
        ]
    });
}

function populateEmployeeTable(url) {
    $("#employeeTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        destroy: true,
        "ajax": {
            "url": url,
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "employeeId", "name": "Employee Id" },
            { "data": "lastName", "name": "Last Name" },
            { "data": "firstName", "name": "First Name" }
        ],
        initComplete: function (settings, json) {
            if (json.recordsTotal > 0) {
                $('#employeeTable tbody tr:eq(0)').click();
            }
            else {
                disableInputFields();
            }
        }
    });
}

function selectDataTable() {
    $('#employeeTable').off('click', 'tbody tr');
    $('#employeeTable').on('click', 'tbody tr', function () {
        console.log('API row values : ', $("#employeeTable").DataTable().row(this).data());
        $("#payrollSearchTextId").val($("#employeeTable").DataTable().row(this).data().employeeId);

        $('#employeeTable tbody tr').removeAttr("style");
        $(this).css("background-color", "#deedf7");
        enableInputFields();
        loadActiveTab();
    });
}

function loadActiveTab() {
    var empId = $("#payrollSearchTextId").val();
    var status = $("#payrollFilterBy").val();

    var selected = $("#payrollTabs").tabs('option', 'active'); // => 0
    switch (selected) {
        case 0:
            showTimeSheet(empId);
            break;
        case 1:
            showOTSheet(empId);
            break;
        case 2:
            populatePayrollIncome(empId, status);
            break;
        case 3:
            populatePayrollDeduction(empId, status)
            break;
    }
}

function reloadPayrollTable() {
    var empId = $("#payrollSearchTextId").val();
    var status = $("#payrollFilterBy").val();

    if (empId == '') {
        populateEmployeeTable("/Payroll/GetEmployees?status=" + $("#payrollFilterBy").val());
        selectDataTable();
    }
    loadActiveTab();
}

function showSearchText() {
    $("#payrollSearchText").val("");
    $("#payrollSearchText").show();
    $("#payrollSearchList").hide()
    $("#searchEmployee").show();
}

function showSearchList() {
    $("#payrollSearchList").val("");
    $("#payrollSearchText").hide();
    $("#payrollSearchList").show()
    $("#searchEmployee").hide();
}

function disableInputFields() {
    $('#timesheet :input:not([type=hidden])').prop('disabled', true);
    $('#otSheet :input:not([type=hidden])').prop('disabled', true);
    $('#timesheet :input:not([type=hidden])').val("");
    $('#otSheet :input:not([type=hidden])').val("");
    $('#updatePayroll').prop('disabled', true);
    $('#newPayrollIncome').prop('disabled', true);
    $('#newPayrollDeduction').prop('disabled', true);
}

function enableInputFields() {
    $('#timesheet :input:not([type=hidden])').val("");
    $('#otSheet :input:not([type=hidden])').val("");
    $('#timesheet :input:not([type=hidden])').prop('disabled', false);
    $('#otSheet :input:not([type=hidden])').prop('disabled', false);
    $('#updatePayroll').prop('disabled', false);
    $('#newPayrollIncome').prop('disabled', false);
    $('#newPayrollDeduction').prop('disabled', false);
}

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
    $("#incomeRecurEnd").parent().removeClass("has-error");
    $('#incomeRecurEnd').prop("title", "");
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
    $("#deductionRecurEnd").parent().removeClass("has-error");
    $('#deductionRecurEnd').prop("title", "");
}

function validatePayrollIncome() {
    var incomeRecurStart = $('#incomeRecurStart').val();
    var incomeRecurEnd = $('#incomeRecurEnd').val();
    var isValid = true;

    if (incomeRecurStart != '' && incomeRecurEnd != '') {
        if (Date.parse(incomeRecurStart) > Date.parse(incomeRecurEnd)) {
            $('#incomeRecurEnd').parent().addClass("has-error").removeClass("has-success");
            $('#incomeRecurEnd').prop("title", "Recur Start Date should be greater than or equal to Recur End Date.");
            isValid = false;
        }
    }

    return isValid;
}

function validatePayrollDeduction() {
    var deductionRecurStart = $('#deductionRecurStart').val();
    var deductionRecurEnd = $('#deductionRecurEnd').val();
    var isValid = true;

    if (deductionRecurStart != '' && deductionRecurEnd != '') {
        if (Date.parse(deductionRecurStart) > Date.parse(deductionRecurEnd)) {
            $('#deductionRecurEnd').parent().addClass("has-error").removeClass("has-success");
            $('#deductionRecurEnd').prop("title", "Recur Start Date should be greater than or equal to Recur End Date.");
            isValid = false;
        }
    }

    return isValid;
}

function add_PayrollIncome() {
    if (!validatePayrollIncome()) { return false; }

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
            //showMessage(errormessage.statusText);
        }
    });
}

function add_PayrollDeduction() {
    if (!validatePayrollDeduction()) { return false; }

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
            //showMessage(errormessage.statusText);
        }
    });
}

function returnNullIfEmpty(data, out) {
    if (data == null) {
        return ""
    }
    else {
        return out;
    }
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
            $('#incomeTranDate').val(returnNullIfEmpty(data.TranDate, moment(data.TranDate).format("MM/DD/YYYY")));
            $('#incomeAmount').val(data.Amount);
            $('#incomeRecurStart').val(returnNullIfEmpty(data.RecurStart, moment(data.RecurStart).format("MM/DD/YYYY")));
            $('#incomeRecurEnd').val(returnNullIfEmpty(data.RecurEnd, moment(data.RecurEnd).format("MM/DD/YYYY")));
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
            $("#incomeRecurEnd").parent().removeClass("has-error");
            $('#incomeRecurEnd').prop("title", "");
            $('#incomeModal').modal('show');
            $('#updatePayrollIncome').show();
            $('#addPayrollIncome').hide();
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
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
            $('#deductionTranDate').val(returnNullIfEmpty(data.TranDate, moment(data.TranDate).format("MM/DD/YYYY")));
            $('#deductionAmount').val(data.DedAmount);
            $('#deductionRecurStart').val(returnNullIfEmpty(data.RecurStart, moment(data.RecurStart).format("MM/DD/YYYY")));
            $('#deductionRecurEnd').val(returnNullIfEmpty(data.RecurEnd, moment(data.RecurEnd).format("MM/DD/YYYY")));
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
            $("#deductionRecurEnd").parent().removeClass("has-error");
            $('#deductionRecurEnd').prop("title", "");
            $('#deductionModal').modal('show');
            $('#updatePayrollDeduction').show();
            $('#addPayrollDeduction').hide();
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
    return false;
}

function update_PayrollIncome() {
    if (!validatePayrollIncome()) { return false; }

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
            showMessage(errormessage.statusText);
        }
    });
}

function update_PayrollDeduction() {
    if (!validatePayrollDeduction()) { return false; }
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
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
            showMessage(errormessage.statusText);
        }
    });
}

function update_PayrollTimeSheet() {
    var timeSheet = [];
    $.ajax({
        url: "/Payroll/GetTimeSheetCodes",
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            data.forEach(function (item, index) {
                var ts = {
                    TsCode: $("#ts" + item.DisplayOrder + "Code").val(),
                    TsDays: $("#ts" + item.DisplayOrder + "Days").val(),
                    TsHrs: $("#ts" + item.DisplayOrder + "Hours").val(),
                    TsMins: $("#ts" + item.DisplayOrder + "Minutes").val()
                }
                timeSheet.push(ts);
            });
            $.ajax({
                url: "/Payroll/EditTimeSheet",
                type: "POST",
                data: "timeSheet=" + JSON.stringify(timeSheet) + "&employeeId=" + $("#payrollSearchTextId").val(),
                dataType: "json",
                success: function (result) {
                    if (result.success == true) {
                        showMessage("TimeSheet Successfully saved.");
                    }
                },
                error: function (errormessage) {
                    showMessage(errormessage.statusText);
                }
            });
        },
        error: function (err) {
            showMessage(err.statusText);
        }
    });
}

function showTimeSheet(employeeId) {
    $.ajax({
        url: "/Payroll/DetailsTimeSheet/?employeeId=" + employeeId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            data.forEach(function (item, index) {
                $("#ts" + item.Timesheet2Code.DisplayOrder + "Code").val(item.TsCode);
                $("#ts" + item.Timesheet2Code.DisplayOrder + "Days").val(item.TsDays);
                $("#ts" + item.Timesheet2Code.DisplayOrder + "Hours").val(item.TsHrs);
                $("#ts" + item.Timesheet2Code.DisplayOrder + "Minutes").val(item.TsMins);
            });
        },
        error: function (err) {
            showMessage(err.statusText);
        }
    });
}

function update_PayrollOTSheet() {
    var otSheet = [];
    $.ajax({
        url: "/Payroll/GetOTSheetCodes",
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            data.forEach(function (item, index) {
                var ts = {
                    Otcode: $("#ot" + item.DisplayOrder + "Code").val(),
                    Othours: $("#ot" + item.DisplayOrder + "First8").val(),
                    Ot8hours: $("#ot" + item.DisplayOrder + "ND1").val(),
                    Otndhours: $("#ot" + item.DisplayOrder + "Beyond8").val(),
                    Otnd2hours: $("#ot" + item.DisplayOrder + "ND2").val()
                }
                otSheet.push(ts);
            });
            $.ajax({
                url: "/Payroll/EditOTSheet",
                type: "POST",
                data: "otSheet=" + JSON.stringify(otSheet) + "&employeeId=" + $("#payrollSearchTextId").val(),
                dataType: "json",
                success: function (result) {
                    if (result.success == true) {
                        showMessage("OT Sheet Successfully saved.");
                    }
                },
                error: function (errormessage) {
                    showMessage(errormessage.statusText);
                }
            });
        },
        error: function (err) {
            showMessage(err.statusText);
        }
    });
}

function showOTSheet(employeeId) {
    $.ajax({
        url: "/Payroll/DetailsOTSheet/?employeeId=" + employeeId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            data.forEach(function (item, index) {
                $("#ot" + item.OtcodeNavigation.DisplayOrder + "First8").val(item.Othours);
                $("#ot" + item.OtcodeNavigation.DisplayOrder + "ND1").val(item.Otndhours);
                $("#ot" + item.OtcodeNavigation.DisplayOrder + "Beyond8").val(item.Ot8hours);
                $("#ot" + item.OtcodeNavigation.DisplayOrder + "ND2").val(item.Otnd2hours);
            });
        },
        error: function (err) {
            showMessage(err.statusText);
        }
    });
}

function showMessage(message) {
    $("#modalMessage").html("<h4>" + message + "</h4>");
    $("#messageModal").modal('show');
}
//============================= Payroll =====================================//