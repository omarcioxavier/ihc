$(document).ready(function () {
    $('.data-table').DataTable();
});
//$('.data-table').each(function () {
//    var attrTitle = $(this).attr('title');
//    var title = attrTitle === null ? document.title : attrTitle;

//    var oTable = $(this).dataTable({
//        dom: "B<'#colvis row'><'row'><'row'<'col-md-6'l><'col-md-6'f>r>tip",
//        destroy: true,
//        order: [0, 'desc'],
//        buttons: [
//            {
//                extend: 'colvis',
//                collectionLayout: 'fixed two-column',
//                text: 'Colunas'
//            },
//            {
//                extend: 'csvHtml5',
//                footer: true,
//                exportOptions: {
//                    columns: ':visible'
//                }
//            },
//            {
//                extend: 'excelHtml5',
//                footer: true,
//                title: title,
//                exportOptions: {
//                    columns: ':visible',
//                    format: {
//                        body: function (data) {
//                            data = $('<p>' + data + '</p>').text();
//                            return $.isNumeric(data.replace(',', '.')) ? data.replace(',', '.') : data;
//                        }
//                    }
//                }
//            },
//            {
//                extend: 'print',
//                text: 'Imprimir',
//                exportOptions: {
//                    columns: ':visible'
//                }
//            }]
//        ,
//        "lengthMenu": [
//            [10, 30, 50, 100, -1],
//            [10, 30, 50, 100, "Todos"]
//        ],
//        "language": {
//            url: '//cdn.datatables.net/plug-ins/1.10.19/i18n/Portuguese-Brasil.json',
//            decimal: ",",
//            thousands: ".",
//        },
//        "scrollX": "auto",
//        "fixedHeader": true
//    })
//});