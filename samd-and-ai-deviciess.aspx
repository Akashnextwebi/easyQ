<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="samd-and-ai-deviciess.aspx.cs" Inherits="samd_and_ai_deviciess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
  <!-- Hero Section Start -->
  <section class="easyq-hero-section services-banner">
    <div class="hero hero-image hero-slider-layout">
      <div class="hero-slide">
        <!-- Slider Image Start -->
        <div class="hero-slider-image">
          <img src="imgs/sh3.png" alt="" />
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
                  <h1 class="text-anime-style-2">Special Regulatory Support for Software as a Medical Device (SaMD) and
                    AI Medical Devices</h1>

                  <p class="wow fadeInUp">
                    At easyQ Solutions, we are proud to be one of the few consultancy firms specializing<br> in Software
                    as
                    a Medical Device (SaMD) and AI/ML-powered medical technologies.
                  </p>
                  <p class="wow fadeInUp">
                    We provide
                    dedicated Regulatory consultants with extensive knowledge of<br> AI/ML-based technologies and
                    Software
                    as a Medical Device (SaMD).</P>
                </div>
                <!-- Section Title End -->

                <!-- Hero Body Start -->
                <div class="hero-body wow fadeInUp" data-wow-delay="0.2s">
                  <!-- Hero Button Start -->
                  <div class="hero-btn">
                    <a href="/contact-us.aspx" class="btn-default btn-highlighted">Contact Us</a>
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
                <%--<div class="swiper-slide">
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
                Our consultants at easyQ Solutions offer special expertise to help you navigate the complexities of
                global approval processes ensuring you stay ahead in a regulatory environment that
                is becoming more complicated.
              </p>
              <p class="wow fadeInUp text-white" data-wow-delay="0.2s">Our experts are aware of the particular
                difficulties SaMD and AI-based devices encounter in regulatory settings.</p>
              <p class="wow fadeInUp text-white" data-wow-delay="0.2s">
                We offer end-to-end support across regions, including FDA (USA), EU MDR (Europe), and CDSCO (India) and
                other global approvals from pre-market strategy to post-market surveillance.
              </p>
              <p class="wow fadeInUp text-white" data-wow-delay="0.2s">
                Working closely with you, our experts make sure your device is compliant with both technical
                requirements and evolving regulatory guidelines, including algorithm transparency,
                clinical evaluation, and cybersecurity considerations.
              </p>
              <div class="row justify-content-center certicicate-images">
                <div class="col wow fadeInUp">
                  <div class="image">
                    <img src="imgs/certificates/1.webp" alt="" />
                  </div>
                </div>
                <div class="col wow fadeInUp">
                  <div class="image">
                    <img src="imgs/certificates/3.webp" alt="" />
                  </div>
                </div>
                <div class="col wow fadeInUp">
                  <div class="image">
                    <img src="imgs/certificates/4.webp" alt="" />
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
          <h5 class="mb-5 text-white">We support medical device manufacturers and companies with a comprehensive range
            of services including:</h5>
          <div class="faq-accordion" id="accordion">
            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp">
              <h2 class="accordion-header" id="heading1">
                <button class="accordion-button text-white" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse1" aria-expanded="true" aria-controls="collapse1">
                  Global Submissions
                </button>
              </h2>
              <div id="collapse1" class="accordion-collapse collapse show" aria-labelledby="heading1"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <p class="text-white">Proficiency in compiling complicated documents including:</p>
                  <ul>
                    <li>510(k)</li>
                    <li>PMA</li>
                    <li>De Novo submissions</li>
                    <li>Technical Files</li>
                    <li>GSPRs</li>
                    <li>Plant Master Files</li>
                    <li>Device Master Files</li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.2s">
              <h2 class="accordion-header" id="heading2">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse2" aria-expanded="false" aria-controls="collapse2">
                  Support in Product Testing
                </button>
              </h2>
              <div id="collapse2" class="accordion-collapse collapse" aria-labelledby="heading2"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>Specialized support for IEC 60601-1 (general safety) and IEC 60601-1-2 (EMC requirements).</li>
                    <li>Guidance in preparing for and navigating testing procedures.</li>
                    <li>Risk mitigation and compliance assurance through in-depth regulatory knowledge.</li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.4s">
              <h2 class="accordion-header" id="heading3">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse3" aria-expanded="false" aria-controls="collapse3">Cybersecurity</button>
              </h2>
              <div id="collapse3" class="accordion-collapse collapse" aria-labelledby="heading3"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>Compliance with international Standards like IEC 62304 and other requirements.</li>
                    <li>Detailed review and alignment of documentation with international guidance.</li>
                    <li>Ongoing support to keep up with evolving global cybersecurity expectations.</li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.6s">
              <h2 class="accordion-header" id="heading4">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse4" aria-expanded="false" aria-controls="collapse4">
                  Human Factors Engineering
                </button>
              </h2>
              <div id="collapse4" class="accordion-collapse collapse" aria-labelledby="heading4"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>Development of human factor validation protocols.</li>
                    <li>Expert assistance in planning and conducting usability testing.</li>
                    <li>Support to ensure product design meets efficiency and user-safety standards.</li>
                  </ul>
                </div>
              </div>
            </div>


            <div class="accordion-item wow fadeInUp" data-wow-delay="0.6s">
              <h2 class="accordion-header" id="heading5">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse5" aria-expanded="false" aria-controls="collapse5">
                  QMS

                </button>
              </h2>
              <div id="collapse5" class="accordion-collapse collapse" aria-labelledby="heading5"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>QMS Implementation
                    </li>
                    <li>Internal Audit
                    </li>
                    <li>Gap Asessment
                    </li>
                    <li>Risk Management

                    </li>
                    <li>Sipport in External Audit


                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->

            <!-- FAQ Item End -->
          </div>
          <!-- FAQ Accordion End -->
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
            Why Our Experts for SaMd & AI Medical Devices Global Regulatory
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
                  <div class="our-feature-nav wow fadeInUp" data-wow-delay="0.2s"
                    style="visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp">
                    <ul class="nav nav-tabs" id="myTab" role="tablist">
                      <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="documents-tab" data-bs-toggle="tab"
                          data-bs-target="#documents" type="button" role="tab" aria-selected="true">
                          <img src="./imgs/icons/11.png" alt="" />
                          Expertise in Emerging Technologies
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="event-tab" data-bs-toggle="tab" data-bs-target="#event"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/22.png" alt="" />
                          Proven Success Across Global Markets
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="meetings-tab" data-bs-toggle="tab" data-bs-target="#meetings"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/33.png" alt="" />
                          Up to Date with Evolving Guidelines
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="sessions-tab" data-bs-toggle="tab" data-bs-target="#sessions"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/44.png" alt="" />
                          End-to-End Support
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
                        <img src="./imgs/icons/11.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Expertise in Emerging Technologies</h3>
                        <p class="mb-2">At easyQ Solutions, expertise in SaMD and AI medical device compliance is held
                          by our
                          regulatory specialists.</p>
                        <p>
                          Global frameworks like FDA, CDSCO, and EU MDR are navigated by us to ensure that international
                          safety, performance, and documentation standards are met by your medical
                          device, allowing you to confidently enter global markets.
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
                      <img src="./imgs/icons/ww11.jpg" alt="" />
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
                        <img src="./imgs/icons/22.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Proven Success Across Global Markets</h3>
                        <p class="mb-2">We are aware of how SaMD and AI medical devices are dynamic.</p>
                        <p class="mb-2">We have a strong track record of assisting successful submissions, from FDA
                          510(k) and PMA to
                          CDSCO device registration and EU MDR Technical Files.</p>
                        <p>We have helped SaMd/Ai medical device companies of all sizes, from start-ups to major
                          corporations, acquire regulatory success across global markets.</p>
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
                      <img src="./imgs/icons/w22.jpg" alt="" />
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
                        <img src="./imgs/icons/33.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Up to Date with Evolving Guidelines</h3>
                        <p>SaMD and AI regulations are continuously evolving. We stay ahead of these changes to ensure
                          your device remains compliant with the latest standards.</p>
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
                      <img src="./imgs/icons/w33.jpg" alt="" />
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
                        <img src="./imgs/icons/44.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>End-to-End Support</h3>
                        <p>From classification and pre-market strategy to post-market surveillance and monitoring, we
                          offer comprehensive services throughout the regulatory journey.</p>
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
                      <img src="./imgs/icons/w44.jpg" alt="" />
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

