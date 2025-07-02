<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="contact-us.aspx.cs" Inherits="contact_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-header" style="background-image: url(imgs/resource/contact-us.png)">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Page Header Box Start -->
                    <div class="page-header-box text-start">
                        <h1 class="text-anime-style-2 text-start">Contact Us</h1>
                        <nav class="wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                            <ul class="breadcrumb ">
                                <li class="breadcrumb-item"><a href="#" class="text-white" contenteditable="false" style="cursor: pointer;">Home</a></li>
                                <li class="breadcrumb-item active text-white" aria-current="page">Contact Us</li>
                            </ul>
                        </nav>
                    </div>
                    <!-- Page Header Box End -->
                </div>
            </div>
        </div>
    </div>
    <div class="page-contact-us">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-6">
                    <!-- Contect Us Content Start -->
                    <div class="contact-us-content">
                        <!-- Section Title Start -->
                        <div class="section-title">
                            <h3 class="wow fadeInUp">contact us</h3>
                            <h2 class="text-anime-style-2" data-cursor="-opaque">Get in touch <span>with us</span></h2>
                            <p class="wow fadeInUp" data-wow-delay="0.2s">Have questions or need expert guidance? Connect with our team for tailored financial solutions and personalized support to meet your goals.</p>
                        </div>
                        <!-- Section Title End -->

                        <!-- Contact Info List Start -->
                        <div class="contact-info-list">
                            <!-- Conatct Info Item Start -->
                            <div class="contact-info-item wow fadeInUp" data-wow-delay="0.4s">
                                <!-- Icon Box Start -->
                                <div class="icon-box">
                                    <img src="images/phone-call-svgrepo-com.svg" alt="">
                                </div>
                                <!-- Icon Box End -->

                                <!-- Contact Info Content Start -->
                                <div class="contact-info-content">
                                    <h3>Phone No</h3>
                                    <p>+91 12345 67890 </p>
                                </div>
                                <!-- Contact Info Content End -->
                            </div>
                            <!-- Conatct Info Item End -->

                            <!-- Conatct Info Item Start -->
                            <div class="contact-info-item wow fadeInUp" data-wow-delay="0.6s">
                                <!-- Icon Box Start -->
                                <div class="icon-box">
                                    <img src="images/icon-mail.svg" alt="">
                                </div>
                                <!-- Icon Box End -->

                                <!-- Contact Info Content Start -->
                                <div class="contact-info-content">
                                    <h3>email</h3>
                                    <p>info@easyqsolutions.com</p>
                                </div>
                                <!-- Contact Info Content End -->
                            </div>
                            <!-- Conatct Info Item End -->
                        </div>
                        <!-- Contact Info List End -->
                    </div>
                    <!-- Contect Us Content End -->
                </div>

                <div class="col-lg-6">
                    <!-- Contact Form Start -->
                    <div class="contact-form">
                        <div id="contactForm" action="#" method="POST" data-toggle="validator" class="wow fadeInUp" data-wow-delay="0.2s">
                            <asp:Label ID="lblStatus" runat="server" Visible="false"></asp:Label>
                            <div class="row">
                                <div class="form-group col-md-6 mb-4">
                                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Your Name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                                        ErrorMessage="Name is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" />
                                </div>

                                <div class="form-group col-md-6 mb-4">
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Your Email" TextMode="Email"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                                        ErrorMessage="Email is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" />
                                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                                        ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
                                        ErrorMessage="Invalid email format" Display="Dynamic" ForeColor="Red" />
                                </div>

                                <div class="form-group col-md-12 mb-4">
                                    <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control numberonly" placeholder="Your Phone"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone"
                                        ErrorMessage="Phone number is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" />
                                </div>

                                <div class="form-group col-md-12 mb-5">
                                    <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" placeholder="Write Message.."></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvMessage" runat="server" ControlToValidate="txtMessage"
                                        ErrorMessage="Message is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" />
                                </div>

                                <div class="col-md-12">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Send Inquiry" CssClass="btn-default" UseSubmitBehavior="false" OnClick="btnSubmit_Click" />
                                </div>
                            </div>

                            <%--<div class="row">                                
            <div class="form-group col-md-6 mb-4">
                <input type="text" name="name" class="form-control" id="txtName" placeholder="Your Name" required>
                <div class="help-block with-errors"></div>
            </div>

            <div class="form-group col-md-6 mb-4">
                <input type="email" name ="email" class="form-control" id="txtEmail" placeholder="Your Email" required>
                <div class="help-block with-errors"></div>
            </div>

            <div class="form-group col-md-12 mb-4">
                <input type="text" name="phone" class="form-control" id="txtPhone" placeholder="Your Phone" required>
                <div class="help-block with-errors"></div>
            </div>

            <div class="form-group col-md-12 mb-5">
                <textarea name="message" class="form-control" id="txtmessage" rows="4" placeholder="Write Message.."></textarea>
                <div class="help-block with-errors"></div>
            </div>

            <div class="col-md-12">
                <button type="submit" class="btn-default">send inquiry</button>
                <div id="msgSubmit" class="h3 hidden"></div>
            </div>
        </div>--%>
                        </div>
                    </div>
                    <!-- Contact Form End -->
                </div>
            </div>
        </div>
    </div>
    <!-- Page Contact Us End -->


</asp:Content>

