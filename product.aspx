<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style>

        .company-success-content ul li{
            color:#000;
        }
        .company-success-content ul {
   margin-top:30px;
}
      .company-success-content ul li::before{
          top:12px;
          color:#000;   
      }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Hero Section Start -->
    <div class="product-hero-section">
        <div class="container">
            <div class="row justify-content-center align-items-center">
                <div class="col-lg-12">
                    <!-- Hero Content Start -->
                    <div class="hero-content text-center mb-0">
                        <!-- Section Title Start -->
                        <div class="section-title text-center dark-section">

                            <h1 class="text-anime-style-2 wow fadeInUp" data-wow-delay="0.4s">
                              Smart, Intuitive, Compliant, QMS Software to Meet Your Regulatory Requirements
                            </h1>
                        </div>
                        <!-- Section Title End -->

                        <!-- Hero Body Start -->
                        <div class="hero-body justify-content-center wow fadeInUp" data-wow-delay="0.6s">
                            <!-- Hero Button Start -->
                            <div class="hero-btn ">
                                <a href="javascript:void(0);" class="btn-default btn-dark-blue" data-bs-toggle="modal" data-bs-target="#enquireform">Book Demo Now</a>

                            </div>
                            <!-- Hero Button End -->
                        </div>


                        <div class="hero-image wow fadeInUp" data-wow-delay="0.8s">
                            <div class="blur-element">

                            </div> <img src="./imgs/product.png" alt="Hero Image" class="img-fluid" />
                        </div> <!-- Hero Body End -->
                    </div>
                    <!-- Hero Content End -->
                </div>
            </div>
        </div>
    </div>
    <div class="our-clients product-clients">
        <div class="container">
            <div class="row section-row">
                <div class="col-lg-12">
                    <!-- Section Title Start -->
                    <div class="section-title text-center ">
                        <h3 class="wow fadeInUp">our clients</h3>
                        <h2 class="text-anime-style-2">Trusted by Medtech <span>Leaders Globally</span> </h2>
                    </div>
                    <!-- Section Title End -->
                </div>
            </div>

            <div class="row">

                <div class="col-lg-12">

                    <div class="gallery-slider">
                        <div class="swiper"> <!-- Additional required wrapper -->
                            <div class="swiper-wrapper">
                                <!-- Slides -->
                                <%=strClients %>
                               <%-- <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp">
                                        <img src="imgs/clients/client-1.png" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.2s">
                                        <img src="imgs/clients/client-2.png" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.4s">
                                        <img src="imgs/clients/client-3.jpg" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.4s">
                                        <img src="imgs/clients/client-4.png" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.4s">
                                        <img src="imgs/clients/client-5.png" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.4s">
                                        <img src="imgs/clients/client-6.png" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.4s">
                                        <img src="imgs/clients/client-7.png" alt="" />
                                    </div>
                                </div>
                                <div class="swiper-slide">
                                    <div class="our-partner-item client-logo wow fadeInUp" data-wow-delay="0.4s">
                                        <img src="imgs/clients/SALCIT.jpg" alt="" />
                                    </div>
                                </div>--%>
                            </div>
                            <!-- If we need pagination -->
                            <div class="swiper-pagination"></div>

                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>

    <div class="company-success pt-0 why-us">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Company Success Box Start -->
                    <div class="company-success-box">
                        <!-- Company Success Item Start -->

                        <!-- Company Success Item End -->

                        <!-- Company Success Item Start -->
                        <div class="company-success-item">
                            <!-- Company Success Content Start -->
                            <div class="company-success-content">
                                <!-- Section Tite Start -->
                                <div class="section-title mb-30">
                                    <h3 class="wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">Your
                                        success, our commitment</h3>
                                    <h2 class="text-anime-style-2" data-cursor="-opaque">
                                        Why Implement <span>eQMS ? </span></h2>
                                    <P>
                                        <strong>It is necessary for any organization dedicated to provide safe, compliant, and high quality products particularly in highly regulated sectors such as MedTech industry.
easyQ eQMS ensures compliance at any point of time
                                        </strong>
                                    </P>
