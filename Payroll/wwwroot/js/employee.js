$(function () {
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

    $.getJSON("/Employee/GetTEU/", function (result) {
        var teu = $("#teu");
        $.each(JSON.parse(result), function () {
            teu.append($("<option />").val(this.id).text(this.value));
        });
    })
});
