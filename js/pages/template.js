$(document).ready(function () {
    BindAllTemplates();

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
            url: 'template.aspx/downloadResource',
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


    $(document.body).on('click', ".pPVClick", function () {
        var ele = $(this);
        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindAllTemplates();

    });
    $(document.body).on('click', ".prPVClick", function () {


        var ele = $(this);
        var activeIndex = $(".pPagination li.active a").attr("id").split('_')[1];
        var currentIndex = ele.attr("id").split('_')[1];
        if (activeIndex == currentIndex) {
            $(".pPagination li a.dNonePrev").css("display", "none");
            return;
        }
        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindAllTemplates();

    });
    $(document.body).on('click', ".nxPVClick", function () {
        $(".pPagination li.dNonePrev").css("display", "flex");
        var ele = $(this);

        var currentIndex = ele.attr("id").split('_')[1];
        var activeIndex = $(".pPagination li.active a").attr("id").split('_')[1];

        if (currentIndex == activeIndex) {
            $(".pPagination li a.dNoneNext").css("display", "none");
            return;
        }

        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindAllTemplates();

    });

});


function BindAllTemplates() {


    var pno = "1";
    if ($(".pPagination a").hasClass("current")) {
        pno = $(".pPagination .current").attr('id').split('_')[1];
    }
    var dts = { pno: pno };
    $.ajax({
        type: 'POST',
        url: 'template.aspx/GetAllTemplates',
        data: JSON.stringify(dts),
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        async: false,
        success: function (res) {
            var templates = res.d;
            var listings = "";
            var pLength = "";
            for (var i = 0; i < templates.length; i++) {
                var img = "" + templates[i].Image;
                pLength = templates[0].TotalCount;

                listings += "<div class='col-lg-6'>";
                listings += "<div class='project-item wow fadeInUp' style='visibility: visible; animation-name: fadeInUp;'>";
                listings += "<div class='project-image'>";
                listings += "<a href='javascript:void(0);' data-cursor-text='View' contenteditable='false' style='cursor: pointer;'>";
                listings += "<figure class='image-anime'>";
                listings += "<img src=/" + img + " alt=" + templates[i].Template + " />";
                listings += "</figure>";
                listings += "</a>";
                listings += "</div>";
                listings += "<div class='project-content'>";
                listings += "<h3><a href='javascript:void(0);' contenteditable='false' style='cursor: pointer;'>" + templates[i].Template + "</a></h3>";
                listings += "<a href='javascript:void(0);' class='btn-default btn-highlighted mt-3 hidenId' data-id=" + templates[i].Id + " data-bs-toggle='modal' data-bs-target='#brochureModal'>Download <i class='fa-solid fa-download ms-2'></i></a>";
                listings += "</div>";
                listings += "</div>";
                listings += "</div>";

            }

            $("#TemplateListBindingSec").empty();
            if (templates.length > 0) {
                $("#TemplateListBindingSec").append(listings);
                BindPPage(6, parseInt(pno), pLength);
                var maxHeight = Math.max.apply(null, $(".post-item .post__title a").map(function () {
                    return $(this).height();
                }).get());
                $(".post-item .post__title a").css("min-height", maxHeight);
                var maxHeight1 = Math.max.apply(null, $(".mainTemplatePage .post-item .post__body .post__desc").map(function () {
                    return $(this).height();
                }).get());
                $(".mainTemplatePage .post-item .post__body .post__desc").css("min-height", maxHeight1);
            }

        },
        error: function (err) {

            $("#TemplateListBindingSec").empty();

        }
    });

};
function BindPPage(pageS, cPage, pCount) {
    var noOfPagesCreated = Math.ceil(parseFloat(pCount) / parseInt(pageS));

    $(".pPagination").empty();

    let pagesss = "";

    const groupSize = 5;
    const groupStart = Math.floor((cPage - 1) / groupSize) * groupSize + 1;
    const groupEnd = Math.min(groupStart + groupSize - 1, noOfPagesCreated);

    for (let i = groupStart; i <= groupEnd; i++) {
        const activeClass = i === parseInt(cPage) ? "active" : "";
        pagesss += `<li class="page-item ${activeClass}">
                        <a class="page-link pPVClick" href="javascript:void(0);" id="pno_${i}">${i}</a>
                    </li>`;
    }

    if (groupEnd < noOfPagesCreated) {
        pagesss += `<li class="page-item">
                        <a class="page-link pPVClick" href="javascript:void(0);" id="pno_${groupEnd + 1}">...</a>
                    </li>`;
        pagesss += `<li class="page-item">
                        <a class="page-link pPVClick LastIndex" href="javascript:void(0);" id="pno_${noOfPagesCreated}">${noOfPagesCreated}</a>
                    </li>`;
    }

    const prevPage = cPage > 1 ? cPage - 1 : 1;
    const nextPage = cPage < noOfPagesCreated ? cPage + 1 : noOfPagesCreated;

    const pgnPrev = `<li class="page-item ${cPage === 1 ? "disabled" : ""}">
                        <a class="page-link prPVClick" href="javascript:void(0);" id="pnon_${prevPage}" aria-label="Previous">
                            <i class="fa fa-angle-left"></i>
                        </a>
                    </li>`;

    const pgnNext = `<li class="page-item ${cPage === noOfPagesCreated ? "disabled" : ""}">
                        <a class="page-link nxPVClick" href="javascript:void(0);" id="pnon_${nextPage}" aria-label="Next">
                            <i class="fa fa-angle-right"></i>
                        </a>
                    </li>`;

    $(".pPagination").append(pgnPrev + pagesss + pgnNext);

    //const topOffset = $("#TemplateListBindingSec").offset().top;
    //$(document).scrollTop(topOffset - 150);
}