$(function () {
    $("#employeeTabs").tabs();
    $("#employeeTabs").tabs({
        activate: function (event, ui) {
            var empId = $("#employeeSearchTextId").val();
            var status = $("#employeeFilterBy").val();
            switch (ui.newTab.index()) {
                case 0:

                    break;
                case 1:
                    PopulateEmployment();
                    break;
                case 2:
                    PopulatePayroll();
                    break;
                case 3:
                    PopulateStatutory();
                    break;
                case 4:
                    break;
                case 5:
                    PopulateDependents();
                    break;
            }
        }
    });

    $("#employeeSearchText").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Payroll/GetEmployeesByName?status=" + $("#employeeFilterBy").val(),
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
            $("#employeeSearchTextId").val(ui.item.id);
        }
    });

    populateEmployeeTable("/Payroll/GetEmployees?status=" + $("#employeeFilterBy").val());
    selectDataTable();

    $("#searchByType").off("change");
    $("#searchByType").on("change", function () {

        var status = $("#employeeFilterBy").val();
        switch ($("#searchByType").val()) {
            case "Name":
                showSearchText();
                $("#employeeSearchText").autocomplete({
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
                        $("#employeeSearchTextId").val(ui.item.id);
                    }
                });

                populateEmployeeTable("/Payroll/GetEmployees?status=" + status);
                selectDataTable();
                break;
            case "EmpID":
                showSearchText();
                $("#employeeSearchText").autocomplete({
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
                        $("#employeeSearchTextId").val(ui.item.id);
                    }
                });

                populateEmployeeTable("/Payroll/GetEmployees?status=" + status);
                selectDataTable();
                break;
            case "PayCode":
                showSearchList();
                $.getJSON("/Payroll/GetPayCode", function (result) {
                    var options = $("#employeeSearchList");
                    options.empty();
                    options.append($("<option />").val("").text("").prop("selected", true));
                    result = jQuery.parseJSON(result);
                    $.each(result, function (index, item) {
                        options.append($("<option />").val(item.id).text(item.value));
                    });
                });

                $("#employeeSearchList").off("change");
                $("#employeeSearchList").on("change", function () {
                    var payCode = $(this).val();
                    populateEmployeeTable("/Payroll/GetEmployeesByPayCode?payCode=" + payCode + "&status=" + status);
                    selectDataTable();
                });
                break;
            case "Department":
                showSearchList();
                $.getJSON("/Payroll/GetDepartment", function (result) {
                    var options = $("#employeeSearchList");
                    options.empty();
                    options.append($("<option />").val("").text("").prop("selected", true));
                    result = jQuery.parseJSON(result);
                    $.each(result, function (index, item) {
                        options.append($("<option />").val(item.id).text(item.value));
                    });
                });
                $("#employeeSearchList").off("change");
                $("#employeeSearchList").on("change", function () {
                    var departmentId = $(this).val();
                    populateEmployeeTable("/Payroll/GetEmployeesByDepartment?departmentId=" + departmentId + "&status=" + status);
                    selectDataTable();
                });
                break;
        }
    });

    $("#employeeSearchText").focusout(function () {
        if ($(this).val() == '') {
            $("#employeeSearchText").val("");
            $("#employeeSearchTextId").val("");
            reloadEmployeeTable();
            disableInputFields();
        }
    });

    $("#employeeFilterBy").change(function () {
        $("#employeeSearchText").val("");
        $("#employeeSearchTextId").val("");
        reloadEmployeeTable();
        disableInputFields();
    });


    $("#searchEmployee").click(function () {
        if ($("#employeeSearchTextId").val() != '') {
            enableInputFields();

            var empId = $("#employeeSearchTextId").val();
            var status = $("#employeeFilterBy").val();

            populateEmployeeTable("/Payroll/GetEmployeesID?employeeId=" + empId + "&status=" + status);
            selectDataTable();
            //loadActiveTab();
        }

    });
});

function PopulatePersonal() {

}

