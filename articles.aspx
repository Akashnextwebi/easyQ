<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="articles.aspx.cs" Inherits="articiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .page-header {
            margin-top: 100px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-header" style="background-image: url(imgs/resource/banner.png)">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Page Header Box Start -->
                    <div class="page-header-box text-start">
                        <h1 class="text-anime-style-2 text-start">Articles</h1>
                        <nav class="wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                            <ul class="breadcrumb ">
                                <li class="breadcrumb-item"><a href="#" class="text-white" contenteditable="false" style="cursor: pointer;">Home</a></li>
                                <li class="breadcrumb-item active text-white" aria-current="page">Articles</li>
                            </ul>
                        </nav>
                    </div>
                    <!-- Page Header Box End -->
                </div>
            </div>
        </div>
    </div>
    <div class="our-blog">
        <div class="container">


            <div class="row" id="ArticleListBindingSec">
                <%-- <div class="col-lg-4 col-md-6">
                    <!-- Post Item Start -->
                    <div class="post-item wow fadeInUp">
                        <!-- Post Featured Image Start-->
                        <div class="post-featured-image">
                            <a href="#">
                                <figure class="image-anime">
                                    <img src="./imgs/blog1.png" alt="" />
                                </figure>
                            </a>
                        </div>
                        <!-- Post Featured Image End -->

                        <!-- Post Item Body Start -->
                        <div class="post-item-body">
                            <!-- Post Item Content Start -->
                            <div class="post-item-content">
                                <span>01-july-2025</span>
                                <h2 class="mt-2">
                                    <a href="#">Why a Robust QMS is the Backbone of Medical Device
                   Success</a>
                                </h2>
                            </div>
                            <!-- Post Item Content End -->

                            <!-- Post Item Button Start-->
                            <div class="post-item-btn">
                                <a href="#" class="readmore-btn" data-bs-toggle="modal" data-bs-target="#brochureModal">Download Article</a>
                            </div>
                            <!-- Post Item Button End-->
                        </div>
                        <!-- Post Item Body End -->
                    </div>
                    <!-- Post Item End -->
                </div>

                <div class="col-lg-4 col-md-6">
                    <!-- Post Item Start -->
                    <div class="post-item wow fadeInUp" data-wow-delay="0.2s">
                        <!-- Post Featured Image Start-->
                        <div class="post-featured-image">
                            <a href="#">
                                <figure class="image-anime">
                                    <img src="./imgs/blog2.png" alt="" />
                                </figure>
                            </a>
                        </div>
                        <!-- Post Featured Image End -->

                        <!-- Post Item Body Start -->
                        <div class="post-item-body">
                            <!-- Post Item Content Start -->
                            <div class="post-item-content">
                             <span>01-july-2025</span>
<h2 class="mt-2">
                                    <a href="#">How to Prepare for a Regulatory Audit Without the
                   Stress</a>
                                </h2>
                            </div>
                            <!-- Post Item Content End -->

                            <!-- Post Item Button Start-->
                            <div class="post-item-btn">
                                <a href="#" class="readmore-btn" data-bs-toggle="modal" data-bs-target="#brochureModal">Download Article</a>
                            </div>
                            <!-- Post Item Button End-->
                        </div>
                        <!-- Post Item Body End -->
                    </div>
                    <!-- Post Item End -->
                </div>

                <div class="col-lg-4 col-md-6">
                    <!-- Post Item Start -->
                    <div class="post-item wow fadeInUp" data-wow-delay="0.4s">
                        <!-- Post Featured Image Start-->
                        <div class="post-featured-image">
                            <a href="#">
                                <figure class="image-anime">
                                    <img src="./imgs/blog3.png" alt="" />
                                </figure>
                            </a>
                        </div>
                        <!-- Post Featured Image End -->

                        <!-- Post Item Body Start -->
                        <div class="post-item-body">
                            <!-- Post Item Content Start -->
                            <div class="post-item-content">
                              <span>01-july-2025</span>
<h2 class="mt-2">
                                    <a href="#">How easyQ Solutions Helped a Client Achieve ISO
                   Certification in 3 Months</a>
                                </h2>
                            </div>
                            <!-- Post Item Content End -->

                            <!-- Post Item Button Start-->
                            <div class="post-item-btn">
                                <a href="#" class="readmore-btn" data-bs-toggle="modal" data-bs-target="#brochureModal">Download Article</a>
                            </div>
                            <!-- Post Item Button End-->
                        </div>
                        <!-- Post Item Body End -->
                    </div>
                    <!-- Post Item End -->
                </div>--%>
            </div>
            <div class="row mt-12">
                <div class="col-12 text-center">
                    <ul class="pagination pPagination justify-content-center">
                        
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- Download Brochure Modal -->
    <div class="modal fade" id="brochureModal" tabindex="-1" aria-labelledby="brochureModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h5 class="modal-title" id="brochureModalLabel">Download Articles</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>

                <!-- Modal Body with Form -->
                <div class="modal-body">
                    <div id="brochureForm">
                        <div class="mb-3">
                            <label for="txtName" class="form-label">Name<sup class="text-danger">*</sup></label>
                            <input type="text" class="form-control" id="txtName" maxlength="100" placeholder="Enter your name">
                        </div>
                        <div class="mb-3">
                            <label for="txtEmail" class="form-label">Email address<sup class="text-danger">*</sup></label>
                            <input type="email" class="form-control" id="txtEmail" maxlength="150" placeholder="Enter your email">
                        </div>
                        <div class="mb-3">
                            <label for="txtPhone" class="form-label">Phone Number<sup class="text-danger">*</sup></label>
                            <input type="tel" class="form-control numberonly" id="txtPhone" maxlength="15" placeholder="Enter your phone number">
                        </div>
                        <div class="mb-3">
                            <label for="txtOrg" class="form-label">Organization Name<sup class="text-danger">*</sup></label>
                            <input type="text" class="form-control" id="txtOrg" maxlength="150" placeholder="Enter your Organization Name">
                        </div>
                        <div class="">
                            <a href="javascript:void(0);" id="btnResourceDownload" class="btn-default btn-highlighted">Download Now <i class="fa-solid fa-download ms-2"></i></a>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>
    <script src="js/jquery-3.6.0.min.js"></script>
    <script src="js/pages/articles.js"></script>

</asp:Content>

