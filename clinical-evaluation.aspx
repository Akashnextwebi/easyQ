<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="clinical-evaluation.aspx.cs" Inherits="clinical_evaluation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
  <!-- Hero Section Start -->
  <section class="easyq-hero-section services-banner">
    <div class="hero hero-image hero-slider-layout">
      <div class="hero-slide">
        <!-- Slider Image Start -->
        <div class="hero-slider-image">
          <img src="imgs/sh1.jpg" alt="" />
        </div>
        <!-- Slider Image End -->
        <div class="hero-overlay"></div>
        <div class="container">
          <div class="row align-items-center">
            <div class="col-lg-8">
              <!-- Hero Content Start -->
              <div class="hero-content text-start">
                <!-- Section Title Start -->
                <div class="section-title dark-section">
                  <h1 class="text-anime-style-2">easyQ Solutions: Powering Medical Device Approvals Through Expert
                    Clinical Evaluation</h1>

                  <p class="wow fadeInUp">
                    At easyQ Solutions, we simplify the complexity of Clinical Evaluation by offering support that is
                    region-specific, expert-led, and compliant. We make sure your Medical Device
                    complies with FDA, EU MDR, and other global regulations, from identifying data gaps to preparing
                    audit-ready Clinical Evaluation Reports (CERs) enabling faster approvals and
                    market success.
                  </p>
                </div>
                <!-- Section Title End -->

                <!-- Hero Body Start -->
                <div class="hero-body wow fadeInUp" data-wow-delay="0.2s">
                  <!-- Hero Button Start -->
                  <div class="hero-btn">
                    <a href="#" class="btn-default btn-highlighted">Contact Us</a>
                  </div>
                  <!-- Hero Button End -->
                </div>
                <!-- Hero Body End -->
              </div>
              <!-- Hero Content End -->
            </div>
          </div>
        </div>
      </div>

      <!-- Hero Slide End -->

      <!-- Hero Slide Start -->

      <!-- Hero Slide End -->
    </div>
  </section>
  <!-- Hero Section End -->

  <div class="our-clients product-clients">
    <div class="container">
      <div class="row section-row">
        <div class="col-lg-12">
          <!-- Section Title Start -->
          <div class="section-title text-center">
            <h3 class="wow fadeInUp">our clients</h3>
            <h2 class="text-anime-style-2">
              Trusted by Medtech
              <span>Leaders Globally</span>
            </h2>
          </div>
          <!-- Section Title End -->
        </div>
      </div>

      <div class="row">
        <div class="col-lg-12">
          <div class="gallery-slider">
            <div class="swiper">
              <!-- Additional required wrapper -->
              <div class="swiper-wrapper">
                  <%=strClients %>
                <!-- Slides -->
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

  <div class="our-faqs our-includes">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <!-- Our Faq Content Start -->
          <div class="our-faq-content">
            <!-- Section Title Start -->
            <div class="section-title">
              <h2 class="text-anime-style-2 text-white">Our Services Include</h2>
              <p class="wow fadeInUp text-white" data-wow-delay="0.2s">
                easyQ Solutions support the entire lifecycle of Clinical Evaluation services to assist your Medical
                Device in navigating through complex regulatory landscape by customizing
                strategies for preparing the Clinical Evaluation Reports (CERs) and Clinical Evaluation Plans (CEPs) to
                meet the requirements of global health authorities such as FDA, EU MDR, and
                other global bodies.
              </p>

              <div class="row justify-content-center certicicate-images">
                <div class="col wow fadeInUp">
                  <div class="hero-btn services-btn">
                    <a href="#" class="btn-default btn-highlighted">Contact Us</a>
                  </div>
                </div>
              </div>
            </div>
            <!-- Section Title End -->

            <!-- Faq Content Button Start -->

            <!-- Faq Content Button End -->
          </div>
          <!-- Our Faq Content End -->
        </div>

        <div class="col-lg-6">
          <!-- FAQ Accordion Start -->
          <h5 class="mb-3 text-white">Our Clinical Evaluation services offers:</h5>

          <ul class="text-white">
            <li>Developing customized Clinical Evaluation strategies specific to various global markets by considering
              the regulations and standards set by health agencies such as FDA, EU MDR and other global bodies</li>
            <li>Assistance in drafting Clinical Evaluation Plans (CEP) and Clinical Evaluation Reports (CER).
            </li>
            <li>Providing Post Market Surveillance services to assure compliance following market entry, such as
              Post-market Surveillance Plans (PMSP) and Post-market Surveillance Report (PMSR)
            </li>
            <li>Managing Post-market Clinical Follow-Up (PMCF) activities and developing Post-market Clinical Follow-Up
              Reports (PMCFR) to maintain compliance over time.</li>
            <li>Coordinating with notified bodies and facilitating Medical Device panel meetings to ensure a smooth
              regulatory process and an efficient route to approval.</li>

          </ul>
        </div>
      </div>
    </div>
  </div>

  <!-- Our Integrations Section End -->
  <div class="our-feature">
    <div class="container">
      <div class="row section-row">
        <!-- Section Title Start -->
        <div class="section-title text-center">
          <h2 class="text-anime-style-2" data-cursor="-opaque">
            Why Our Experts for Global Regulatory
            <span>Approvals?</span>
          </h2>
        </div>
        <!-- Section Title End -->
      </div>

      <div class="row">
        <div class="col-lg-12">
          <!-- Our Feature Box Start -->
          <div class="our-feature-box tab-content" id="myTabContent">
            <!-- Sidebar Our Feature Nav start -->



            <div class="feature-tabs-wrapper">
              <div class="row">
                <div class="col-lg-0">
                  <button class="scroll-arrow left-arrow" type="button">
                    <i class="fas fa-chevron-left"></i>
                  </button>
                </div>
                <div class="col-lg-12">
                  <div class="our-feature-nav mx-auto wow fadeInUp" data-wow-delay="0.2s"
                    style="visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;">
                    <ul class="nav nav-tabs" id="myTab" role="tablist">
                      <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="documents-tab" data-bs-toggle="tab"
                          data-bs-target="#documents" type="button" role="tab" aria-selected="true">
                          <img src="./imgs/icons/cv1.png" alt="" />
                          Deep Regulatory Expertise
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="event-tab" data-bs-toggle="tab" data-bs-target="#event"
                          type="button" role="tab" aria-selected="false">
                          <img src="./imgs/icons/cv2.png" alt="" />
                          Comprehensive Approach
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="tailored-tab" data-bs-toggle="tab" data-bs-target="#tailored"
                          type="button" role="tab" aria-selected="false">
                          <img src="./imgs/icons/cv3.png" alt="" />
                          Tailored Solutions
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="puccess-tab" data-bs-toggle="tab" data-bs-target="#puccess"
                          type="button" role="tab" aria-selected="false">
                          <img src="./imgs/icons/cv4.png" alt="" />
                          Proven Success
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="sessions-tab" data-bs-toggle="tab" data-bs-target="#sessions"
                          type="button" role="tab" aria-selected="false">
                          <img src="./imgs/icons/cv5.png" alt="" />
                          Effective and Efficient
                        </button>
                      </li>
                    </ul>
                  </div>

                </div>
                <div class="col-lg-0">
                  <button class="scroll-arrow right-arrow" type="button">
                    <i class="fas fa-chevron-right"></i>
                  </button>
                </div>
              </div>
              <!-- Left Arrow -->

              <!-- Scrollable Tab List -->



            </div>
            <!-- Sidebar Our Feature Nav End -->

            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade show active" id="documents" role="tabpanel"
              aria-labelledby="documents-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/cv1.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Deep Regulatory Expertise</h3>
                        <p>
                          Our regulatory specialists have years of experience with global medical device regulations
                          to understand the complexities of clinical evaluation and offer clear, actionable guidance
                          for both new and existing products.
                        </p>
                      </div>
                    </div>
                    <!-- Feature Tab Content Header End -->

                    <!-- Feature Tab Content List Start -->

                    <!-- Feature Tab Content List End -->

                    <!-- Feature Tab Content Button Start -->
                    <div class="feature-tab-content-btn">
                      <a href="#" class="btn-default btn-highlighted" contenteditable="false"
                        style="cursor: pointer">get started</a>
                    </div>
                    <!-- Feature Tab Content Button End -->
                  </div>
                  <!-- Feature Tab Content End -->
                </div>

                <div class="col-lg-6">
                  <!-- Feature Tab Image Start -->
                  <div class="feature-tab-img">
                    <figure>
                      <img src="./imgs/icons/ww1.png" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->

            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="event" role="tabpanel" aria-labelledby="event-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/cv2.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Comprehensive Approach</h3>
                        <p>
                          We guarantee that every stage is in line with international standards by offering end-to-end
                          support, from developing clinical evaluation strategies to post-market surveillance.
                        </p>

                      </div>
                    </div>
                    <!-- Feature Tab Content Header End -->

                    <!-- Feature Tab Content List Start -->

                    <!-- Feature Tab Content List End -->

                    <!-- Feature Tab Content Button Start -->
                    <div class="feature-tab-content-btn">
                      <a href="#" class="btn-default btn-highlighted" contenteditable="false"
                        style="cursor: pointer">get started</a>
                    </div>
                    <!-- Feature Tab Content Button End -->
                  </div>
                  <!-- Feature Tab Content End -->
                </div>

                <div class="col-lg-6">
                  <!-- Feature Tab Image Start -->
                  <div class="feature-tab-img">
                    <figure>
                      <img src="./imgs/icons/ww2.png" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->
            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="tailored" role="tabpanel" aria-labelledby="tailored-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/cv3.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Tailored Success</h3>
                        <p>
                          We customize our services according to your Medical Device unique requirements while taking
                          the nuances of various regional regulations, such as the FDA, EU MDR and other global
                          bodies.
                        </p>
                      </div>
                    </div>
                    <!-- Feature Tab Content Header End -->

                    <!-- Feature Tab Content List Start -->

                    <!-- Feature Tab Content List End -->

                    <!-- Feature Tab Content Button Start -->
                    <div class="feature-tab-content-btn">
                      <a href="#" class="btn-default btn-highlighted" contenteditable="false"
                        style="cursor: pointer">get started</a>
                    </div>
                    <!-- Feature Tab Content Button End -->
                  </div>
                  <!-- Feature Tab Content End -->
                </div>

                <div class="col-lg-6">
                  <!-- Feature Tab Image Start -->
                  <div class="feature-tab-img">
                    <figure>
                      <img src="./imgs/icons/ww3.png" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->
            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="meetings" role="tabpanel" aria-labelledby="meetings-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/cv3.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Proven Success</h3>
                        <p>
                          We are a reliable partner in attaining regulatory success because of our solid track record
                          of supporting successful submissions and approvals.
                        </p>
                      </div>
                    </div>
                    <!-- Feature Tab Content Header End -->

                    <!-- Feature Tab Content List Start -->

                    <!-- Feature Tab Content List End -->

                    <!-- Feature Tab Content Button Start -->
                    <div class="feature-tab-content-btn">
                      <a href="#" class="btn-default btn-highlighted" contenteditable="false"
                        style="cursor: pointer">get started</a>
                    </div>
                    <!-- Feature Tab Content Button End -->
                  </div>
                  <!-- Feature Tab Content End -->
                </div>

                <div class="col-lg-6">
                  <!-- Feature Tab Image Start -->
                  <div class="feature-tab-img">
                    <figure>
                      <img src="./imgs/icons/ww3.png" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->

            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="sessions" role="tabpanel" aria-labelledby="sessions-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/cv5.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Effective and Efficient</h3>
                        <p>
                          Our experts help you navigate the regulatory landscape with minimal delays and maximum
                          compliance, so your products reach the market faster.
                        </p>
                      </div>
                    </div>
                    <!-- Feature Tab Content Header End -->

                    <!-- Feature Tab Content List Start -->

                    <!-- Feature Tab Content List End -->

                    <!-- Feature Tab Content Button Start -->
                    <div class="feature-tab-content-btn">
                      <a href="#" class="btn-default btn-highlighted" contenteditable="false"
                        style="cursor: pointer">get started</a>
                    </div>
                    <!-- Feature Tab Content Button End -->
                  </div>
                  <!-- Feature Tab Content End -->
                </div>

                <div class="col-lg-6">
                  <!-- Feature Tab Image Start -->
                  <div class="feature-tab-img">
                    <figure>
                      <img src="./imgs/icons/ww4.png" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->

            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="puccess" role="tabpanel" aria-labelledby="puccess-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/cv4.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Proven Success</h3>
                        <p>
                          We are a reliable partner in attaining regulatory success because of our solid track record
                          of supporting successful submissions and approvals.

                        </p>
                      </div>
                    </div>
                    <!-- Feature Tab Content Header End -->

                    <!-- Feature Tab Content List Start -->

                    <!-- Feature Tab Content List End -->

                    <!-- Feature Tab Content Button Start -->
                    <div class="feature-tab-content-btn">
                      <a href="#" class="btn-default btn-highlighted" contenteditable="false"
                        style="cursor: pointer">get started</a>
                    </div>
                    <!-- Feature Tab Content Button End -->
                  </div>
                  <!-- Feature Tab Content End -->
                </div>

                <div class="col-lg-6">
                  <!-- Feature Tab Image Start -->
                  <div class="feature-tab-img">
                    <figure>
                      <img src="./imgs/icons/ww4.png" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->
          </div>
          <!-- Our Feature Box End -->
        </div>
      </div>
    </div>
  </div>
  <!-- Our Testimonial Section Start -->
  <div class="our-tesimonial">
    <div class="container">
      <div class="row section-row">
        <div class="col-lg-12">
          <!-- Section Title Start -->
          <div class="d-flex justify-content-between align-items-end">
            <div class="section-title">
              <h3 class="wow fadeInUp">testimonials</h3>
               <h2 class="text-anime-style-2">
   Hear from our <span>Global Leaders</span>
 </h2>
            </div>
            <div class="testimonial-arrows">
              <div class="slider-arrow swiper-button-prev">
                <i class="fa fa-chevron-left"></i>
              </div>
              <div class="slider-arrow swiper-button-next">
                <i class="fa fa-chevron-right"></i>
              </div>
            </div>
          </div>
          <!-- Section Title End -->
        </div>
      </div>

      <div class="row">
        <div class="col-lg-12">
          <!-- Testimonial Slider Start -->
          <div class="testimonial-slider">
            <div class="swiper">
              <div class="swiper-wrapper">
                <!-- Testimonial Slide Start -->
                <div class="swiper-slide">
                  <div class="testimonial-card">
                    <div class="star-rating">
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                    </div>
                    <p class="testimonial-quote">
                      "Partnering with easyQ Solutions was a game-changer for our regulatory compliance journey. Their
                      team streamlined our entire QMS setup and made compliance effortless."
                    </p>
                    <div class="testimonial-author">
                      <div class="author-image">AM</div>
                      <div class="author-info">
                        <h5>Anjali Mehra</h5>
                        <p>Quality Manager, BioMedix Pvt. Ltd.</p>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="swiper-slide">
                  <div class="testimonial-card">
                    <div class="star-rating">
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                    </div>
                    <p class="testimonial-quote">We were struggling with FDA 21 CFR Part 820 compliance, and easyQ
                      Solutions stepped in with a clear, actionable strategy.</p>
                    <div class="testimonial-author">
                      <div class="author-image">RD</div>
                      <div class="author-info">
                        <h5>Rahul Deshpande</h5>
                        <p>Operations Head, NeuroTech Lab</p>
                      </div>
                    </div>
                  </div>
                </div>
                <!-- Testimonial Slide End -->

                <div class="swiper-slide">
                  <div class="testimonial-card">
                    <div class="star-rating">
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                    </div>
                    <p class="testimonial-quote">
                      easyQ Solutions made our transition to a digital QMS effortless. From gap analysis to internal
                      audits, their hands-on guidance improved our operational efficiency.
                    </p>
                    <div class="testimonial-author">
                      <div class="author-image">DN</div>
                      <div class="author-info">
                        <h5>Divya Nair</h5>
                        <p>CEO, MedSoft Systems</p>
                      </div>
                    </div>
                  </div>
                </div>

                <div class="swiper-slide">
                  <div class="testimonial-card">
                    <div class="star-rating">
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                      <i class="fas fa-star star"></i>
                    </div>
                    <p class="testimonial-quote">
                      easyQ Solutions made our ISO 13485 certification process seamless. Their team's expertise and
                      attention to detail ensured we met all requirements swiftly and efficiently.
                    </p>
                    <div class="testimonial-author">
                      <div class="author-image">AS</div>
                      <div class="author-info">
                        <h5>Amit Sharma</h5>
                        <p>Quality Lead, Medica Instruments</p>
                      </div>
                    </div>
                  </div>
                </div>

                <!-- Testimonial Slide Start -->

                <!-- Testimonial Slide End -->
              </div>
            </div>
          </div>
          <!-- Testimonial Slider End -->
        </div>
      </div>
    </div>
  </div>
</asp:Content>

