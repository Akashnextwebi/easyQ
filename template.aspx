<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="template.aspx.cs" Inherits="template" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .page-header {
            margin-top: 100px;
        }

        .project-image img {
            aspect-ratio: 1 / 0.701;
            object-fit: cover;
            transition: all 0.4s ease-in-out;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-header" style="background-image: url(imgs/resource/template.png)">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Page Header Box Start -->
                    <div class="page-header-box text-start">
                        <h1 class="text-anime-style-2 text-start">Template</h1>
                        <nav class="wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                            <ul class="breadcrumb ">
                                <li class="breadcrumb-item"><a href="#" class="text-white" contenteditable="false" style="cursor: pointer;">Home</a></li>
                                <li class="breadcrumb-item active text-white" aria-current="page">Template</li>
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


            <div class="row" id="TemplateListBindingSec">
                <%--  <div class="col-lg-6">
                    <div class="project-item wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                        <div class="project-image">
                            <a href="" data-cursor-text="View" contenteditable="false" style="cursor: pointer;">
                                <figure class="image-anime">
                                    <img src="imgs/resource/template/1.png" alt="">
                                </figure>
                            </a>
                        </div>
                        <div class="project-content">
                            <h3><a href="" contenteditable="false" style="cursor: pointer;">EU declaration of conformity
t</a></h3>
                            <a href="#" class="btn-default btn-highlighted mt-3" data-bs-toggle="modal" data-bs-target="#brochureModal">Download <i class="fa-solid fa-download ms-2"></i></a>

                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="project-item wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                        <div class="project-image">
                            <a href="" data-cursor-text="View" contenteditable="false" style="cursor: pointer;">
                                <figure class="image-anime">
                                    <img src="imgs/resource/template/2.png" alt="">
                                </figure>
                            </a>
                        </div>
                        <div class="project-content">
                            <h3><a href="" contenteditable="false" style="cursor: pointer;">Design History File
                            </a></h3>
                            <a href="#" class="btn-default btn-highlighted mt-3" data-bs-toggle="modal" data-bs-target="#brochureModal">Download <i class="fa-solid fa-download ms-2"></i></a>

                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="project-item wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                        <div class="project-image">
                            <a href="" data-cursor-text="View" contenteditable="false" style="cursor: pointer;">
                                <figure class="image-anime">
                                    <img src="imgs/resource/template/3.png" alt="">
                                </figure>
                            </a>
                        </div>
                        <div class="project-content">
                            <h3><a href="" contenteditable="false" style="cursor: pointer;">GSPR
                            </a></h3>
                            <a href="#" class="btn-default btn-highlighted mt-3" data-bs-toggle="modal" data-bs-target="#brochureModal">Download <i class="fa-solid fa-download ms-2"></i></a>

                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="project-item wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                        <div class="project-image">
                            <a href="" data-cursor-text="View" contenteditable="false" style="cursor: pointer;">
                                <figure class="image-anime">
                                    <img src="imgs/resource/template/4.png" alt="">
                                </figure>
                            </a>
                        </div>
                        <div class="project-content">
                            <h3><a href="" contenteditable="false" style="cursor: pointer;">cash flow boost</a></h3>
                            <a href="#" class="btn-default btn-highlighted mt-3" data-bs-toggle="modal" data-bs-target="#brochureModal">Download <i class="fa-solid fa-download ms-2"></i></a>

                        </div>
                    </div>
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
    <div class="modal fade" id="brochureModal" tabindex="-1" aria-labelledby="brochureModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h5 class="modal-title" id="brochureModalLabel">Download Templete</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"><i class="fa-solid fa-xmark"></i></button>
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
                            <a href="javascript:void(0);" id="btnResourceDownload" class="btn-default btn-highlighted">Download Now</a>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>
    <script src="js/jquery-3.6.0.min.js"></script>
    <script src="js/pages/template.js"></script>
</asp:Content>