function PopulateEmployment() {
    $.getJSON("/Employee/GetEmploymentType/", function (result) {
        var employmentType = $("#employmentType");
        employmentType.empty();
        $.each(JSON.parse(result), function () {
            employmentType.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetRank/", function (result) {
        var rank = $("#rank");
        rank.empty();
        $.each(JSON.parse(result), function () {
            rank.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetEmploymentStatus/", function (result) {
        var employmentStatus = $("#employmentStatus");
        employmentStatus.empty();
        $.each(JSON.parse(result), function () {
            employmentStatus.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetDivision/", function (result) {
        var division = $("#division");
        division.empty();
        $.each(JSON.parse(result), function () {
            division.append($("<option />").val(this.id).text(this.value));
            $("#division").trigger("change");
        });
    })

    $("#division").change(function () {
        $.getJSON("/Employee/GetDepartment?division=" + $("#division").val(), function (result) {
            var department = $("#department");
            department.empty();
            $.each(JSON.parse(result), function () {
                department.append($("<option />").val(this.id).text(this.value));
                $("#department").trigger("change");
            });
        })
    });

    $("#department").change(function () {
        $.getJSON("/Employee/GetSection?department=" + $("#department").val(), function (result) {
            var section = $("#section");
            section.empty();
            $.each(JSON.parse(result), function () {
                section.append($("<option />").val(this.id).text(this.value));
            });
        })
    });

    $.getJSON("/Employee/GetCostCenter/", function (result) {
        var costCenter = $("#costCenter");
        costCenter.empty();
        $.each(JSON.parse(result), function () {
            costCenter.append($("<option />").val(this.id).text(this.value));
        });
    })
}

function PopulatePayroll() {
    $.getJSON("/Employee/GetPayCode/", function (result) {
        var payCode = $("#payCode");
        payCode.empty();
        $.each(JSON.parse(result), function () {
            payCode.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetPayrollType/", function (result) {
        var payrollType = $("#payrollType");
        payrollType.empty();
        $.each(JSON.parse(result), function () {
            payrollType.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetBank/", function (result) {
        var bank = $("#bank");
        bank.empty();
        $.each(JSON.parse(result), function () {
            bank.append($("<option />").val(this.id).text(this.value));
            $("#bank").trigger("change");
        });
    })

    $("#bank").change(function () {
        $.getJSON("/Employee/GetBankBranch?bankCode=" + $("#bank").val(), function (result) {
            var bankBranch = $("#bankBranch");
            bankBranch.empty();
            $.each(JSON.parse(result), function () {
                bankBranch.append($("<option />").val(this.id).text(this.value));
            });
        })
    })
}

function PopulateStatutory() {
    $.getJSON("/Employee/GetTEU/", function (result) {
        var teu = $("#teu");
        teu.empty();
        $.each(JSON.parse(result), function () {
            teu.append($("<option />").val(this.id).text(this.value));
        });
    })
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
        $("#employeeSearchTextId").val($("#employeeTable").DataTable().row(this).data().employeeId);



        $('#employeeTable tbody tr').removeAttr("style");
        $(this).css("background-color", "#deedf7");
        enableInputFields();
        loadActiveTab();
        getEmployeeDetails();
    });
}

function getEmployeeDetails() {
    var empId = $("#employeeSearchTextId").val();
    $.getJSON("/Employee/GetEmploymentDetails?empId=" + empId, function (result) {
        result = jQuery.parseJSON(result)[0];

        var lastName = result.EmployeeId;
        var firstName = result.FirstName;
        var middleName = result.MiddleName;
        $("#personalInfo").text("Personal Info : " + lastName + ", " + firstName + " " + middleName);
        $("#employmentInfo").text("Employment Info : " + lastName + ", " + firstName + " " + middleName);
        $("#payrollInfo").text("Payroll Info : " + lastName + ", " + firstName + " " + middleName);
        $("#statutoryInfo").text("Statutory Info : " + lastName + ", " + firstName + " " + middleName);
        $("#prevEmployersInfo").text("Previous Employers : " + lastName + ", " + firstName + " " + middleName);
        $("#dependentsInfo").text("Dependents : " + lastName + ", " + firstName + " " + middleName);

        $("#employeeId").val(result.EmployeeId);
        $("#lastName").val(result.LastName);
        $("#firstName").val(result.FirstName);
        $("#middleName").val(result.MiddleName);
        $("#birthDate").val(result.BirthDate);
        $("#gender").val(result.Gender);
        $("#address").val(result.Address);

        $("#employmentType").val(result.EmploymentType);
        $("#position").val(result.Position);
        $("#rank").val(result.Rank);
        $("#employmentStatus").val(result.EmployeeStatus);
        $("#dateEmployed").val(result.DateEmployed);
        $("#dateRegularized").val(result.DateRegularized);
        $("#lastWorkedDate").val(result.LastWorkDate);
        $("#dateTerminated").val(result.DateTerminated);
        $("#division").val(result.Division);
        $("#department").val(result.Department);
        $("#section").val(result.Section);
        $("#costCenter").val(result.CostCenter);

        $("#payCode").val(result.PayCode);
        $("#payrollType").val(result.PayrollType);
        $("#computeAsDaily").val(result.ComputeAsDaily ? 1 : 0);
        $("#paymentType").val(result.PaymentType.trim());
        $("#bank").val(result.BankCode);
        $("#bankBranch").val(result.BranchId);
        $("#bankAcctNo").val(result.BankAcctNo);
        $("#allowedOT").val(result.AllowedOt ? 1 : 0);
        $("#salary").val(result.Salary);

        $("#sssNo").val(result.Sssnumber);
        $("#sssExempted").val(result.ZeroSss ? 1 : 0);
        $("#philhealthNo").val(result.PhilhealthNumber);
        $("#philhealthExempted").val(result.ZeroPh ? 1 : 0);
        $("#pagibigNo").val(result.PagibigNumber);
        $("#pagibigAddtl").val(result.AdditionalHdmf);
        $("#pagibigRate").val(result.TwoPercentRate ? 1 : 0);
        $("#pagibigExempted").val(result.ZeroHdmf ? 1 : 0);
        $("#tinNo").val(result.Tin);
        $("#teu").val(result.Teu);
        $("#taxRate").val(result.TaxRate);
        $("#taxExempted").val(result.ZeroTax ? 1 : 0);
    })
    $.getJSON("/Employee/GetPayrollDetails?empId=" + empId, function (result) {
        result = jQuery.parseJSON(result);
        if (result.length > 0) {
            result = result[0];
            $("#dailyRate").val(result.DailyRate);
            $("#hourlyRate").val(result.HourlyRate);
            //$("#minuteRate").val(result.MinuteRate);
        }
    })

}

function reloadEmployeeTable() {
    var empId = $("#employeeSearchTextId").val();
    var status = $("#employeeFilterBy").val();

    if (empId == '') {
        populateEmployeeTable("/Payroll/GetEmployees?status=" + $("#employeeFilterBy").val());
        selectDataTable();
    }
    loadActiveTab();
}

function loadActiveTab() {
    var empId = $("#employeeSearchTextId").val();
    var status = $("#employeeFilterBy").val();

    var selected = $("#employeeTabs").tabs('option', 'active'); // => 0
    switch (selected) {
        case 0:

            break;
        case 1:
            PopulateEmployment();
            break;
        case 2:
            PopulatePayroll();
            break;
        case 3:
            PopulateStatutory();
            break;
        case 4:
            break;
        case 5:
            PopulateDependents();
            break;
    }
}

function showSearchText() {
    $("#employeeSearchText").val("");
    $("#employeeSearchText").show();
    $("#employeeSearchList").hide()
    $("#searchEmployee").show();
}

function showSearchList() {
    $("#employeeSearchList").val("");
    $("#employeeSearchText").hide();
    $("#employeeSearchList").show()
    $("#searchEmployee").hide();
}

function disableInputFields() { }

function enableInputFields() { }

function ShowEmploymentSave() {
    $("#employmentEdit").hide();
    $("#employmentSave").show();
}

function ShowEmploymentEdit() {
    $("#employmentSave").hide();
    $("#employmentEdit").show();
}

function ShowEmploymentTypeSave() {
    $("#employmentTypeEdit").hide();
    $("#employmentTypeSave").show();
}

function ShowEmploymentTypeEdit() {
    $("#employmentTypeSave").hide();
    $("#employmentTypeEdit").show();
}

function ShowEmploymentStatusSave() {
    $("#employmentStatusEdit").hide();
    $("#employmentStatusSave").show();
}

function ShowEmploymentStatusEdit() {
    $("#employmentStatusSave").hide();
    $("#employmentStatusEdit").show();
}

function ShowDivisionSave() {
    $("#divisionEdit").hide();
    $("#divisionSave").show();
}

function ShowDivisionEdit() {
    $("#divisionSave").hide();
    $("#divisionEdit").show();
}

function ShowPayCodeSave() {
    $("#payCodeEdit").hide();
    $("#payCodeSave").show();
}

function ShowPayCodeEdit() {
    $("#payCodeSave").hide();
    $("#payCodeEdit").show();
}

function ShowComputeDailySave() {
    $("#computeDailyEdit").hide();
    $("#computeDailySave").show();
}

function ShowComputeDailyEdit() {
    $("#computeDailySave").hide();
    $("#computeDailyEdit").show();
}

function ShowPaymentTypeSave() {
    $("#paymentTypeEdit").hide();
    $("#paymentTypeSave").show();
}

function ShowPaymentTypeEdit() {
    $("#paymentTypeSave").hide();
    $("#paymentTypeEdit").show();
}

function ShowAllowOTSave() {
    $("#allowOTEdit").hide();
    $("#allowOTSave").show();
}

function ShowAllowOTEdit() {
    $("#allowOTSave").hide();
    $("#allowOTEdit").show();
}

function ShowSalarySave() {
    $("#salaryEdit").hide();
    $("#salarySave").show();
}

function ShowSalaryEdit() {
    $("#salarySave").hide();
    $("#salaryEdit").show();
}

function ShowSSSSave() {
    $("#sssEdit").hide();
    $("#sssSave").show();
}

function ShowSSSEdit() {
    $("#sssSave").hide();
    $("#sssEdit").show();
}

function ShowPhilhealthSave() {
    $("#philhealthEdit").hide();
    $("#philhealthSave").show();
}

function ShowPhilhealthEdit() {
    $("#philhealthSave").hide();
    $("#philhealthEdit").show();
}

function ShowPagibigSave() {
    $("#pagibigEdit").hide();
    $("#pagibigSave").show();
}

function ShowPagibigEdit() {
    $("#pagibigSave").hide();
    $("#pagibigEdit").show();
}

function ShowTINSave() {
    $("#tinEdit").hide();
    $("#tinSave").show();
}

function ShowTINEdit() {
    $("#tinSave").hide();
    $("#tinEdit").show();
}
//==========================  Personal ==================================//
$(function () {
    $('#birthDatePicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    });
});

function update_Personal() {

    var employee = {
        EmployeeId: $("#employeeId").val(),
        LastName: $("#lastName").val(),
        FirstName: $('#firstName').val(),
        MiddleName: $('#middleName').val(),
        Gender: $('#gender').val(),
        BirthDate: $('#birthDate').val(),
        Address: $('#address').val()
    };
    $.ajax({
        url: "/Employee/UpdateEmployeePersonal",
        type: "POST",
        data: "employee=" + JSON.stringify(employee),
        dataType: "json",
        success: function (result) {
            ShowEmploymentEdit();
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
}
//==========================  Personal ==================================//

//==========================  Dependents ==================================//
$(function () {
    $('#birthDependentsDatePicker').datetimepicker({
        format: 'mm/dd/yyyy',
        minView: 2,
        autoclose: true
    });
});

function PopulateDependents() {
    $("#dependentsTable").dataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": false, // this is for disable filter (search box)
        "ordering": false,
        lengthChange: false,
        destroy: true,
        "ajax": {
            "url": "/Employee/GetDependentsDetail?employeeId=" + $("#employeeSearchTextId").val(),
            "type": "GET",
            "contentType": 'application/json; charset=utf-8',
            "datatype": "json"
        },
        "columns": [
            { "data": "dependentName", "name": "Dependent Name" },
            { "data": "birthDate", "name": "Birth Date", "render": function (d) { return moment(d).format("MM/DD/YYYY"); } },
            { "data": "htmlButtons", "name": "" }
        ]
    });
}

function clearTextBox_Dependents() {
    $('#dependentsId').val("");
    $('#dependentsName').val("");
    $('#dependentsBirthDate').val("");
    $('#updateDependents').hide();
    $('#addDependents').show();
}

function add_Dependents() {
    var dependents = {
        CompanyID: "<company>",
        EmployeeID: $("#employeeSearchTextId").val(),
        DependentName: $('#dependentsName').val(),
        BirthDate: $('#dependentsBirthDate').val()
    };
    $.ajax({
        url: "/Employee/CreateDependents",
        data: "dependents=" + JSON.stringify(dependents),
        type: "POST",
        dataType: "json",
        success: function (result) {
            $("#dependentsTable").DataTable().ajax.reload();
            $('#dependentsModal').modal('hide');
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
}

function show_Dependents(dependentsId) {
    $.ajax({
        url: "/Employee/DetailsDependents?dependentsId=" + dependentsId,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var data = jQuery.parseJSON(result);
            $('#dependentsId').val(data.RowId);
            $('#dependentsName').val(data.DependentName);
            $('#dependentsBirthDate').val(moment(data.BirthDate).format("MM/DD/YYYY"));
            $('#dependentsModal').modal('show');
            $('#updateDependents').show();
            $('#addDependents').hide();
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
    return false;
}

function update_Dependents() {

    var dependents = {
        RowId: $("#dependentsId").val(),
        CompanyID: "<company>",
        EmployeeID: $("#employeeSearchTextId").val(),
        DependentName: $('#dependentsName').val(),
        BirthDate: $('#dependentsBirthDate').val()
    };
    $.ajax({
        url: "/Employee/EditDependents",
        type: "POST",
        data: "dependents=" + JSON.stringify(dependents),
        dataType: "json",
        success: function (result) {
            $("#dependentsTable").DataTable().ajax.reload();
            $('#dependentsModal').modal('hide');
            $('#dependentsId').val("");
            $('#dependentsName').val("");
            $('#dependentsBirthDate').val("");
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
}

function delete_Dependents(dependentsId) {
    $.ajax({
        url: "/Employee/DeleteDependents",
        type: "POST",
        data: "dependentsId=" + dependentsId,
        dataType: "json",
        success: function (result) {
            $("#dependentsTable").DataTable().ajax.reload();
            $('#deleteDependentsModal' + dependentsId).modal('hide');
        },
        error: function (errormessage) {
            showMessage(errormessage.statusText);
        }
    });
}
//==========================  Dependents ==================================//