// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    var urlAddress = window.location.host;
    $('#createTableLink').click(function () {
        window.open("https://localhost:44346/SuperUser/SudoCreateTable");
    });


    var urlAddressForDataSource = "https://" + urlAddress + "/DataAccess/GetTables";
    $.ajax(
        { 
            url: urlAddressForDataSource, success: function (result) {
                generateDataSourceDdl(result);
            }
        })

    function generateDataSourceDdl(result) {
        var html = "";
        for (var i = 0; i < result.length; i++) {
            html = html + '<button class="dropdown-item dataSourceItem" type="button" onclick="SetDataSource(event)">' + result[i] + '</button>';
        }
        $("#dataSourceDdl").append(html);
    }
});

function SetDataSource(event) {

    var dataSource = event.target.innerHTML;
    document.getElementById("dataSource").innerHTML = dataSource;
    var pathName = document.location.pathname;
    if (pathName == "/")
    {
        document.getElementById("mainTableAddData").hidden = "";
        document.getElementById("mainTableAddData").innerHTML = "Add " + document.getElementById("dataSource").innerHTML;
    }

}