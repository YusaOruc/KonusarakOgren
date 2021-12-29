

$("#submit-btn").on('click', function (event) {
    var request;
    let kontrol = 0;
    let ans;

    for (var i = 1; i < 5; i++) {
        ans = $('input[name="answer_' + i + '"]:checked');
        if (ans.val() === undefined) {
            kontrol += 1;
        }

    }

    if (kontrol < 4) {
        
        var $form = $('#form-exam');

        var $inputs = $form.find("input, select, button, textarea");



        let qids = "";
        $('.qids').each(function () {
            qids += $(this).val() + " ";
        });


        $inputs.prop("disabled", true);

        request = $.ajax({
            url: "/Validator/Index",
            type: "post",
            data: { responses: qids }
        });

        request.done(function (response, textStatus, jqXHR) {

            for (var i = 1; i < 5; i++) {
                ans = $('input[name="answer_' + i + '"]:checked');

                if (ans.val() === response[i - 1]) {
                    ans.parent().children('.answer-text').addClass('answer-success');
                } else {
                    ans.parent().children('.answer-text').addClass('answer-danger');
                }
            }
        });
    } else {
        alert('Lütfen en az bir soruyu cevaplayınız...');
    }
});