<ul>
  <li>
    In-built compliance for <b>ISO 13485, FDA 21 CFR Part 820, EU MDR, CDSCO and more</b>, an <b>eQMS</b> eliminates the risk of non-compliance by automating critical quality processes like <b>CAPA, Document Control, Risk Management</b>, and audit trails.
  </li>
  <li>
    Substitutes manual spreadsheets with a cloud-based centralized system that provides real-time version control, effortless collaboration, and instant audit readiness.
  </li>
  <li>
    Whether gearing up for an inspection, scaling across sites, or expanding into global markets, an eQMS increases operational efficiency, maintains data integrity, and enables continuous improvement—making it the smart choice for every MedTech company looking to scale faster and smarter.
  </li>
</ul>

                                </div>
                                <a href="javascript:void(0);" class="btn-default btn-highlighted wow fadeInUp" data-wow-delay="0.4s" data-bs-toggle="modal" data-bs-target="#enquireform">Book
                                    a
                                    Demo</a>
                                <!-- Section Tite End -->
                                <!-- Company Work List Start -->

                                <!-- Company Work List End -->
                            </div>
                            <!-- Company Success Content End -->

                            <!-- Company Success Image Start -->
                            <div class="company-success-image">
                                <!-- Company Success Img Start -->
                                <div class="company-success-img">
                                    <figure class="image-anime reveal"
                                        style="transform: translate(0px, 0px); opacity: 1; visibility: inherit;">
                                        <img src="images/company-success-img-2.jpg" alt=""
                                            style="transform: translate(0px, 0px);">
                                    </figure>
                                </div>
                                <!-- Company Success Img End -->

                                <!-- Company Growth Image Start -->

                                <!-- Company Growth Image End -->
                            </div>

                            <%--<div class="company-work-list">

                                <div class="company-work-list-item wow fadeInUp" data-wow-delay="0.4s"
                                    style="visibility: visible; animation-delay: 0.4s; animation-name: fadeInUp;">

                                    <div class="company-work-list-content">
                                        <p>In-built compliance for ISO 13485, FDA 21 CFR Part 820 and India’s MDR 2017,
                                            an eQMS eliminates the risk of non-compliance by automating critical quality
                                            processes like CAPA, Document Control, Risk Management, and audit trails.

                                        </p>
                                    </div>
                                </div>

                                <div class="company-work-list-item wow fadeInUp" data-wow-delay="0.6s"
                                    style="visibility: visible; animation-delay: 0.6s; animation-name: fadeInUp;">

                                    <div class="company-work-list-content">
                                        <p>Substitutes manual spreadsheets with a cloud-based centralized system that
                                            provides real-time version control, effortless collaboration, and instant
                                            audit readiness.

                                        </p>
                                    </div>
                                </div>

                                <div class="company-work-list-item wow fadeInUp" data-wow-delay="0.8s"
                                    style="visibility: hidden; animation-delay: 0.8s; animation-name: none;">

                                    <div class="company-work-list-content">
                                        <p>Whether gearing up for a CDSCO inspection, scaling across sites or expanding
                                            into global markets, an eQMS increases operational efficiency, maintains
                                            data integrity, and enables continuous improvement making it the smart
                                            choice for every MedTech company looking to scale faster and smarter.

                                        </p>
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="our-process easy-goal-section bg-light">
        <div class="container">
            <div class="row section-row align-items-center">
                <div class="col-lg-12">
                    <!-- Section Tite Start -->
                    <div class="section-title">

                        <h2 class="text-anime-style-2 text-center ">
                            Why Implement Our <span>eQMS ?</span> </h2>
                   
                    </div>
                    <!-- Section Tite End -->
                </div>


            </div>


            <!-- Process Steps List Start -->
          <div class="row gy-4 wow fadeInUp" data-wow-delay="0.4s">
<!-- First Row: Top 3 Cards -->
<div class="row gy-4 mb-5 wow fadeInUp" data-wow-delay="0.4s">
  <div class="col-lg-4">
    <div class="process-step-box why-card">
      <div class="icon-box">
        <img src="./imgs/icons/global-navigation.png">
      </div>
      <div class="process-step-content">
        <h3>Supports Global Compliance from Day One</h3>
        <p>Workflows compliant to <b>ISO 13485, CDSCO, US FDA 21 CFR Part 820</b> and <b>EU MDR</b></p>
      </div>
    </div>
  </div>

  <div class="col-lg-4">
    <div class="process-step-box why-card">
      <div class="icon-box">
        <img src="./imgs/icons/growth.png">
      </div>
      <div class="process-step-content">
        <h3>50% Faster Compliance, Accelerated Market Entry</h3>
        <p>Reduces the operational burden so your team can focus on product development, market entry, and scaling—not paperwork.</p>
      </div>
    </div>
  </div>

  <div class="col-lg-4">
    <div class="process-step-box why-card">
      <div class="icon-box">
        <img src="./imgs/icons/implementation.png">
      </div>
      <div class="process-step-content">
        <h3>Quick Implementation, Low Setup Effort</h3>
        <p>Get your QMS in record time with ready to use modules.
