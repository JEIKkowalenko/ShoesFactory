$(document).ready(function () {

    $('.updateSupply').click(function () {
        var x = $('tr').has(this).children().first().text();
        $.ajax({
            url: '/ShoesFactory/GetSupply',
            data: { id: x },
            dataType: "json",
            type: "GET",
            success: function (result) {
                $('input[name="Id"]').val(result.Id);
                $('input[name="Count"]').val(result.Count);
                $('input[name="Price"]').val(result.Price);
            }
        });
    });

    $('.updateMaterial').click(function () {
        var x = $('tr').has(this).children().first().text();
        $.ajax({
            url: '/ShoesFactory/GetMaterial',
            data: { id: x },
            dataType: "json",
            type: "GET",
            success: function (result) {
                $('input[name="Id"]').val(result.Id);
                $('input[name="Name"]').val(result.Name);
                $('input[name="Summary"]').val(result.Summary);
                $('input[name="Count"]').val(result.Count);
            }
        });
    });

    $('.deleteButton').click(function () {
        var x = $('tr').has(this).children().first().text();
        $('#deleteId').val(x);
    });

    $('#addButton').click(function () {
        $(':input', '#editForm')
            .not(':button, :submit, :reset, :hidden')
            .val('')
            .removeAttr('checked')
            .removeAttr('selected');
    });
}); 