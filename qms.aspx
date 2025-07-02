<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="qms.aspx.cs" Inherits="qms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
  <!-- Hero Section Start -->
  <section class="easyq-hero-section services-banner">
    <div class="hero hero-image hero-slider-layout">
      <div class="hero-slide">
        <!-- Slider Image Start -->
        <div class="hero-slider-image">
          <img src="imgs/sh2.png" alt="" />
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
                  <h1 class="text-anime-style-2">Take Your Quality Management System (QMS) to New Heights with easyQ
                    Solutions</h1>

                  <p class="wow fadeInUp">
                    At easyQ Solutions, we provide comprehensive Quality Management System (QMS)<br> solutions designed
                    to
                    enhance compliance, and efficiency.
                  </p>
                  <p class="wow fadeInUp">Working closely with your company, our team
                    of experts develops and implements<br> QMS solutionssatisfying internal goals as well as regulatory
                    criteria.</p>
                  <p class="wow fadeInUp">Our customized solutions are designed to help you attain continuous<br>
                    improvement and long-term success
                  </p>
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
                easyQ Solutions is a trusted regulatory partner for Medical Device manufacturers looking for smooth
                market entry across the U.S., India, Europe, and other global regions.
              </p>
              <p class="wow fadeInUp text-white" data-wow-delay="0.2s">
                From defining precise quality objectives to building efficient procedures and documentation, we create
                the foundation for constant performance and continuous development. Our expert
                team guarantees that your QMS is scalable, regulatory compliant, and capable of supporting sustainable
                development in a competitive environment.
              </p>


              <div class="row justify-content-center certicicate-images">
                <div class="col wow fadeInUp"></div>
                <div class="hero-btn  services-btn">
                  <a href="#" class="btn-default bg-white btn-highlighted">Contact Us</a>
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
          <h5 class="mb-5 text-white">Our QMS services offers:</h5>
          <div class="faq-accordion" id="accordion">
            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp">
              <h2 class="accordion-header" id="heading1">
                <button class="accordion-button text-white" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse1" aria-expanded="true" aria-controls="collapse1">
                  Defining and Implementing QMS
                </button>
              </h2>
              <div id="collapse1" class="accordion-collapse collapse show" aria-labelledby="heading1"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <p class="text-white">
                    We provide a comprehensive solution for defining and applying a Quality Management System (QMS)
                    compliant with
                    <b>ISO 13485, 21 CFR Part 820</b>
                    , and other industry criteria. From developing your quality policy to simplifying procedures, our
                    experts will help you at every stage.
                  </p>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.2s">
              <h2 class="accordion-header" id="heading2">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse2" aria-expanded="false" aria-controls="collapse2">
                  Support in External Audit
                </button>
              </h2>
              <div id="collapse2" class="accordion-collapse collapse" aria-labelledby="heading2"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <p>
                    We are equipped to provide the necessary assistance for external audits conducted by us, thereby,
                    helping you to select the most suitable notified body. From the very beginning
                    till the very end, we offer you our full support, enabling you to sail majestically through the
                    certification process.
                  </p>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.4s">
              <h2 class="accordion-header" id="heading3">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse3" aria-expanded="false" aria-controls="collapse3">
                  Conducting Internal Audit
                </button>
              </h2>
              <div id="collapse3" class="accordion-collapse collapse" aria-labelledby="heading3"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>Our team of experienced professionals specialises in conducting thorough internal audits to find
                      latent chances for improvement, growth and effectiveness.</li>
                    <li>
                      In-depth internal audits are conducted to identify gaps and opportunities for improvement. Proven
                      methods are used to analyze your systems and effective Corrective and
                      Preventive Actions (CAPA) are implemented to boost operational efficiency and performance.
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.6s">
              <h2 class="accordion-header" id="heading4">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse4" aria-expanded="false" aria-controls="collapse4">Gap Assessment</button>
              </h2>
              <div id="collapse4" class="accordion-collapse collapse" aria-labelledby="heading4"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>Our professionals carefully review your existing QMS and identify those points where your system
                      has some gaps and is not working efficiently.</li>
                    <li>We also offer full implementation assistance to guarantee a hassle-free changeover.</li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- FAQ Item End -->

            <!-- FAQ Item Start -->
            <div class="accordion-item wow fadeInUp" data-wow-delay="0.6s">
              <h2 class="accordion-header" id="heading4">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                  data-bs-target="#collapse5" aria-expanded="false" aria-controls="collapse5">
                  Risk management and software processes
                </button>
              </h2>
              <div id="collapse5" class="accordion-collapse collapse" aria-labelledby="heading5"
                data-bs-parent="#accordion">
                <div class="accordion-body include-body">
                  <ul>
                    <li>Our solutions align perfectly with ISO 14971 and IEC 62304, providing you with more than just
                      process definitions.</li>
                    <li>We go further by helping you at each stage with our advisory and also hands-on support
                      throughout the implementation process.</li>
                  </ul>
                </div>
              </div>
            </div>

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
            Why Our Experts for your
            <span>QMS?</span>
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
                  <!-- Tab Nav Scroll Container -->
                  <div class="our-feature-nav wow fadeInUp" data-wow-delay="0.2s"
                    style="visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp">
                    <ul class="nav nav-tabs" id="myTab" role="tablist">
                      <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="documents-tab" data-bs-toggle="tab"
                          data-bs-target="#documents" type="button" role="tab" aria-selected="true">
                          <img src="./imgs/icons/111.png" alt="" />
                          Regulatory & Industry Expertise
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="event-tab" data-bs-toggle="tab" data-bs-target="#event"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/222.png" alt="" />
                          Built for Continuous Improvement
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="meetings-tab" data-bs-toggle="tab" data-bs-target="#meetings"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/333.png" alt="" />
                          Tailored, Business-Aligned Solutions
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="sessions-tab" data-bs-toggle="tab" data-bs-target="#sessions"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/444.png" alt="" />
                          Integrated with our own QMS Software
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="support-tab" data-bs-toggle="tab" data-bs-target="#support"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/44.png" alt="" />
                          End-to-End Implementation Support
                        </button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="scalable-tab" data-bs-toggle="tab" data-bs-target="#scalable"
                          type="button" role="tab" aria-selected="false" tabindex="-1">
                          <img src="./imgs/icons/666.png" alt="" />
                          Streamlined and Scalable
                        </button>
                      </li>
                    </ul>
                  </div>

                  <!-- Right Arrow -->

                </div>
                <div class="col-lg-0">
                  <button class="scroll-arrow right-arrow" type="button">
                    <i class="fas fa-chevron-right"></i>
                  </button>
                </div>
              </div>
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
                        <img src="./imgs/icons/111.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Regulatory & Industry Expertise</h3>
                        <p>Obrings deep knowledge of global regulatory standards and real-world experience across
                          industries, ensuring your QMS is both compliant and practical.</p>
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
                      <img src="./imgs/icons/w111.jpg" alt="" />
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
                        <img src="./imgs/icons/222.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Built for Continuous Improvement</h3>
                        <p>
                          Our process guarantees that your QMS doesn’t just meet current standards but it is on the
                          same
                          pace with the changes in the company to lift the future of your organization
                          but evolves with your organization to support future growth..
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
                      <img src="./imgs/icons/w222.jpg" alt="" />
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
                        <img src="./imgs/icons/333.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Tailored, Business-Aligned Solutions</h3>
                        <p>
                          Through our solutions, we align your internal organization unique processes and objectives
                          unique processes and objectives driving quality, operational efficiency, and
                          benefits over time.
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
                      <img src="./imgs/icons/w333.jpg" alt="" />
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
                        <img src="./imgs/icons/444.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Integrated with our own QMS Software</h3>
                        <p>We also offer our in-house QMS software designed specifically for medical device
                          companies
                          ensuring that you are in compliance with your requirements</p>
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
                      <img src="./imgs/icons/w444.jpg" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->
            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="support" role="tabpanel" aria-labelledby="support-tab">
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
                        <h3>End-to-End Implementation Support </h3>
                        <p>Starting with Gap Analysis and documentation to training of employees and audit readiness
                          we
                          offer full support at every step of the QMS journey.</p>
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
            <!-- Our Feature Item Start -->
            <div class="feature-tab-item tab-pane fade" id="scalable" role="tabpanel" aria-labelledby="scalable-tab">
              <div class="row align-items-center">
                <div class="col-lg-6">
                  <!-- Feature Tab Content Start -->
                  <div class="feature-tab-content">
                    <!-- Feature Tab Content Header Start -->
                    <div class="feature-tab-content-header">
                      <div class="icon-box">
                        <img src="./imgs/icons/666.png" alt="" />
                      </div>
                      <div class="feature-tab-header-content">
                        <h3>Streamlined and Scalable</h3>
                        <p>Whether you're a startup or an established enterprise, we support you to be scalable and
                          efficient</p>
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
                      <img src="./imgs/icons/w666.jpg" alt="" />
                    </figure>
                  </div>
                  <!-- Feature Tab Image End -->
                </div>
              </div>
            </div>
            <!-- Our Feature Item End -->
          </div>

        </div>

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

