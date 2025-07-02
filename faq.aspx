<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="faq.aspx.cs" Inherits="faq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="page-header" style="background-image: url(imgs/resource/faq.png)">
      <div class="container">
          <div class="row">
              <div class="col-lg-12">
                  <!-- Page Header Box Start -->
                  <div class="page-header-box text-start">
                      <h1 class="text-anime-style-2 text-start">FAQ'S</h1>
                      <nav class="wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                          <ul class="breadcrumb ">
                              <li class="breadcrumb-item"><a href="#" class="text-white" contenteditable="false" style="cursor: pointer;">Home</a></li>
                              <li class="breadcrumb-item active text-white" aria-current="page">FAQ'S</li>
                          </ul>
                      </nav>
                  </div>
                  <!-- Page Header Box End -->
              </div>
          </div>
      </div>
  </div>
      <div class="page-faqs">
        <div class="container">
            <div class="row justify-content-center">
             

                <div class="col-lg-9">
                    <!-- Page FAQs Catagery Start -->
                    <!-- FAQs section for EasyQ Solutions Start -->
<div class="faq-accordion page-faq-accordion mt-5" id="easyq_solutions">
  
    <div class="faq-accordion" id="accordionEasyQ">
            <%=strFAQs %>
       <%-- <!-- FAQ Item Start -->
        <div class="accordion-item wow fadeInUp">
            <h2 class="accordion-header" id="easyqHeading1">
                <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#easyqCollapse1" aria-expanded="true" aria-controls="easyqCollapse1">
                    1. What is EasyQ Solutions?
                </button>
            </h2>
            <div id="easyqCollapse1" class="accordion-collapse collapse show" aria-labelledby="easyqHeading1" data-bs-parent="#accordionEasyQ">
                <div class="accordion-body">
                    <p>EasyQ Solutions is a smart queue management system that helps streamline customer flow and reduce waiting time through digital token distribution and real-time monitoring.</p>
                </div>
            </div>
        </div>
        <!-- FAQ Item End -->

        <!-- FAQ Item Start -->
        <div class="accordion-item wow fadeInUp" data-wow-delay="0.2s">
            <h2 class="accordion-header" id="easyqHeading2">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#easyqCollapse2" aria-expanded="false" aria-controls="easyqCollapse2">
                    2. Which industries can benefit from EasyQ Solutions?
                </button>
            </h2>
            <div id="easyqCollapse2" class="accordion-collapse collapse" aria-labelledby="easyqHeading2" data-bs-parent="#accordionEasyQ">
                <div class="accordion-body">
                    <p>Industries such as healthcare, banking, government offices, retail, and telecom benefit greatly from queue management to enhance service delivery and reduce congestion.</p>
                </div>
            </div>
        </div>
        <!-- FAQ Item End -->

        <!-- FAQ Item Start -->
        <div class="accordion-item wow fadeInUp" data-wow-delay="0.4s">
            <h2 class="accordion-header" id="easyqHeading3">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#easyqCollapse3" aria-expanded="false" aria-controls="easyqCollapse3">
                    3. Can EasyQ Solutions be customized for different service counters?
                </button>
            </h2>
            <div id="easyqCollapse3" class="accordion-collapse collapse" aria-labelledby="easyqHeading3" data-bs-parent="#accordionEasyQ">
                <div class="accordion-body">
                    <p>Yes, EasyQ can be fully customized to support multiple service counters, departments, token priorities, and can even be integrated with digital signage or mobile apps.</p>
                </div>
            </div>
        </div>
        <!-- FAQ Item End -->--%>
    </div>
</div>
<!-- FAQs section for EasyQ Solutions End -->

                    <!-- Page FAQs Catagery End -->               
                </div>
            </div>
        </div>
    </div>
    <!-- Page Faq End -->
</asp:Content>

