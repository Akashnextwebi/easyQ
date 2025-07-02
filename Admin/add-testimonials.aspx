<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-testimonials.aspx.cs" Inherits="Admin_add_testimonials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"><%=Request.QueryString["id"]==null?"Add":"Update" %> Testimonials</h4>

                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"]==null?"Add":"Update" %> Testimonials</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header align-items-center d-flex">
                            <h4 class="card-title mb-0 flex-grow-1"><%=Request.QueryString["id"]==null?"Add":"Update" %> Testimonials</h4>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-4 mb-2">
                                    <label>Name<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 acceptOnlyAlpha" ID="txtName" />
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtName" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4 mb-2">
                                    <label>Designation<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2" ID="txtDesignation" />
                                    <asp:RequiredFieldValidator ID="req2" runat="server" ControlToValidate="txtDesignation" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4 mb-2">
                                    <label>Stars (Rating)<sup>*</sup></label>
                                    <asp:DropDownList ID="ddlStar" runat="server" class="form-control mb-2 mr-sm-2">
                                        <asp:ListItem Value="5">5</asp:ListItem>
                                        <asp:ListItem Value="4">4</asp:ListItem>
                                        <asp:ListItem Value="3">3</asp:ListItem>
                                        <asp:ListItem Value="2">2</asp:ListItem>
                                        <asp:ListItem Value="1">1</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-lg-12 mb-2">
                                    <label>Details<sup>*</sup></label>
                                    <asp:TextBox ID="txtDetails" TextMode="MultiLine" class="form-control mb-2 mr-sm-2" Rows="3" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDetails" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-4 col-md-6">
                                    <asp:Button runat="server" ID="btnSave" CssClass="btn btn-primary waves-effect waves-light m-t-25" Text="Save" ValidationGroup="Save" OnClick="btnSave_Click" />
                                    <asp:Button runat="server" ID="btnNew" CssClass="btn btn-outline-danger waves-effect waves-light m-t-25" Text="Clear All" Visible="false" OnClick="btnNew_Click" />
                                    <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 mt-2">
                                    <p style="color: red; font-weight: bold;">Note : <sup>*</sup> are required fields</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header align-items-center d-flex">
                            <h4 class="card-title mb-0 flex-grow-1">Manage Testimonials</h4>
                        </div>
                        <div class="card-body">
                            <table id="alternative-pagination" class="table dt-responsive align-middle table-striped table-bordered myTable" style="width: 100%;">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Name</th>
                                        <th>Rating</th>
                                        <th>Destination</th>
                                        <th class="text-wrap-auto">Details</th>
                                        <th>Added On</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <%=strTestimonials %>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


