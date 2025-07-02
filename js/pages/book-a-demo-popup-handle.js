$(document).ready(function () {
    // Remove error messages on input
    $("#txtBDName, #txtBDPhone, #txtBDEmail, #txtBDOrg, #txtBDCountry").on("input", function () {
        $(this).next(".error-message").remove();
    });

    $(document.body).on("click", "#btnBookADemo", function (e) {
        e.preventDefault();

        var elem = $(this);
        elem.prop("disabled", true).html("Submitting...");

        $(".error-message").remove();

        // Get values
        var name = $("#txtBDName").val().trim();
        var phone = $("#txtBDPhone").val().trim();
        var email = $("#txtBDEmail").val().trim();
        var org = $("#txtBDOrg").val().trim();
        var country = $("#txtBDCountry").val().trim();

        var isValid = true;

        // Validation
        if (name === "") {
            $("#txtBDName").after('<span class="error-message text-danger">Name is required.</span>');
            isValid = false;
        }

        if (email === "") {
            $("#txtBDEmail").after('<span class="error-message text-danger">Email is required.</span>');
            isValid = false;
        } else if (!/^[\w.-]+@[\w.-]+\.\w{2,}$/.test(email)) {
            $("#txtBDEmail").after('<span class="error-message text-danger">Enter a valid email address.</span>');
            isValid = false;
        }

        if (phone === "") {
            $("#txtBDPhone").after('<span class="error-message text-danger">Phone number is required.</span>');
            isValid = false;
        } else if (!/^\d{10,15}$/.test(phone)) {
            $("#txtBDPhone").after('<span class="error-message text-danger">Enter a valid phone number (10–15 digits).</span>');
            isValid = false;
        }

        if (org === "") {
            $("#txtBDOrg").after('<span class="error-message text-danger">Organization name is required.</span>');
            isValid = false;
        }

        if (country === "") {
            $("#txtBDCountry").after('<span class="error-message text-danger">Country is required.</span>');
            isValid = false;
        }

        // If validation fails
        if (!isValid) {
            elem.prop("disabled", false).html('Submit Now <i class="fa-solid fa-arrow-right ms-2"></i>');
            return;
        }

        $.ajax({
            type: 'POST',
            url: 'default.aspx/SubmitBookADemo',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            data: JSON.stringify({
                name: name,
                phone: phone,
                email: email,
                org: org,
                country: country
            }),
            success: function (response) {
                var result = response.d;
                if (result === "Success") {
                    Snackbar.show({
                        pos: 'top-right',
                        text: 'Thank you! We will reach out to you soon.',
                        actionTextColor: '#fff',
                        backgroundColor: '#008a3d'
                    });
                    $("#txtBDName, #txtBDPhone, #txtBDEmail, #txtBDOrg, #txtBDCountry").val("");
                    $(".btn-close").click();
                } else {
                    Snackbar.show({
                        pos: 'top-right',
                        text: 'Oops... Something went wrong. Try again later.',
                        actionTextColor: '#fff',
                        backgroundColor: '#ea1c1c'
                    });
                }
                elem.prop("disabled", false).html('Submit Now <i class="fa-solid fa-arrow-right ms-2"></i>');
            },
            error: function () {
                Snackbar.show({
                    pos: 'top-right',
                    text: 'Error while submitting. Please try again.',
                    actionTextColor: '#fff',
                    backgroundColor: '#ea1c1c'
                });
                elem.prop("disabled", false).html('Submit Now <i class="fa-solid fa-arrow-right ms-2"></i>');
            }
        });
    });
});