No long onboarding process or IT dependency.
Easy to use without complexicity.
</p>
      </div>
    </div>
  </div>
</div>

<!-- Second Row: Centered 2 Cards with same bottom spacing -->
<div class="row justify-content-center wow fadeInUp" data-wow-delay="0.5s">
  <div class="col-lg-4">
    <div class="process-step-box why-card">
      <div class="icon-box">
        <img src="./imgs/icons/audit.png">
      </div>
      <div class="process-step-content">
        <h3>Always Audit Ready, No Last Minute Stress</h3>
        <p>Be assured with real-time traceability, version control, and digital audit trails with no last minute panic before inspections.
</p>
      </div>
    </div>
  </div>

  <div class="col-lg-4">
    <div class="process-step-box why-card">
      <div class="icon-box">
        <img src="./imgs/icons/data-security.png">
      </div>
      <div class="process-step-content">
        <h3>Data Security</h3>
        <p>Your data is secured with our 21 CFR Part 11 compliant solution to ensure confidentiality and accessibility.</p>
      </div>
    </div>
  </div>
</div>

    </div>
    <div class="process-module ">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <!-- Section Tite Start -->
                    <div class="section-title text-center wow fadeInUp" data-wow-delay="0.4s">
                        <h2 class="text-anime-style-2">
                            eQMS <span>Features</span> </h2>
                        <p>
                            easyQ Solutions offers a user-friendly eQMS designed for both emerging MedTech startups
                            and
                            established manufacturers <br>offering faster compliance, hassle free implementation,
                            and
                            effortless scalability<br> without the complexity of traditional systems.
                        </p>

                    </div>
                </div>



            </div>
            <div class="row">
                <div class="col-12 col-xxl-12 mx-auto">
                    <div class="row mt-50 align-items-center wow fadeInUp" data-wow-delay="0.4s">
                        <div class="col-12 col-lg-6">
                            <div class="feature-content ">
                                <h2>
                                    <span class="gredient-text type-2">Quality Policy


                                    </span>
                                </h2>
<p>Allows your organization to define, monitor and evaluate quality goals that are in line with your quality policy, promoting ongoing development and ensuring compliance with regulatory standards.


                                </P>
                            </div>
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Quality Objective


                                    </span>
                                </h2>
                              <p>Securely draft, authorize, and communicate your organization’s quality Objective, and communicate your organization’s quality objective while making sure they comply with regulatory requirements and seamless integration with key quality procedures.

</p>
                            </div>
                        </div>
                        <div class="col-12 col-lg-6">
                            <div class="feature-image">
                                <div class="image-1">
                                    <img src="./imgs/q1.png" alt="">
                                </div>

                                <div class="blocksglow"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row mt-50 align-items-center reversed wow fadeInUp" data-wow-delay="0.4s">

                        <div class="col-12 col-lg-6">
                            <div class="feature-image ps-0">
                                <div class="image-1">
                                    <img src="./imgs/q2.png" alt="">
                                </div>

                                <div class="blocksglow"></div>
                            </div>
                        </div>
                        <div class="col-12 col-lg-6">
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Responsibility & Authority


                                    </span>
                                </h2>
                                <P>To ensure accountability and regulatory compliance, clearly define, document, and
                                    maintain clear roles, responsibilities and decision making authority throughout
                                    your
                                    organization.

                                </P>
                            </div>
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Management Review



                                    </span>
                                </h2>
                                <P>Simplifies the planning, execution, and documentation of management review
                                    meetings
                                    to support data driven decision making and maintaining regulatory compliance and
                                    quality system standards.


                                </P>
                            </div>
                        </div>
                    </div>
                    <div class="row  mt-50 align-items-center wow fadeInUp" data-wow-delay="0.4s">
                        <div class="col-12 col-lg-6">
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Document Control


                                    </span>
                                </h2>
                                <P>Ensure accuracy, traceability, and rigorous adherence to regulatory standards by managing the drafting, review, approval, distribution, and revision of documents efficiently.


                                </P>
                            </div>
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">CAPA



                                    </span>
                                </h2>
                                <P>Centralize problem identification, tracking, documentation and resolution to
                                    facilitate in-depth root cause analysis and ensure regulatory compliance.


                                </P>
                            </div>
                        </div>
                        <div class="col-12 col-lg-6">
                            <div class="feature-image">
                                <div class="image-1">
                                    <img src="./imgs/q3.png" alt="">
                                </div>

                                <div class="blocksglow"></div>
                            </div>
                        </div>
                    </div>
                    <div class="row mt-50 align-items-center reversed wow fadeInUp" data-wow-delay="0.4s">

                        <div class="col-12 col-lg-6">
                            <div class="feature-image ps-0">
                                <div class="image-1">
                                    <img src="./imgs/q4.png" alt="">
                                </div>

                                <div class="blocksglow"></div>
                            </div>
                        </div>
                        <div class="col-12 col-lg-6">
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Training



                                    </span>
                                </h2>
                                <P>Simplify the training processes management by monitoring employee development,
                                    ensuring regulatory compliance and making the training records and materials
                                    easily
                                    accessible for continuous improvement.


                                </P>
                            </div>
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Risk Management




                                    </span>
                                </h2>
                                <P>Inline with ISO 14971, assure efficient Risk Management throughout the product lifecycle by proactively identifying, evaluating, and mitigating risks while adhering to industry standards and regulations.
