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

function PopulateEmployment() {
    $.getJSON("/Employee/GetEmploymentType/", function (result) {
        var employmentType = $("#employmentType");
        $.each(JSON.parse(result), function () {
            employmentType.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetRank/", function (result) {
        var employmentType = $("#rank");
        $.each(JSON.parse(result), function () {
            employmentType.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetEmploymentStatus/", function (result) {
        var employmentStatus = $("#employmentStatus");
        $.each(JSON.parse(result), function () {
            employmentStatus.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetDivision/", function (result) {
        var division = $("#division");
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
        $.each(JSON.parse(result), function () {
            costCenter.append($("<option />").val(this.id).text(this.value));
        });
    })
}

function PopulatePayroll() {
    $.getJSON("/Employee/GetPayCode/", function (result) {
        var payCode = $("#payCode");
        $.each(JSON.parse(result), function () {
            payCode.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetPayrollType/", function (result) {
        var payrollType = $("#payrollType");
        $.each(JSON.parse(result), function () {
            payrollType.append($("<option />").val(this.id).text(this.value));
        });
    })

    $.getJSON("/Employee/GetBank/", function (result) {
        var bank = $("#bank");
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

        var lastName = $("#employeeTable").DataTable().row(this).data().lastName;
        var firstName = $("#employeeTable").DataTable().row(this).data().firstName;
        $("#personalInfo").text("Personal Info : " + lastName + ", " + firstName);
        $("#employmentInfo").text("Employment Info : " + lastName + ", " + firstName);
        $("#payrollInfo").text("Payroll Info : " + lastName + ", " + firstName);
        $("#statutoryInfo").text("Statutory Info : " + lastName + ", " + firstName);
        $("#prevEmployersInfo").text("Previous Employers : " + lastName + ", " + firstName);
        $("#dependentsInfo").text("Dependents : " + lastName + ", " + firstName);

        $('#employeeTable tbody tr').removeAttr("style");
        $(this).css("background-color", "#deedf7");
        enableInputFields();
        loadActiveTab();
    });
}

function reloadEmployeeTable() {
    var empId = $("#employeeSearchTextId").val();
    var status = $("#employeeFilterBy").val();

    if (empId == '') {
        populateEmployeeTable("/Payroll/GetEmployees?status=" + $("#payrollFilterBy").val());
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