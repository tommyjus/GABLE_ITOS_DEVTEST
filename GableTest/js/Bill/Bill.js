$(function () {
    getEmployee();
    getPosition();
    getBill();

});

function getEmployee() {
    $.ajax({
        type: 'GET',
        url: base_path + 'Employee/GetEmployeeList',
        async: false,
        success: function (data) {
            if (data) {
                createTableName(data);
                createTable(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function getPosition() {
    $.ajax({
        type: 'GET',
        url: base_path + 'Position/GetPositionList',
        async: false,
        success: function (data) {
            if (data) {
                createTablePo(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function getStat() {
    $.ajax({
        type: 'GET',
        url: base_path + 'Stat/GetStatList',
        async: false,
        success: function (data) {
            if (data) {
                createTable(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function getBill() {
    $.ajax({
        type: 'GET',
        url: base_path + 'Bill/GetBillList',
        async: false,
        success: function (data) {
            if (data) {
                createTable(data);
            } else {
                alert('fail');
            }
        },
        error: function (data) {
            alert('error');
        }
    });
}

function createTablePo(data) {
    if (data) {
        $('#myTabPo > tbody').empty();
        $.each(data, function () {
            var tr = "<tr>";

            tr = "<td>" + this.POSI_M_TEST_NAME + "</td>";
            ty = tr + "</tr>";

            $('#myTabPo > tbody:last').append(tr);
        });
    }
}

function createTableName(data) {
    if (data) {
        $('#myTabName > tbody').empty();
        $.each(data, function () {
            var tr = "<tr>";

            tr = "<td>" + this.EMP_T_TEST_NAME + this.EMP_T_TEST_SURNAME + "</td>";
            ty = tr + "</tr>";

            $('#myTabName > tbody:last').append(tr);
        });
    }
}



function createTable(data) {
    if (data) {
        $('#myTab > tbody').empty();
        $.each(data, function () {
            var tr = "<tr>";

            tr = tr + "<td>" + this.BILL_T_TEST_ID + "</td>";
            tr = tr + "<td>" + this.TYPE_M_TEST_NAME + "</td>";
            tr = tr + "<td>" + this.BILL_T_TES_VALUES + "</td>";
            tr = tr + "<td>" + this.STAT_M_TEST_NAME + "</td>";
            tr = tr + "<td>" + this.BILL_T_TEST_DATE + "</td>";
            ty = tr + "</tr>";

            $('#myTab > tbody:last').append(tr);

        });


    }
}

function populateSelect(selector, options) {
    $.each(options, function (i, p) {
        selector.append($('<option></option>').val(this.id).html(this.name));
    });
}

