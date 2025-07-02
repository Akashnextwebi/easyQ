<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="webinars.aspx.cs" Inherits="webinars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-header" style="background-image: url(imgs/resource/webinar.png)">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Page Header Box Start -->
                    <div class="page-header-box text-start">
                        <h1 class="text-anime-style-2 text-start">Webinars</h1>
                        <nav class="wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                            <ul class="breadcrumb ">
                                <li class="breadcrumb-item"><a href="#" class="text-white" contenteditable="false" style="cursor: pointer;">Home</a></li>
                                <li class="breadcrumb-item active text-white" aria-current="page">Webinars</li>
                            </ul>
                        </nav>
                    </div>
                    <!-- Page Header Box End -->
                </div>
            </div>
        </div>
    </div>
    <div class="page-video-guide">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Video Guide Box Start -->
                    <div class="video-guide-box" id="WebinarListBindingSec">

                        <%--<!-- Video Guide Item Start -->
                        <div class="video-guide-item">
                            <!-- Video Guide Image Start -->
                            <div class="video-guide-image">
                                <a href="https://www.youtube.com/watch?v=qk7ruvaTRkY" class="popup-video" data-cursor-text="Play">
                                    <figure class="image-anime reveal">
                                        <img src="imgs/resource/v1.png" alt="">
                                    </figure>
                                </a>
                            </div>
                            <!-- Video Guide Image End -->

                            <!-- Video Guide Content Start -->
                            <div class="video-guide-content">
                                <!-- Section Title Start -->
                                <div class="section-title">
                                    <h2 class="text-anime-style-2" data-cursor="-opaque">Challenges in the CE Marking Process | Regulatory Compliance for Medical Devices
</h2>
                                </div>
                                <!-- Section Title End -->

                               <p>Navigating the complexities of CE Marking can be daunting, but we’re here to help!</p>

                                <div class="video-guide-content-btn wow fadeInUp" data-wow-delay="0.4s">
                                    <a href="https://www.youtube.com/watch?v=qk7ruvaTRkY" class="btn-default popup-video">watch now</a>
                                </div>
                            </div>
                            <!-- Video Guide Content End -->
                        </div>
                        <!-- Video Guide Item End -->

                        <!-- Video Guide Item Start -->
                        <div class="video-guide-item">
                            <!-- Video Guide Image Start -->
                            <div class="video-guide-image">
                                <a href="https://www.youtube.com/watch?v=nBXVDQxmQlM" class="popup-video" data-cursor-text="Play">
                                    <figure class="image-anime reveal">
                                        <img src="imgs/resource/v2.png" alt="">
                                    </figure>
                                </a>
                            </div>
                            <!-- Video Guide Image End -->

                            <!-- Video Guide Content Start -->
                            <div class="video-guide-content">
                                <!-- Section Title Start -->
                                <div class="section-title">
                                    <h2 class="text-anime-style-2" data-cursor="-opaque">QMS & REGULATORY COMPLIANCE for MEDICAL DEVICES</h2>
                                </div>
                                <!-- Section Title End -->
<p>“QMS & Regulatory Compliance for Medical Devices: Are They Dependent or Independent?”<br>
The full recording is now available here!</p>

                                <div class="video-guide-content-btn wow fadeInUp" data-wow-delay="0.4s">
                                    <a href="https://www.youtube.com/watch?v=nBXVDQxmQlM" class="btn-default popup-video">watch now</a>
                                </div>
                            </div>
                            <!-- Video Guide Content End -->
                        </div>
                        <!-- Video Guide Item End -->

                        <!-- Video Guide Item Start -->
                        <div class="video-guide-item">
                            <!-- Video Guide Image Start -->
                            <div class="video-guide-image">
                                <a href="https://www.youtube.com/watch?v=7z0hNsNwkXE" class="popup-video" data-cursor-text="Play">
                                    <figure class="image-anime reveal">
                                        <img src="imgs/resource/v3.png" alt="">
                                    </figure>
                                </a>
                            </div>
                            <!-- Video Guide Image End -->

                            <!-- Video Guide Content Start -->
                            <div class="video-guide-content">
                                <!-- Section Title Start -->
                                <div class="section-title">
                                    <h2 class="text-anime-style-2" data-cursor="-opaque">Regulatory Challenges for Medical Device Start-ups
</h2>
                                </div>
                                <!-- Section Title End -->

                                <p>Embarking on the journey of innovation in the medical field is exhilarating, but regulatory hurdles can pose significant challenges.

</p>
                                <div class="video-guide-content-btn wow fadeInUp" data-wow-delay="0.4s">
                                    <a href="https://www.youtube.com/watch?v=7z0hNsNwkXE" class="btn-default popup-video">watch now</a>
                                </div>
                            </div>
                            <!-- Video Guide Content End -->
                        </div>
                        <!-- Video Guide Item End -->

                        <!-- Video Guide Item Start -->
                        <div class="video-guide-item">
                            <!-- Video Guide Image Start -->
                            <div class="video-guide-image">
                                <a href="https://www.youtube.com/watch?v=oOkoj6YnrHE" class="popup-video" data-cursor-text="Play">
                                    <figure class="image-anime reveal">
                                        <img src="imgs/resource/v4.png" alt="">
                                    </figure>
                                </a>
                            </div>
                            <!-- Video Guide Image End -->

                            <!-- Video Guide Content Start -->
                            <div class="video-guide-content">
                                <!-- Section Title Start -->
                                <div class="section-title">
                                    <h2 class="text-anime-style-2" data-cursor="-opaque">Building Efficiency in Product Development
</h2>
                                </div>
                                <!-- Section Title End -->

                               <p>Welcome to our comprehensive webinar on building medical devices with a focus on regulatory compliance! 


</p>

                                <div class="video-guide-content-btn wow fadeInUp" data-wow-delay="0.4s">
                                    <a href="https://www.youtube.com/watch?v=oOkoj6YnrHE" class="btn-default popup-video">watch now</a>
                                </div>
                            </div>
                            <!-- Video Guide Content End -->
                        </div>
                        <!-- Video Guide Item End -->--%>
                    </div>
                    <div class="row mt-12">
                        <div class="col-12 text-center">
                            <ul class="pagination pPagination justify-content-center">
                            </ul>
                        </div>
                    </div>
                    <!-- Video Guide Box End -->
                </div>
            </div>
        </div>
    </div>
    <script src="js/jquery-3.6.0.min.js"></script>
    <script src="js/pages/webinars.js"></script>
</asp:Content>

