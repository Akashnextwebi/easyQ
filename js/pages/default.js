$(document).ready(function () {
    $(document).on('click', '.hidenId', function () {
        var dataId = $(this).attr('data-id');
        $('#btnResourceDownload').attr('data-id', dataId);
    });
    $("#txtName, #txtPhone, #txtEmail").on("input", function () {
        $(this).next(".error-message").remove();
    });

    $(document.body).on("click", "#btnResourceDownload", function (e1) {
        e1.preventDefault();
        var elem = $(this);
        elem.prop("disabled", true).text("Downloading...");

        $(".error-message").remove();

        var id = $('#btnResourceDownload').attr('data-id');
        var name = $("#txtName").val().trim();
        var phone = $("#txtPhone").val().trim();
        var email = $("#txtEmail").val().trim();
        var org = $("#txtOrg").val().trim();
        var isValid = true;

        if (name === "") {
            $("#txtName").after('<span class="error-message text-danger">Name is required.</span>');
            isValid = false;
        }
        if (org === "") {
            $("#txtOrg").after('<span class="error-message text-danger">Organization Name is required.</span>');
            isValid = false;
        }
        if (phone === "") {
            $("#txtPhone").after('<span class="error-message text-danger">Phone number is required.</span>');
            isValid = false;
        } else if (!/^\d{10,15}$/.test(phone)) {
            $("#txtPhone").after('<span class="error-message text-danger">Enter a valid phone number.</span>');
            isValid = false;
        }

        if (email === "") {
            $("#txtEmail").after('<span class="error-message text-danger">Email is required.</span>');
            isValid = false;
        } else if (!/^[\w.-]+@[\w.-]+\.\w{2,}$/.test(email)) {
            $("#txtEmail").after('<span class="error-message text-danger">Enter a valid email address.</span>');
            isValid = false;
        }
        if (!isValid) {
            elem.prop("disabled", false).text("Download Now");
            return;
        }
        $.ajax({
            type: 'POST',
            url: 'Default.aspx/downloadResource',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            data: JSON.stringify({ name: name, phone: phone, email: email, id: id, org: org }),
            success: function (response) {
                var result = response.d;
                if (result.split('|')[0] == "Success ") {
                    Snackbar.show({ pos: 'top-right', text: 'Thank you! Your requested resource is being downloaded..', actionTextColor: '#fff', backgroundColor: '#008a3d' });
                    $(".error-message").remove();
                    elem.prop("disabled", false).text("Download Now");
                    $("#txtName, #txtPhone, #txtEmail, #txtOrg").val("");
                    $(".btn-close").click();
                    var pdf = "/" + result.split('|')[1].trim();
                    if (pdf) {
                        var a = document.createElement('a');
                        a.href = pdf;
                        a.download = '';
                        document.body.appendChild(a);
                        a.click();
                        document.body.removeChild(a);
                    }
                } else {
                    elem.prop("disabled", false).text("Download Now");
                    Snackbar.show({
                        pos: 'top-right', text: 'Oops...! There is some problem right now. Please try again later.', actionTextColor: '#fff', backgroundColor: '#ea1c1c'
                    });
                }
            },
            error: function () {
                elem.prop("disabled", false).text("Download Now");
                Snackbar.show({ pos: 'top-right', text: 'Something went wrong. Try again.', actionTextColor: '#fff', backgroundColor: '#ea1c1c' });
            },

        });
    });

});


