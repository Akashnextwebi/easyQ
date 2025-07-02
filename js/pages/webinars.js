$(document).ready(function () {
    BindAllWebinars();
    $(document.body).on('click', ".pPVClick", function () {
        var ele = $(this);
        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindAllWebinars();

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
        BindAllWebinars();

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
        BindAllWebinars();

    });

});
function BindAllWebinars() {


    var pno = "1";
    if ($(".pPagination a").hasClass("current")) {
        pno = $(".pPagination .current").attr('id').split('_')[1];
    }
    var dts = { pno: pno };
    $.ajax({
        type: 'POST',
        url: 'webinars.aspx/GetAllWebinars',
        data: JSON.stringify(dts),
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        async: false,
        success: function (res) {
            var webinars = res.d;
            var listings = "";
            var pLength = "";
            for (var i = 0; i < webinars.length; i++) {
                var img = "" + webinars[i].Image;
                pLength = webinars[0].TotalCount;

                listings += "<div class='video-guide-item'>";
                listings += "<div class='video-guide-image'>";
                listings += "<a href='" + webinars[i].YoutubeLink + "' class='popup-video' data-cursor-text='Play'>";
                listings += "<figure class='image-anime '>";
                listings += "<img src='/" + img + "' alt='" + webinars[i].Title + "' />";
                listings += "</figure>";
                listings += "</a>";
                listings += "</div>";
                listings += "<div class='video-guide-content'>";
                listings += "<div class='section-title'>";
                listings += "<h2 class='text-anime-style-2' data-cursor='-opaque'>" + webinars[i].Title + "</h2>";
                listings += "</div>";
                listings += "<p>" + webinars[i].ShortDesc + "</p>";
                listings += "<div class='video-guide-content-btn wow fadeInUp' data-wow-delay='0."+i*2+"s'>";
                listings += "<a  href='" + webinars[i].YoutubeLink + "' class='btn-default popup-video'>watch now</a>";
                listings += "</div>";
                listings += "</div>";
                listings += "</div>";

            }

            $("#WebinarListBindingSec").empty();
            if (webinars.length > 0) {
                $("#WebinarListBindingSec").append(listings);
                BindPPage(6, parseInt(pno), pLength);
                var maxHeight = Math.max.apply(null, $(".post-item .post__title a").map(function () {
                    return $(this).height();
                }).get());
                $(".post-item .post__title a").css("min-height", maxHeight);
                var maxHeight1 = Math.max.apply(null, $(".mainWebinarPage .post-item .post__body .post__desc").map(function () {
                    return $(this).height();
                }).get());
                $(".mainWebinarPage .post-item .post__body .post__desc").css("min-height", maxHeight1);
            }

        },
        error: function (err) {

            $("#WebinarListBindingSec").empty();

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

    //const topOffset = $("#WebinarListBindingSec").offset().top;
    //$(document).scrollTop(topOffset - 150);
}