</P>
                            </div>
                        </div>
                    </div>
                    <div class="row  mt-50 align-items-center wow fadeInUp" data-wow-delay="0.4s">
                        <div class="col-12 col-lg-6">
                            <div class="feature-content">
                                <h2>
                                    <span class="gredient-text type-2">Complaint Management



                                    </span>
                                </h2>
                                <P>Simplify the process of handling complaints so that they can be investigated,
                                    documented, and resolved quickly. This will turn complaints into insightful
                                    information that can be used to improve products and increase customer
                                    satisfaction.


                                </P>
                            </div>

                        </div>
                        <div class="col-12 col-lg-6">
                            <div class="feature-image">
                                <div class="image-1">
                                    <img src="./imgs/q5.png" alt="">
                                </div>

                                <div class="blocksglow"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>



        </div>
    </div>
    </div> <!-- Our Faqs Section End -->
        </div>
    <div class="contact-info-section">
        <div class="container">
            <!-- Hero Section -->
            <div class="section-title">
                <h2 class="">Know more about easyQ <span>eQMS</span></h2>
            </div>

            <!-- Features Section -->
            <div class="row">
                <!-- Pricing Column -->
                <div class="col-lg-4 col-md-6">
                    <div class="feature-card wow fadeInUp" data-wow-delay="0.4s">
                        <div class="feature-img">
                            <img src="./imgs/c1.png">
                        </div>
                        <div class="content">
                            <h3 class="feature-title">Pricing</h3>
                            <p class="feature-description">
                                Get full access to our eQMS with a single, transparent pricing structure.
                            </p>

                            <a href="/contact-us.aspx" class="readmore-btn" contenteditable="false" style="cursor: pointer;"> Request
                                Pricing Info
                            </a>
                        </div>

                    </div>
                </div>

                <!-- Contact Us Column -->
                <div class="col-lg-4 col-md-6">
                    <div class="feature-card wow fadeInUp" data-wow-delay="0.4s">
                        <div class="feature-img">
                            <img src="./imgs/c2.png">
                        </div>
                        <div class="content">
                            <h3 class="feature-title">Contact Us</h3>
                            <p class="feature-description">
                                Contact us to start your smart Compliance journey.
                            </p>

                            <a href="/contact-us.aspx" class="readmore-btn" contenteditable="false" style="cursor: pointer;"> Contact
                                US
                            </a>
                        </div>

                    </div>
                </div>

                <!-- Demo Column -->
                <div class="col-lg-4 col-md-12">
                    <div class="feature-card wow fadeInUp" data-wow-delay="0.4s">
                        <div class="feature-img">
                            <img src="./imgs/c3.png">
                        </div>

                        <div class="content">
                            <h3 class="feature-title">Demo</h3>
                            <p class="feature-description">
                                Book a demo and see our eQMS <br>in action
                            </p>
                            <a href="javascript:void(0);" class="readmore-btn" contenteditable="false" style="cursor: pointer;" data-bs-toggle="modal" data-bs-target="#enquireform"> Book Demo
                            </a>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

